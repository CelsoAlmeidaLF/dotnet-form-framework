namespace UI
{
    partial class GUI
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
            this.UHeader = new System.Windows.Forms.Panel();
            this.UMenu = new System.Windows.Forms.Panel();
            this.USection = new System.Windows.Forms.Panel();
            this.linhaHeader = new System.Windows.Forms.Panel();
            this.linhaMenu = new System.Windows.Forms.Panel();
            this.UHeader.SuspendLayout();
            this.UMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // UHeader
            // 
            this.UHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.UHeader.Controls.Add(this.linhaHeader);
            this.UHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.UHeader.Location = new System.Drawing.Point(0, 0);
            this.UHeader.Name = "UHeader";
            this.UHeader.Size = new System.Drawing.Size(893, 64);
            this.UHeader.TabIndex = 0;
            // 
            // UMenu
            // 
            this.UMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.UMenu.Controls.Add(this.linhaMenu);
            this.UMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.UMenu.Location = new System.Drawing.Point(0, 64);
            this.UMenu.Name = "UMenu";
            this.UMenu.Size = new System.Drawing.Size(42, 481);
            this.UMenu.TabIndex = 0;
            // 
            // USection
            // 
            this.USection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.USection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USection.Location = new System.Drawing.Point(42, 64);
            this.USection.Name = "USection";
            this.USection.Size = new System.Drawing.Size(851, 481);
            this.USection.TabIndex = 1;
            // 
            // linhaHeader
            // 
            this.linhaHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linhaHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaHeader.Location = new System.Drawing.Point(0, 62);
            this.linhaHeader.Name = "linhaHeader";
            this.linhaHeader.Size = new System.Drawing.Size(893, 2);
            this.linhaHeader.TabIndex = 0;
            // 
            // linhaMenu
            // 
            this.linhaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.linhaMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.linhaMenu.Location = new System.Drawing.Point(41, 0);
            this.linhaMenu.Name = "linhaMenu";
            this.linhaMenu.Size = new System.Drawing.Size(1, 481);
            this.linhaMenu.TabIndex = 0;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 545);
            this.Controls.Add(this.USection);
            this.Controls.Add(this.UMenu);
            this.Controls.Add(this.UHeader);
            this.Name = "GUI";
            this.Text = "GUI";
            this.UHeader.ResumeLayout(false);
            this.UMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UHeader;
        private System.Windows.Forms.Panel UMenu;
        private System.Windows.Forms.Panel USection;
        private System.Windows.Forms.Panel linhaHeader;
        private System.Windows.Forms.Panel linhaMenu;
    }
}