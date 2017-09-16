namespace TCPChatClient
{
    partial class LoginWindow
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
            this.ShowSettings = new System.Windows.Forms.Button();
            this.SignInBut = new System.Windows.Forms.Button();
            this.RegBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ShowSettings
            // 
            this.ShowSettings.Location = new System.Drawing.Point(197, 12);
            this.ShowSettings.Name = "ShowSettings";
            this.ShowSettings.Size = new System.Drawing.Size(75, 23);
            this.ShowSettings.TabIndex = 0;
            this.ShowSettings.Text = "Настройки";
            this.ShowSettings.UseVisualStyleBackColor = true;
            this.ShowSettings.Click += new System.EventHandler(this.ShowSettings_Click);
            // 
            // SignInBut
            // 
            this.SignInBut.Location = new System.Drawing.Point(26, 208);
            this.SignInBut.Name = "SignInBut";
            this.SignInBut.Size = new System.Drawing.Size(75, 23);
            this.SignInBut.TabIndex = 1;
            this.SignInBut.Text = "Вход";
            this.SignInBut.UseVisualStyleBackColor = true;
            this.SignInBut.Click += new System.EventHandler(this.SignInBut_Click);
            // 
            // RegBut
            // 
            this.RegBut.Location = new System.Drawing.Point(146, 208);
            this.RegBut.Name = "RegBut";
            this.RegBut.Size = new System.Drawing.Size(93, 23);
            this.RegBut.TabIndex = 2;
            this.RegBut.Text = "Регистрация";
            this.RegBut.UseVisualStyleBackColor = true;
            this.RegBut.Click += new System.EventHandler(this.RegBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 6;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegBut);
            this.Controls.Add(this.SignInBut);
            this.Controls.Add(this.ShowSettings);
            this.Name = "LoginWindow";
            this.Text = "LoginWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowSettings;
        private System.Windows.Forms.Button SignInBut;
        private System.Windows.Forms.Button RegBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}