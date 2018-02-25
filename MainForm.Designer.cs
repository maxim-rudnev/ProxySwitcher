namespace ProxySwitcher
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxProxyEnabled = new System.Windows.Forms.CheckBox();
            this.buttonSaveProxyConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(52, 24);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(179, 20);
            this.textBoxIP.TabIndex = 1;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(289, 24);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(59, 20);
            this.textBoxPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PORT";
            // 
            // checkBoxProxyEnabled
            // 
            this.checkBoxProxyEnabled.AutoSize = true;
            this.checkBoxProxyEnabled.Location = new System.Drawing.Point(32, 59);
            this.checkBoxProxyEnabled.Name = "checkBoxProxyEnabled";
            this.checkBoxProxyEnabled.Size = new System.Drawing.Size(93, 17);
            this.checkBoxProxyEnabled.TabIndex = 4;
            this.checkBoxProxyEnabled.Text = "Proxy enabled";
            this.checkBoxProxyEnabled.UseVisualStyleBackColor = true;
            // 
            // buttonSaveProxyConfig
            // 
            this.buttonSaveProxyConfig.Location = new System.Drawing.Point(32, 92);
            this.buttonSaveProxyConfig.Name = "buttonSaveProxyConfig";
            this.buttonSaveProxyConfig.Size = new System.Drawing.Size(316, 23);
            this.buttonSaveProxyConfig.TabIndex = 5;
            this.buttonSaveProxyConfig.Text = "Save configuration";
            this.buttonSaveProxyConfig.UseVisualStyleBackColor = true;
            this.buttonSaveProxyConfig.Click += new System.EventHandler(this.buttonSaveProxyConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 148);
            this.Controls.Add(this.buttonSaveProxyConfig);
            this.Controls.Add(this.checkBoxProxyEnabled);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ProxySwitcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxProxyEnabled;
        private System.Windows.Forms.Button buttonSaveProxyConfig;
    }
}

