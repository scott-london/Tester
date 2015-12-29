namespace Tester
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
            this.connect = new System.Windows.Forms.LinkLabel();
            this.connectStatus = new System.Windows.Forms.Label();
            this.oAuthBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.AutoSize = true;
            this.connect.Location = new System.Drawing.Point(753, 9);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(47, 13);
            this.connect.TabIndex = 0;
            this.connect.TabStop = true;
            this.connect.Text = "Connect";
            this.connect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.connect_LinkClicked);
            // 
            // connectStatus
            // 
            this.connectStatus.AutoSize = true;
            this.connectStatus.Location = new System.Drawing.Point(12, 9);
            this.connectStatus.Name = "connectStatus";
            this.connectStatus.Size = new System.Drawing.Size(73, 13);
            this.connectStatus.TabIndex = 1;
            this.connectStatus.Text = "Disconnected";
            // 
            // oAuthBrowser
            // 
            this.oAuthBrowser.Location = new System.Drawing.Point(15, 32);
            this.oAuthBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.oAuthBrowser.Name = "oAuthBrowser";
            this.oAuthBrowser.Size = new System.Drawing.Size(785, 401);
            this.oAuthBrowser.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 455);
            this.Controls.Add(this.oAuthBrowser);
            this.Controls.Add(this.connectStatus);
            this.Controls.Add(this.connect);
            this.Name = "Form1";
            this.Text = "Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel connect;
        private System.Windows.Forms.Label connectStatus;
        private System.Windows.Forms.WebBrowser oAuthBrowser;
    }
}

