
namespace _62Server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListening = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtFileaddress = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnShake = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.cboIP = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnListening
            // 
            this.btnListening.Location = new System.Drawing.Point(453, 49);
            this.btnListening.Margin = new System.Windows.Forms.Padding(2);
            this.btnListening.Name = "btnListening";
            this.btnListening.Size = new System.Drawing.Size(84, 31);
            this.btnListening.TabIndex = 0;
            this.btnListening.Text = "开始监听";
            this.btnListening.UseVisualStyleBackColor = true;
            this.btnListening.Click += new System.EventHandler(this.btnListening_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(55, 300);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(2);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(589, 169);
            this.txtMsg.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(55, 50);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 27);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Text = "请输入服务器IP地址";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(270, 50);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(160, 27);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "请输入服务器端口号";
            // 
            // txtFileaddress
            // 
            this.txtFileaddress.Location = new System.Drawing.Point(55, 496);
            this.txtFileaddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtFileaddress.Name = "txtFileaddress";
            this.txtFileaddress.Size = new System.Drawing.Size(493, 27);
            this.txtFileaddress.TabIndex = 5;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(559, 496);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(2);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(85, 27);
            this.btnChoose.TabIndex = 6;
            this.btnChoose.Text = "选择";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(665, 496);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 27);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "发送文件";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(665, 300);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(90, 70);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "发送";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnShake
            // 
            this.btnShake.Location = new System.Drawing.Point(665, 399);
            this.btnShake.Margin = new System.Windows.Forms.Padding(2);
            this.btnShake.Name = "btnShake";
            this.btnShake.Size = new System.Drawing.Size(90, 70);
            this.btnShake.TabIndex = 9;
            this.btnShake.Text = "震动";
            this.btnShake.UseVisualStyleBackColor = true;
            this.btnShake.Click += new System.EventHandler(this.btnShake_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(55, 100);
            this.txtLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(700, 170);
            this.txtLog.TabIndex = 11;
            // 
            // cboIP
            // 
            this.cboIP.FormattingEnabled = true;
            this.cboIP.Location = new System.Drawing.Point(559, 49);
            this.cboIP.Margin = new System.Windows.Forms.Padding(2);
            this.cboIP.Name = "cboIP";
            this.cboIP.Size = new System.Drawing.Size(196, 28);
            this.cboIP.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.cboIP);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnShake);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.txtFileaddress);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnListening);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Electric wave 服务端v1.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListening;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtFileaddress;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnShake;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ComboBox cboIP;
    }
}

