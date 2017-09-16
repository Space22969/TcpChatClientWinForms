namespace TCPChatClient
{
    partial class Settings
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
            this.SaveSettings = new System.Windows.Forms.Button();
            this.CloseSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveSettings
            // 
            this.SaveSettings.Location = new System.Drawing.Point(36, 75);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.Size = new System.Drawing.Size(75, 23);
            this.SaveSettings.TabIndex = 0;
            this.SaveSettings.Text = "Сохранить";
            this.SaveSettings.UseVisualStyleBackColor = true;
            this.SaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // CloseSettings
            // 
            this.CloseSettings.Location = new System.Drawing.Point(153, 75);
            this.CloseSettings.Name = "CloseSettings";
            this.CloseSettings.Size = new System.Drawing.Size(75, 23);
            this.CloseSettings.TabIndex = 1;
            this.CloseSettings.Text = "Закрыть";
            this.CloseSettings.UseVisualStyleBackColor = true;
            this.CloseSettings.Click += new System.EventHandler(this.CloseSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Адрес сервера:";
            // 
            // inputAddress
            // 
            this.inputAddress.Location = new System.Drawing.Point(15, 36);
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.Size = new System.Drawing.Size(243, 20);
            this.inputAddress.TabIndex = 4;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 121);
            this.Controls.Add(this.inputAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseSettings);
            this.Controls.Add(this.SaveSettings);
            this.Name = "Settings";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveSettings;
        private System.Windows.Forms.Button CloseSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputAddress;
    }
}