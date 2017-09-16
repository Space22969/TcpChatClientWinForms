namespace TCPChatClient
{
    partial class MainWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChatBody = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Online = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Send = new System.Windows.Forms.Button();
            this.SendBody = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ChatBody);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 211);
            this.panel1.TabIndex = 0;
            // 
            // ChatBody
            // 
            this.ChatBody.Location = new System.Drawing.Point(12, 12);
            this.ChatBody.Name = "ChatBody";
            this.ChatBody.ReadOnly = true;
            this.ChatBody.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ChatBody.Size = new System.Drawing.Size(344, 178);
            this.ChatBody.TabIndex = 0;
            this.ChatBody.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.Online);
            this.panel2.Location = new System.Drawing.Point(394, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 211);
            this.panel2.TabIndex = 1;
            // 
            // Online
            // 
            this.Online.FormattingEnabled = true;
            this.Online.Location = new System.Drawing.Point(3, 6);
            this.Online.Name = "Online";
            this.Online.Size = new System.Drawing.Size(155, 199);
            this.Online.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.Send);
            this.panel3.Controls.Add(this.SendBody);
            this.panel3.Location = new System.Drawing.Point(12, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 65);
            this.panel3.TabIndex = 2;
            // 
            // Send
            // 
            this.Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Send.Location = new System.Drawing.Point(410, 21);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(100, 31);
            this.Send.TabIndex = 1;
            this.Send.Text = "Отправить";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // SendBody
            // 
            this.SendBody.Location = new System.Drawing.Point(14, 32);
            this.SendBody.Name = "SendBody";
            this.SendBody.Size = new System.Drawing.Size(344, 20);
            this.SendBody.TabIndex = 0;
            this.SendBody.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendBody_KeyDown);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 317);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox ChatBody;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox Online;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox SendBody;
    }
}