namespace simplechatapp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.guiserver = new System.Windows.Forms.Button();
            this.txtthongdiepserver = new System.Windows.Forms.TextBox();
            this.exitserver = new System.Windows.Forms.Button();
            this.clearserver = new System.Windows.Forms.Button();
            this.savetofileserver = new System.Windows.Forms.Button();
            this.loadfileserver = new System.Windows.Forms.Button();
            this.txtnoidungchatserver = new System.Windows.Forms.RichTextBox();
            this.Stopserver = new System.Windows.Forms.Button();
            this.Startserver = new System.Windows.Forms.Button();
            this.numserverport = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gui = new System.Windows.Forms.Button();
            this.txtthongdiep = new System.Windows.Forms.TextBox();
            this.exitclient = new System.Windows.Forms.Button();
            this.clearclient = new System.Windows.Forms.Button();
            this.savefileclient = new System.Windows.Forms.Button();
            this.loadfileclient = new System.Windows.Forms.Button();
            this.txtnoidungchat = new System.Windows.Forms.RichTextBox();
            this.disconnect = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.portnumber = new System.Windows.Forms.NumericUpDown();
            this.ipnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numserverport)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portnumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(51, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(759, 398);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.guiserver);
            this.tabPage1.Controls.Add(this.txtthongdiepserver);
            this.tabPage1.Controls.Add(this.exitserver);
            this.tabPage1.Controls.Add(this.clearserver);
            this.tabPage1.Controls.Add(this.savetofileserver);
            this.tabPage1.Controls.Add(this.loadfileserver);
            this.tabPage1.Controls.Add(this.txtnoidungchatserver);
            this.tabPage1.Controls.Add(this.Stopserver);
            this.tabPage1.Controls.Add(this.Startserver);
            this.tabPage1.Controls.Add(this.numserverport);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(751, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SERVER MODE";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // guiserver
            // 
            this.guiserver.Location = new System.Drawing.Point(614, 340);
            this.guiserver.Name = "guiserver";
            this.guiserver.Size = new System.Drawing.Size(75, 23);
            this.guiserver.TabIndex = 31;
            this.guiserver.Text = "Send";
            this.guiserver.UseVisualStyleBackColor = true;
            this.guiserver.Click += new System.EventHandler(this.guiserver_Click);
            // 
            // txtthongdiepserver
            // 
            this.txtthongdiepserver.Location = new System.Drawing.Point(21, 343);
            this.txtthongdiepserver.Name = "txtthongdiepserver";
            this.txtthongdiepserver.Size = new System.Drawing.Size(563, 20);
            this.txtthongdiepserver.TabIndex = 30;
            // 
            // exitserver
            // 
            this.exitserver.Location = new System.Drawing.Point(654, 230);
            this.exitserver.Name = "exitserver";
            this.exitserver.Size = new System.Drawing.Size(75, 23);
            this.exitserver.TabIndex = 29;
            this.exitserver.Text = "Exit";
            this.exitserver.UseVisualStyleBackColor = true;
            this.exitserver.Click += new System.EventHandler(this.exitserver_Click);
            // 
            // clearserver
            // 
            this.clearserver.Location = new System.Drawing.Point(654, 166);
            this.clearserver.Name = "clearserver";
            this.clearserver.Size = new System.Drawing.Size(75, 23);
            this.clearserver.TabIndex = 28;
            this.clearserver.Text = "Clear";
            this.clearserver.UseVisualStyleBackColor = true;
            this.clearserver.Click += new System.EventHandler(this.clearserver_Click);
            // 
            // savetofileserver
            // 
            this.savetofileserver.Location = new System.Drawing.Point(654, 121);
            this.savetofileserver.Name = "savetofileserver";
            this.savetofileserver.Size = new System.Drawing.Size(75, 23);
            this.savetofileserver.TabIndex = 27;
            this.savetofileserver.Text = "Save to file";
            this.savetofileserver.UseVisualStyleBackColor = true;
            this.savetofileserver.Click += new System.EventHandler(this.savetofileserver_Click);
            // 
            // loadfileserver
            // 
            this.loadfileserver.Location = new System.Drawing.Point(643, 75);
            this.loadfileserver.Name = "loadfileserver";
            this.loadfileserver.Size = new System.Drawing.Size(86, 23);
            this.loadfileserver.TabIndex = 26;
            this.loadfileserver.Text = "Load from file";
            this.loadfileserver.UseVisualStyleBackColor = true;
            this.loadfileserver.Click += new System.EventHandler(this.loadfileserver_Click);
            // 
            // txtnoidungchatserver
            // 
            this.txtnoidungchatserver.Location = new System.Drawing.Point(21, 44);
            this.txtnoidungchatserver.Name = "txtnoidungchatserver";
            this.txtnoidungchatserver.Size = new System.Drawing.Size(616, 278);
            this.txtnoidungchatserver.TabIndex = 25;
            this.txtnoidungchatserver.Text = "";
            // 
            // Stopserver
            // 
            this.Stopserver.Location = new System.Drawing.Point(503, 14);
            this.Stopserver.Name = "Stopserver";
            this.Stopserver.Size = new System.Drawing.Size(75, 23);
            this.Stopserver.TabIndex = 3;
            this.Stopserver.Text = "Stop server";
            this.Stopserver.UseVisualStyleBackColor = true;
            this.Stopserver.Click += new System.EventHandler(this.Stopserver_Click);
            // 
            // Startserver
            // 
            this.Startserver.Location = new System.Drawing.Point(315, 14);
            this.Startserver.Name = "Startserver";
            this.Startserver.Size = new System.Drawing.Size(75, 23);
            this.Startserver.TabIndex = 2;
            this.Startserver.Text = "Start server";
            this.Startserver.UseVisualStyleBackColor = true;
            this.Startserver.Click += new System.EventHandler(this.Startserver_Click);
            // 
            // numserverport
            // 
            this.numserverport.Location = new System.Drawing.Point(125, 17);
            this.numserverport.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numserverport.Name = "numserverport";
            this.numserverport.Size = new System.Drawing.Size(120, 20);
            this.numserverport.TabIndex = 1;
            this.numserverport.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listen on port:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gui);
            this.tabPage2.Controls.Add(this.txtthongdiep);
            this.tabPage2.Controls.Add(this.exitclient);
            this.tabPage2.Controls.Add(this.clearclient);
            this.tabPage2.Controls.Add(this.savefileclient);
            this.tabPage2.Controls.Add(this.loadfileclient);
            this.tabPage2.Controls.Add(this.txtnoidungchat);
            this.tabPage2.Controls.Add(this.disconnect);
            this.tabPage2.Controls.Add(this.connect);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.portnumber);
            this.tabPage2.Controls.Add(this.ipnumber);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(751, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CLIENT MODE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gui
            // 
            this.gui.Location = new System.Drawing.Point(613, 340);
            this.gui.Name = "gui";
            this.gui.Size = new System.Drawing.Size(75, 23);
            this.gui.TabIndex = 24;
            this.gui.Text = "Send";
            this.gui.UseVisualStyleBackColor = true;
            this.gui.Click += new System.EventHandler(this.gui_Click);
            // 
            // txtthongdiep
            // 
            this.txtthongdiep.Location = new System.Drawing.Point(25, 343);
            this.txtthongdiep.Name = "txtthongdiep";
            this.txtthongdiep.Size = new System.Drawing.Size(563, 20);
            this.txtthongdiep.TabIndex = 23;
            // 
            // exitclient
            // 
            this.exitclient.Location = new System.Drawing.Point(658, 253);
            this.exitclient.Name = "exitclient";
            this.exitclient.Size = new System.Drawing.Size(75, 23);
            this.exitclient.TabIndex = 22;
            this.exitclient.Text = "Exit";
            this.exitclient.UseVisualStyleBackColor = true;
            this.exitclient.Click += new System.EventHandler(this.exitclient_Click);
            // 
            // clearclient
            // 
            this.clearclient.Location = new System.Drawing.Point(658, 195);
            this.clearclient.Name = "clearclient";
            this.clearclient.Size = new System.Drawing.Size(75, 23);
            this.clearclient.TabIndex = 21;
            this.clearclient.Text = "Clear";
            this.clearclient.UseVisualStyleBackColor = true;
            this.clearclient.Click += new System.EventHandler(this.clearclient_Click);
            // 
            // savefileclient
            // 
            this.savefileclient.Location = new System.Drawing.Point(658, 139);
            this.savefileclient.Name = "savefileclient";
            this.savefileclient.Size = new System.Drawing.Size(75, 23);
            this.savefileclient.TabIndex = 20;
            this.savefileclient.Text = "Save to file";
            this.savefileclient.UseVisualStyleBackColor = true;
            this.savefileclient.Click += new System.EventHandler(this.savefileclient_Click);
            // 
            // loadfileclient
            // 
            this.loadfileclient.Location = new System.Drawing.Point(647, 85);
            this.loadfileclient.Name = "loadfileclient";
            this.loadfileclient.Size = new System.Drawing.Size(86, 23);
            this.loadfileclient.TabIndex = 19;
            this.loadfileclient.Text = "Load from file";
            this.loadfileclient.UseVisualStyleBackColor = true;
            this.loadfileclient.Click += new System.EventHandler(this.loadfileclient_Click);
            // 
            // txtnoidungchat
            // 
            this.txtnoidungchat.Location = new System.Drawing.Point(25, 48);
            this.txtnoidungchat.Name = "txtnoidungchat";
            this.txtnoidungchat.Size = new System.Drawing.Size(616, 275);
            this.txtnoidungchat.TabIndex = 18;
            this.txtnoidungchat.Text = "";
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(581, 18);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(75, 23);
            this.disconnect.TabIndex = 17;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(433, 19);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 16;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Port";
            // 
            // portnumber
            // 
            this.portnumber.Location = new System.Drawing.Point(327, 22);
            this.portnumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.portnumber.Name = "portnumber";
            this.portnumber.Size = new System.Drawing.Size(59, 20);
            this.portnumber.TabIndex = 14;
            this.portnumber.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // ipnumber
            // 
            this.ipnumber.Location = new System.Drawing.Point(128, 21);
            this.ipnumber.Name = "ipnumber";
            this.ipnumber.Size = new System.Drawing.Size(100, 20);
            this.ipnumber.TabIndex = 12;
            this.ipnumber.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Connect to server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 427);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numserverport)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portnumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Stopserver;
        private System.Windows.Forms.Button Startserver;
        private System.Windows.Forms.NumericUpDown numserverport;
        private System.Windows.Forms.NumericUpDown portnumber;
        private System.Windows.Forms.TextBox ipnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button guiserver;
        private System.Windows.Forms.TextBox txtthongdiepserver;
        private System.Windows.Forms.Button exitserver;
        private System.Windows.Forms.Button clearserver;
        private System.Windows.Forms.Button savetofileserver;
        private System.Windows.Forms.Button loadfileserver;
        private System.Windows.Forms.RichTextBox txtnoidungchatserver;
        private System.Windows.Forms.Button gui;
        private System.Windows.Forms.TextBox txtthongdiep;
        private System.Windows.Forms.Button exitclient;
        private System.Windows.Forms.Button clearclient;
        private System.Windows.Forms.Button savefileclient;
        private System.Windows.Forms.Button loadfileclient;
        private System.Windows.Forms.RichTextBox txtnoidungchat;
    }
}

