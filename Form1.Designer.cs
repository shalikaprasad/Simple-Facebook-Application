namespace Facebook
{
    partial class facebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(facebook));
            this.facebook_logo = new System.Windows.Forms.PictureBox();
            this.facebook_window = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.facebook_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // facebook_logo
            // 
            this.facebook_logo.BackColor = System.Drawing.Color.Transparent;
            this.facebook_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.facebook_logo.ErrorImage = null;
            this.facebook_logo.Image = global::Facebook.Properties.Resources._174848;
            this.facebook_logo.Location = new System.Drawing.Point(12, 12);
            this.facebook_logo.Name = "facebook_logo";
            this.facebook_logo.Size = new System.Drawing.Size(130, 109);
            this.facebook_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.facebook_logo.TabIndex = 0;
            this.facebook_logo.TabStop = false;
            // 
            // facebook_window
            // 
            this.facebook_window.AllowWebBrowserDrop = false;
            this.facebook_window.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.facebook_window.IsWebBrowserContextMenuEnabled = false;
            this.facebook_window.Location = new System.Drawing.Point(13, 128);
            this.facebook_window.MinimumSize = new System.Drawing.Size(20, 20);
            this.facebook_window.Name = "facebook_window";
            this.facebook_window.ScriptErrorsSuppressed = true;
            this.facebook_window.Size = new System.Drawing.Size(452, 289);
            this.facebook_window.TabIndex = 1;
            this.facebook_window.Url = new System.Uri("http://www.facebook.com", System.UriKind.Absolute);
            this.facebook_window.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.facebook_window_DocumentCompleted);
            // 
            // facebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Facebook.Properties.Resources._11;
            this.ClientSize = new System.Drawing.Size(477, 448);
            this.Controls.Add(this.facebook_window);
            this.Controls.Add(this.facebook_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "facebook";
            this.Opacity = 0.98D;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.facebook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facebook_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox facebook_logo;
        private System.Windows.Forms.WebBrowser facebook_window;
    }
}

