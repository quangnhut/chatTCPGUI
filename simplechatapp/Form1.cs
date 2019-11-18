using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace simplechatapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Socket sckServer, sckClient;
        Socket sck;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //khoi tao server
        private void Startserver_Click(object sender, EventArgs e)
        {
            //Tao socket
            sckServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Bind, Listen
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, (int)numserverport.Value);
            sckServer.Bind(ep);
            sckServer.Listen(5);
            sckServer.BeginAccept(new AsyncCallback(xulyketnoi), null);
        }
        private void xulyketnoi(IAsyncResult result)
        {
            sckClient = sckServer.EndAccept(result);
            //Bat dau nhan du lieu
            sckClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(xulydulieunhanduoc), null);
        }
        byte[] data = new byte[1024];
        private void xulydulieunhanduoc(IAsyncResult result)
        {
            //Goi ham EndReceive
            int size = sckClient.EndReceive(result);
            //Xu ly du lieu nhan duoc trong data[]
            String thongdiep = Encoding.ASCII.GetString(data, 0, size);
            //Chen thong diep vao textbox noidungchat
            txtnoidungchatserver.Invoke(new CapNhatGiaoDien(CapNhatNoiDungChatserver), new object[] { "[Client]: " + thongdiep });
            //Cho nhan tiep
            sckClient.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(xulydulieunhanduoc), null);
        }
        delegate void CapNhatGiaoDien(string s);
        void CapNhatNoiDungChatserver(string s)
        {
            txtnoidungchatserver.Text += s + "\r\n";
        }
        private void guiserver_Click(object sender, EventArgs e)
        {
            sckClient.BeginSend(Encoding.ASCII.GetBytes(txtthongdiepserver.Text), 0, txtthongdiepserver.Text.Length, SocketFlags.None, new AsyncCallback(xulydulieuguiserver), null);
            CapNhatNoiDungChatserver("[Server]: " + txtthongdiepserver.Text);
            txtthongdiepserver.Text = "";
        }
        //client ket noi
        private void connect_Click(object sender, EventArgs e)
        {
            //tao socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //connect
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ipnumber.Text), (int)portnumber.Value);
            sck.BeginConnect(ep, new AsyncCallback(xulyketnoiclient), null);
        }
        private void xulyketnoiclient(IAsyncResult result)
        {
            sck.EndConnect(result);
            //Bat dau nhan du lieu
            sck.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(xulydulieunhanduocclient), null);
        }
        private void xulydulieunhanduocclient(IAsyncResult result)
        {
            //Goi ham EndReceive
            int size = sck.EndReceive(result);
            //Xu ly du lieu nhan duoc trong data[]
            String thongdiep = Encoding.ASCII.GetString(data, 0, size);
            //Chen thong diep vao textbox noidungchat
            txtnoidungchat.Invoke(new CapNhatGiaoDien(CapNhatNoiDungChat), new object[] { "[Server]: " + thongdiep });
            //Cho nhan tiep
            sck.BeginReceive(data, 0, 1024, SocketFlags.None, new AsyncCallback(xulydulieunhanduocclient), null);
        }
       
        void CapNhatNoiDungChat(string s)
        {
            txtnoidungchat.Text += s + "\r\n";
        }

        private void Stopserver_Click(object sender, EventArgs e)
        {
            sckClient.Close();
            sckServer.Close();
        }
        private void xulydulieuguiserver(IAsyncResult ar)
        {
            sckClient.EndSend(ar);
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            sck.Close();
        }

        private void gui_Click(object sender, EventArgs e)
        {
            sck.BeginSend(Encoding.ASCII.GetBytes(txtthongdiep.Text), 0, txtthongdiep.Text.Length, SocketFlags.None, new AsyncCallback(xulydulieuguiclient), null);
            CapNhatNoiDungChat("[Client]: " + txtthongdiep.Text);
            txtthongdiep.Text = "";
        }   

        private void xulydulieuguiclient(IAsyncResult ar)
        {
            sck.EndSend(ar);
        }
        static int BUFFERSIZE = 1024 * 5000;
        byte[] data1 = new byte[BUFFERSIZE];

        //load file
        private void loadfileserver_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"E:\CNTT\LapTrinhMang\simplechatapp\simplechatapp\file\log.txt");
            string fileName = fi.Name;
            FileStream fs = fi.OpenRead();
            int n;
            n = fs.Read(data1, 0, BUFFERSIZE);
            sckClient.BeginSend(Encoding.ASCII.GetBytes(Encoding.ASCII.GetString(data1,0,n)),0, Encoding.ASCII.GetString(data1, 0, n).Length,SocketFlags.None, new AsyncCallback(xulydulieuguiserver), null);
            CapNhatNoiDungChatserver("[Server]: " + Encoding.ASCII.GetString(data1, 0, n));
            txtthongdiepserver.Text = "";
            fs.Close();
        }

        private void loadfileclient_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"E:\CNTT\LapTrinhMang\simplechatapp\simplechatapp\file\log.txt");
            string fileName = fi.Name;
            FileStream fs = fi.OpenRead();
            int n;
            n = fs.Read(data1, 0, BUFFERSIZE);
            sck.BeginSend(Encoding.ASCII.GetBytes(Encoding.ASCII.GetString(data1, 0, n)), 0, Encoding.ASCII.GetString(data1, 0, n).Length, SocketFlags.None, new AsyncCallback(xulydulieuguiclient), null);
            CapNhatNoiDungChat("[Client]: " + Encoding.ASCII.GetString(data1, 0, n));
            txtthongdiep.Text = "";
            fs.Close();
        }

        private void clearclient_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa", "thông báo", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                txtnoidungchat.Text = "";
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearserver_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa", "thông báo", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                txtnoidungchatserver.Text = "";
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitclient_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Thoát không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void exitserver_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Thoát không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        //luu vao file
        private void savetofileserver_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog() { Filter = "(tất cả các tệp)|*.*|(các tệp excel)|*.txt" })
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string path = @"E:\CNTT\LapTrinhMang\simplechatapp\simplechatapp\file\log.txt";
                   
                    // Luu text vao file
                    string writeText = txtnoidungchatserver.Text + Environment.NewLine;
                    File.AppendAllText(path, writeText);
                }
            }
        }
        private void savefileclient_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog() { Filter = "(tất cả các tệp)|*.*|(các tệp excel)|*.txt" })
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string path = @"E:\CNTT\LapTrinhMang\simplechatapp\simplechatapp\file\log.txt";

                    // Luu text vao file
                    string writeText = txtnoidungchat.Text + Environment.NewLine;
                    File.AppendAllText(path, writeText);
                }
            }
        }
    }
}
