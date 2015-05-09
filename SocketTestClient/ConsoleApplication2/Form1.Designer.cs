namespace ConsoleApplication2
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
            this.Btn_SendMessage = new System.Windows.Forms.Button();
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.listBox_MessageList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_SendMessage
            // 
            this.Btn_SendMessage.Location = new System.Drawing.Point(187, 348);
            this.Btn_SendMessage.Name = "Btn_SendMessage";
            this.Btn_SendMessage.Size = new System.Drawing.Size(75, 21);
            this.Btn_SendMessage.TabIndex = 0;
            this.Btn_SendMessage.Text = "Send";
            this.Btn_SendMessage.UseVisualStyleBackColor = true;
            this.Btn_SendMessage.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Message
            // 
            this.textBox_Message.Location = new System.Drawing.Point(12, 348);
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(169, 21);
            this.textBox_Message.TabIndex = 1;
            // 
            // listBox_MessageList
            // 
            this.listBox_MessageList.FormattingEnabled = true;
            this.listBox_MessageList.ItemHeight = 12;
            this.listBox_MessageList.Location = new System.Drawing.Point(12, 56);
            this.listBox_MessageList.Name = "listBox_MessageList";
            this.listBox_MessageList.Size = new System.Drawing.Size(250, 268);
            this.listBox_MessageList.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Connect);
            this.panel1.Controls.Add(this.textBox_IP);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 31);
            this.panel1.TabIndex = 3;
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(3, 3);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(172, 21);
            this.textBox_IP.TabIndex = 0;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(181, 3);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 1;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox_MessageList);
            this.Controls.Add(this.textBox_Message);
            this.Controls.Add(this.Btn_SendMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_SendMessage;
        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.ListBox listBox_MessageList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox textBox_IP;
    }
}