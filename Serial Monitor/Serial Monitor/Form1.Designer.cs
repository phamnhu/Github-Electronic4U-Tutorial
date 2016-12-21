namespace ZKI
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.select_com = new System.Windows.Forms.ComboBox();
            this.BaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Status_lable1 = new System.Windows.Forms.Label();
            this.BT_connect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearall = new System.Windows.Forms.Button();
            this.bt_write = new System.Windows.Forms.Button();
            this.bt_read = new System.Windows.Forms.Button();
            this.autoscroll = new System.Windows.Forms.CheckBox();
            this.Status = new System.Windows.Forms.ProgressBar();
            this.Exit = new System.Windows.Forms.Button();
            this.BT_Send = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.text_Receiver = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.text_send = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // select_com
            // 
            this.select_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_com.FormattingEnabled = true;
            this.select_com.Location = new System.Drawing.Point(10, 60);
            this.select_com.Name = "select_com";
            this.select_com.Size = new System.Drawing.Size(96, 21);
            this.select_com.TabIndex = 0;
            this.select_com.SelectedIndexChanged += new System.EventHandler(this.select_com_SelectedIndexChanged);
            // 
            // BaudRate
            // 
            this.BaudRate.AutoCompleteCustomSource.AddRange(new string[] {
            " 9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRate.FormattingEnabled = true;
            this.BaudRate.Items.AddRange(new object[] {
            " 9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "250000",
            "500000"});
            this.BaudRate.Location = new System.Drawing.Point(10, 100);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(96, 21);
            this.BaudRate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Status_lable1
            // 
            this.Status_lable1.AutoSize = true;
            this.Status_lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_lable1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Status_lable1.Location = new System.Drawing.Point(14, 165);
            this.Status_lable1.Name = "Status_lable1";
            this.Status_lable1.Size = new System.Drawing.Size(85, 16);
            this.Status_lable1.TabIndex = 5;
            this.Status_lable1.Text = "Disconnect";
            this.Status_lable1.Click += new System.EventHandler(this.label4_Click);
            // 
            // BT_connect
            // 
            this.BT_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_connect.ForeColor = System.Drawing.Color.Red;
            this.BT_connect.Location = new System.Drawing.Point(10, 183);
            this.BT_connect.Name = "BT_connect";
            this.BT_connect.Size = new System.Drawing.Size(96, 23);
            this.BT_connect.TabIndex = 6;
            this.BT_connect.Text = "Connect";
            this.BT_connect.UseVisualStyleBackColor = true;
            this.BT_connect.Click += new System.EventHandler(this.BT_connect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearall);
            this.groupBox1.Controls.Add(this.bt_write);
            this.groupBox1.Controls.Add(this.bt_read);
            this.groupBox1.Controls.Add(this.autoscroll);
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Controls.Add(this.Exit);
            this.groupBox1.Controls.Add(this.select_com);
            this.groupBox1.Controls.Add(this.BT_Send);
            this.groupBox1.Controls.Add(this.BT_connect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Status_lable1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BaudRate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(802, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 488);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // clearall
            // 
            this.clearall.AutoEllipsis = true;
            this.clearall.Enabled = false;
            this.clearall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearall.ForeColor = System.Drawing.Color.Red;
            this.clearall.Location = new System.Drawing.Point(10, 434);
            this.clearall.Name = "clearall";
            this.clearall.Size = new System.Drawing.Size(96, 23);
            this.clearall.TabIndex = 642;
            this.clearall.Text = "Clear All";
            this.clearall.UseVisualStyleBackColor = true;
            this.clearall.Click += new System.EventHandler(this.clearall_Click);
            // 
            // bt_write
            // 
            this.bt_write.Enabled = false;
            this.bt_write.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_write.ForeColor = System.Drawing.Color.Red;
            this.bt_write.Location = new System.Drawing.Point(10, 384);
            this.bt_write.Name = "bt_write";
            this.bt_write.Size = new System.Drawing.Size(96, 23);
            this.bt_write.TabIndex = 641;
            this.bt_write.Text = "Write file";
            this.bt_write.UseVisualStyleBackColor = true;
            this.bt_write.Click += new System.EventHandler(this.bt_write_Click);
            // 
            // bt_read
            // 
            this.bt_read.Enabled = false;
            this.bt_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_read.ForeColor = System.Drawing.Color.Red;
            this.bt_read.Location = new System.Drawing.Point(9, 351);
            this.bt_read.Name = "bt_read";
            this.bt_read.Size = new System.Drawing.Size(96, 23);
            this.bt_read.TabIndex = 640;
            this.bt_read.Text = "Read file";
            this.bt_read.UseVisualStyleBackColor = true;
            this.bt_read.Click += new System.EventHandler(this.opendata_Click);
            // 
            // autoscroll
            // 
            this.autoscroll.AllowDrop = true;
            this.autoscroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.autoscroll.AutoSize = true;
            this.autoscroll.Checked = true;
            this.autoscroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoscroll.Enabled = false;
            this.autoscroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoscroll.Location = new System.Drawing.Point(10, 465);
            this.autoscroll.Name = "autoscroll";
            this.autoscroll.Size = new System.Drawing.Size(88, 17);
            this.autoscroll.TabIndex = 639;
            this.autoscroll.Text = "Auto Scroll";
            this.autoscroll.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Red;
            this.Status.ForeColor = System.Drawing.Color.Lime;
            this.Status.Location = new System.Drawing.Point(10, 140);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(95, 20);
            this.Status.TabIndex = 635;
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(10, 18);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(96, 28);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // BT_Send
            // 
            this.BT_Send.Enabled = false;
            this.BT_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Send.ForeColor = System.Drawing.Color.Red;
            this.BT_Send.Location = new System.Drawing.Point(10, 252);
            this.BT_Send.Name = "BT_Send";
            this.BT_Send.Size = new System.Drawing.Size(96, 56);
            this.BT_Send.TabIndex = 1;
            this.BT_Send.Text = "Send";
            this.BT_Send.UseVisualStyleBackColor = true;
            this.BT_Send.Click += new System.EventHandler(this.BT_Send_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.text_Receiver);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(0, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(802, 358);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receiver Here";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // text_Receiver
            // 
            this.text_Receiver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_Receiver.Location = new System.Drawing.Point(3, 19);
            this.text_Receiver.Multiline = true;
            this.text_Receiver.Name = "text_Receiver";
            this.text_Receiver.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text_Receiver.Size = new System.Drawing.Size(796, 333);
            this.text_Receiver.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.text_send);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(802, 124);
            this.groupBox4.TabIndex = 148;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Send Here";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // text_send
            // 
            this.text_send.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_send.Location = new System.Drawing.Point(3, 16);
            this.text_send.Multiline = true;
            this.text_send.Name = "text_send";
            this.text_send.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text_send.Size = new System.Drawing.Size(796, 105);
            this.text_send.TabIndex = 0;
            this.text_send.TextChanged += new System.EventHandler(this.text_send_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 488);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Serial Monitor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox select_com;
        private System.Windows.Forms.ComboBox BaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Status_lable1;
        private System.Windows.Forms.Button BT_connect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox text_Receiver;
        private System.Windows.Forms.Button BT_Send;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox text_send;
        private System.Windows.Forms.ProgressBar Status;
        private System.Windows.Forms.CheckBox autoscroll;
        private System.Windows.Forms.Button bt_write;
        private System.Windows.Forms.Button bt_read;
        private System.Windows.Forms.Button clearall;
    }
}

