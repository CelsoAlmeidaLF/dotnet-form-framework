
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
            this.Header = new System.Windows.Forms.Panel();
            this.toolHeader = new Systekna.Framework.WFControl.Views.toolHeader();
            this.linhaHeader = new System.Windows.Forms.Panel();
            this.Status = new System.Windows.Forms.Panel();
            this.infoVersion = new System.Windows.Forms.Label();
            this.linhaStatus = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Panel();
            this.linhaMenu = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.Section = new System.Windows.Forms.Panel();
            this.SectionViews = new Systekna.Framework.WFControl.Views.SectionViews();
            this.linhaHorizontalToolbar = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.ToolBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.Status.SuspendLayout();
            this.Menu.SuspendLayout();
            this.Section.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Header.Controls.Add(this.toolHeader);
            this.Header.Controls.Add(this.linhaHeader);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1016, 64);
            this.Header.TabIndex = 0;
            // 
            // toolHeader
            // 
            this.toolHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolHeader.Location = new System.Drawing.Point(0, 0);
            this.toolHeader.Name = "toolHeader";
            this.toolHeader.Size = new System.Drawing.Size(1016, 63);
            this.toolHeader.TabIndex = 1;
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
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Status.Controls.Add(this.infoVersion);
            this.Status.Controls.Add(this.linhaStatus);
            this.Status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Status.Location = new System.Drawing.Point(0, 561);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(1016, 32);
            this.Status.TabIndex = 2;
            // 
            // infoVersion
            // 
            this.infoVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.infoVersion.AutoSize = true;
            this.infoVersion.ForeColor = System.Drawing.Color.White;
            this.infoVersion.Location = new System.Drawing.Point(893, 10);
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
            this.linhaStatus.Size = new System.Drawing.Size(1016, 1);
            this.linhaStatus.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Menu.Controls.Add(this.linhaMenu);
            this.Menu.Controls.Add(this.btnMenu);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 64);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(42, 497);
            this.Menu.TabIndex = 3;
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
            // Section
            // 
            this.Section.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Section.Controls.Add(this.SectionViews);
            this.Section.Controls.Add(this.ToolBar);
            this.Section.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Section.Location = new System.Drawing.Point(42, 64);
            this.Section.Name = "Section";
            this.Section.Size = new System.Drawing.Size(974, 497);
            this.Section.TabIndex = 4;
            // 
            // SectionViews
            // 
            this.SectionViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionViews.Location = new System.Drawing.Point(0, 32);
            this.SectionViews.Name = "SectionViews";
            this.SectionViews.Size = new System.Drawing.Size(974, 465);
            this.SectionViews.TabIndex = 2;
            // 
            // linhaHorizontalToolbar
            // 
            this.linhaHorizontalToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.linhaHorizontalToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaHorizontalToolbar.Location = new System.Drawing.Point(0, 31);
            this.linhaHorizontalToolbar.Name = "linhaHorizontalToolbar";
            this.linhaHorizontalToolbar.Size = new System.Drawing.Size(974, 1);
            this.linhaHorizontalToolbar.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(942, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 31);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "RF";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnConfig
            // 
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Location = new System.Drawing.Point(910, 0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(32, 31);
            this.btnConfig.TabIndex = 2;
            this.btnConfig.Text = "C";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ToolBar.Controls.Add(this.btnNovo);
            this.ToolBar.Controls.Add(this.panel2);
            this.ToolBar.Controls.Add(this.btnConfig);
            this.ToolBar.Controls.Add(this.btnRefresh);
            this.ToolBar.Controls.Add(this.linhaHorizontalToolbar);
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(974, 32);
            this.ToolBar.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 31);
            this.panel2.TabIndex = 7;
            // 
            // btnNovo
            // 
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(32, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(42, 31);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 593);
            this.Controls.Add(this.Section);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Header);
            this.MinimumSize = new System.Drawing.Size(1032, 632);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Systekna Dashboard Simple 0.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Header.ResumeLayout(false);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Section.ResumeLayout(false);
            this.ToolBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel linhaHeader;
        private System.Windows.Forms.Panel Status;
        private System.Windows.Forms.Panel linhaStatus;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel linhaMenu;
        private System.Windows.Forms.Panel Section;
        private Systekna.Framework.WFControl.Views.toolHeader toolHeader;
        private System.Windows.Forms.Button btnMenu;
        private Systekna.Framework.WFControl.Views.SectionViews SectionViews;
        private System.Windows.Forms.Label infoVersion;
        private System.Windows.Forms.Panel ToolBar;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel linhaHorizontalToolbar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panel2;
    }
}