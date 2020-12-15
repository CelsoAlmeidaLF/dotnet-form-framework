
namespace BUI.ViewsLogin
{
    partial class LoginView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login = new System.Windows.Forms.Panel();
            this.Background = new System.Windows.Forms.Panel();
            this.imgBackgrund = new System.Windows.Forms.PictureBox();
            this.Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackgrund)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login.Dock = System.Windows.Forms.DockStyle.Left;
            this.Login.Location = new System.Drawing.Point(0, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(516, 632);
            this.Login.TabIndex = 0;
            // 
            // Background
            // 
            this.Background.Controls.Add(this.imgBackgrund);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(516, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(516, 632);
            this.Background.TabIndex = 1;
            // 
            // imgBackgrund
            // 
            this.imgBackgrund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgBackgrund.Location = new System.Drawing.Point(0, 0);
            this.imgBackgrund.Name = "imgBackgrund";
            this.imgBackgrund.Size = new System.Drawing.Size(516, 632);
            this.imgBackgrund.TabIndex = 0;
            this.imgBackgrund.TabStop = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.Background);
            this.Controls.Add(this.Login);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(1032, 632);
            this.Background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBackgrund)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Login;
        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.PictureBox imgBackgrund;
    }
}
