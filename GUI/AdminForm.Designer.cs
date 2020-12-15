
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
            this.UHeader = new System.Windows.Forms.Panel();
            this.u_Header = new Systekna.Framework.WFControl.Views.toolHeader();
            this.linhaHeader = new System.Windows.Forms.Panel();
            this.UStaus = new System.Windows.Forms.Panel();
            this.linhaStatus = new System.Windows.Forms.Panel();
            this.UMenu = new System.Windows.Forms.Panel();
            this.linhaMenu = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.USection = new System.Windows.Forms.Panel();
            this.Desktop = new Systekna.Framework.WFControl.Views.SectionViews();
            this.uToolBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UHeader.SuspendLayout();
            this.UStaus.SuspendLayout();
            this.UMenu.SuspendLayout();
            this.USection.SuspendLayout();
            this.uToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // UHeader
            // 
            this.UHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.UHeader.Controls.Add(this.u_Header);
            this.UHeader.Controls.Add(this.linhaHeader);
            this.UHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.UHeader.Location = new System.Drawing.Point(0, 0);
            this.UHeader.Name = "UHeader";
            this.UHeader.Size = new System.Drawing.Size(1016, 64);
            this.UHeader.TabIndex = 0;
            // 
            // u_Header
            // 
            this.u_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.u_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.u_Header.Location = new System.Drawing.Point(0, 0);
            this.u_Header.Name = "u_Header";
            this.u_Header.Size = new System.Drawing.Size(1016, 63);
            this.u_Header.TabIndex = 1;
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
            // UStaus
            // 
            this.UStaus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.UStaus.Controls.Add(this.label1);
            this.UStaus.Controls.Add(this.linhaStatus);
            this.UStaus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UStaus.Location = new System.Drawing.Point(0, 561);
            this.UStaus.Name = "UStaus";
            this.UStaus.Size = new System.Drawing.Size(1016, 32);
            this.UStaus.TabIndex = 2;
            // 
            // linhaStatus
            // 
            this.linhaStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.linhaStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.linhaStatus.Location = new System.Drawing.Point(0, 0);
            this.linhaStatus.Name = "linhaStatus";
            this.linhaStatus.Size = new System.Drawing.Size(1016, 1);
            this.linhaStatus.TabIndex = 0;
            // 
            // UMenu
            // 
            this.UMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.UMenu.Controls.Add(this.linhaMenu);
            this.UMenu.Controls.Add(this.btnMenu);
            this.UMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.UMenu.Location = new System.Drawing.Point(0, 64);
            this.UMenu.Name = "UMenu";
            this.UMenu.Size = new System.Drawing.Size(42, 497);
            this.UMenu.TabIndex = 3;
            // 
            // linhaMenu
            // 
            this.linhaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.linhaMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.linhaMenu.Location = new System.Drawing.Point(41, 0);
            this.linhaMenu.Name = "linhaMenu";
            this.linhaMenu.Size = new System.Drawing.Size(1, 497);
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
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // USection
            // 
            this.USection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.USection.Controls.Add(this.Desktop);
            this.USection.Controls.Add(this.uToolBar);
            this.USection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USection.Location = new System.Drawing.Point(42, 64);
            this.USection.Name = "USection";
            this.USection.Size = new System.Drawing.Size(974, 497);
            this.USection.TabIndex = 4;
            // 
            // Desktop
            // 
            this.Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Desktop.Location = new System.Drawing.Point(0, 32);
            this.Desktop.Name = "Desktop";
            this.Desktop.Size = new System.Drawing.Size(974, 465);
            this.Desktop.TabIndex = 2;
            // 
            // uToolBar
            // 
            this.uToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uToolBar.Controls.Add(this.panel1);
            this.uToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.uToolBar.Location = new System.Drawing.Point(0, 0);
            this.uToolBar.Name = "uToolBar";
            this.uToolBar.Size = new System.Drawing.Size(974, 32);
            this.uToolBar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 1);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(893, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dashboard basic v0.1";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 593);
            this.Controls.Add(this.USection);
            this.Controls.Add(this.UMenu);
            this.Controls.Add(this.UStaus);
            this.Controls.Add(this.UHeader);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Systekna Dashboard Simple 0.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.UHeader.ResumeLayout(false);
            this.UStaus.ResumeLayout(false);
            this.UStaus.PerformLayout();
            this.UMenu.ResumeLayout(false);
            this.USection.ResumeLayout(false);
            this.uToolBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UHeader;
        private System.Windows.Forms.Panel linhaHeader;
        private System.Windows.Forms.Panel UStaus;
        private System.Windows.Forms.Panel linhaStatus;
        private System.Windows.Forms.Panel UMenu;
        private System.Windows.Forms.Panel linhaMenu;
        private System.Windows.Forms.Panel USection;
        private Systekna.Framework.WFControl.Views.toolHeader u_Header;
        private System.Windows.Forms.Button btnMenu;
        private Systekna.Framework.WFControl.Views.SectionViews Desktop;
        private System.Windows.Forms.Panel uToolBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}