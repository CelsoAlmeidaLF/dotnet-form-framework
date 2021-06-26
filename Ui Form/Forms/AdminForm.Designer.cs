
namespace Systekna.Framework.Forms
{
    partial class AdminForm
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
            this.linhaHeader = new System.Windows.Forms.Panel();
            this.fFooter = new System.Windows.Forms.Panel();
            this.infoVersion = new System.Windows.Forms.Label();
            this.linhaStatus = new System.Windows.Forms.Panel();
            this.fHeader = new System.Windows.Forms.Panel();
            this.toolHeader1 = new Systekna.Framework.WFControl.Views.toolHeader();
            this.linhaHorizontalToolbar = new System.Windows.Forms.Panel();
            this.fLateral = new System.Windows.Forms.Panel();
            this.linhaMenu = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.fSection = new System.Windows.Forms.Panel();
            this.sectionViews = new Systekna.Framework.WFControl.Views.SectionViews();
            this.fFooter.SuspendLayout();
            this.fHeader.SuspendLayout();
            this.fLateral.SuspendLayout();
            this.fSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // linhaHeader
            // 
            this.linhaHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.linhaHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaHeader.Location = new System.Drawing.Point(0, 63);
            this.linhaHeader.Name = "linhaHeader";
            this.linhaHeader.Size = new System.Drawing.Size(1016, 1);
            this.linhaHeader.TabIndex = 0;
            // 
            // fFooter
            // 
            this.fFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.fFooter.Controls.Add(this.infoVersion);
            this.fFooter.Controls.Add(this.linhaStatus);
            this.fFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fFooter.Location = new System.Drawing.Point(0, 495);
            this.fFooter.Name = "fFooter";
            this.fFooter.Size = new System.Drawing.Size(930, 32);
            this.fFooter.TabIndex = 2;
            // 
            // infoVersion
            // 
            this.infoVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.infoVersion.AutoSize = true;
            this.infoVersion.ForeColor = System.Drawing.Color.White;
            this.infoVersion.Location = new System.Drawing.Point(807, 10);
            this.infoVersion.Name = "infoVersion";
            this.infoVersion.Size = new System.Drawing.Size(111, 13);
            this.infoVersion.TabIndex = 3;
            this.infoVersion.Text = "Dashboard basic v0.1";
            // 
            // linhaStatus
            // 
            this.linhaStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.linhaStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.linhaStatus.Location = new System.Drawing.Point(0, 0);
            this.linhaStatus.Name = "linhaStatus";
            this.linhaStatus.Size = new System.Drawing.Size(930, 1);
            this.linhaStatus.TabIndex = 0;
            // 
            // fHeader
            // 
            this.fHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.fHeader.Controls.Add(this.toolHeader1);
            this.fHeader.Controls.Add(this.linhaHorizontalToolbar);
            this.fHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.fHeader.Location = new System.Drawing.Point(0, 0);
            this.fHeader.Name = "fHeader";
            this.fHeader.Size = new System.Drawing.Size(930, 64);
            this.fHeader.TabIndex = 6;
            // 
            // toolHeader1
            // 
            this.toolHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolHeader1.Location = new System.Drawing.Point(0, 0);
            this.toolHeader1.Name = "toolHeader1";
            this.toolHeader1.Size = new System.Drawing.Size(930, 63);
            this.toolHeader1.TabIndex = 1;
            // 
            // linhaHorizontalToolbar
            // 
            this.linhaHorizontalToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.linhaHorizontalToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaHorizontalToolbar.Location = new System.Drawing.Point(0, 63);
            this.linhaHorizontalToolbar.Name = "linhaHorizontalToolbar";
            this.linhaHorizontalToolbar.Size = new System.Drawing.Size(930, 1);
            this.linhaHorizontalToolbar.TabIndex = 0;
            // 
            // fLateral
            // 
            this.fLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.fLateral.Controls.Add(this.linhaMenu);
            this.fLateral.Controls.Add(this.btnMenu);
            this.fLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.fLateral.Location = new System.Drawing.Point(0, 64);
            this.fLateral.Name = "fLateral";
            this.fLateral.Size = new System.Drawing.Size(42, 431);
            this.fLateral.TabIndex = 8;
            // 
            // linhaMenu
            // 
            this.linhaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.linhaMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.linhaMenu.Location = new System.Drawing.Point(41, 0);
            this.linhaMenu.Name = "linhaMenu";
            this.linhaMenu.Size = new System.Drawing.Size(1, 431);
            this.linhaMenu.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = global::UI.Properties.Resources.Row_256;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(12, 7);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(16, 16);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMenu_MouseClick);
            // 
            // fSection
            // 
            this.fSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.fSection.Controls.Add(this.sectionViews);
            this.fSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fSection.Location = new System.Drawing.Point(42, 64);
            this.fSection.Name = "fSection";
            this.fSection.Size = new System.Drawing.Size(888, 431);
            this.fSection.TabIndex = 9;
            // 
            // sectionViews
            // 
            this.sectionViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sectionViews.Location = new System.Drawing.Point(0, 0);
            this.sectionViews.Name = "sectionViews";
            this.sectionViews.NDoc = 0;
            this.sectionViews.Size = new System.Drawing.Size(888, 431);
            this.sectionViews.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 527);
            this.Controls.Add(this.fSection);
            this.Controls.Add(this.fLateral);
            this.Controls.Add(this.fHeader);
            this.Controls.Add(this.fFooter);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Systekna Dashboard Simple 0.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.fFooter.ResumeLayout(false);
            this.fFooter.PerformLayout();
            this.fHeader.ResumeLayout(false);
            this.fLateral.ResumeLayout(false);
            this.fSection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel linhaHeader;
        private System.Windows.Forms.Panel fFooter;
        private System.Windows.Forms.Panel linhaStatus;
        private System.Windows.Forms.Label infoVersion;
        private System.Windows.Forms.Panel fHeader;
        private System.Windows.Forms.Panel linhaHorizontalToolbar;
        private System.Windows.Forms.Panel fLateral;
        private System.Windows.Forms.Panel linhaMenu;
        private System.Windows.Forms.Button btnMenu;
        private WFControl.Views.toolHeader toolHeader1;
        private System.Windows.Forms.Panel fSection;
        private WFControl.Views.SectionViews sectionViews;
    }
}