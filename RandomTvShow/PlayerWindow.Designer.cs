namespace RandomTvShow
{
    partial class PlayerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerWindow));
            this.ShowPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowPlayer
            // 
            this.ShowPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowPlayer.Enabled = true;
            this.ShowPlayer.Location = new System.Drawing.Point(0, 0);
            this.ShowPlayer.Name = "ShowPlayer";
            this.ShowPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ShowPlayer.OcxState")));
            this.ShowPlayer.Size = new System.Drawing.Size(627, 419);
            this.ShowPlayer.TabIndex = 0;
            // 
            // PlayerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 419);
            this.Controls.Add(this.ShowPlayer);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayerWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ShowPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer ShowPlayer;
    }
}