namespace Systekna.Framework.WFControl.Views
{
    partial class SectionViews
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.uToolbar = new System.Windows.Forms.Panel();
            this.toolbarTitle = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.TitleDocument = new System.Windows.Forms.Label();
            this.linha = new System.Windows.Forms.Panel();
            this.linhaToolbar = new System.Windows.Forms.Panel();
            this.Area = new System.Windows.Forms.Panel();
            this.uToolbar.SuspendLayout();
            this.toolbarTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // uToolbar
            // 
            this.uToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uToolbar.Controls.Add(this.toolbarTitle);
            this.uToolbar.Controls.Add(this.linha);
            this.uToolbar.Controls.Add(this.linhaToolbar);
            this.uToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.uToolbar.Location = new System.Drawing.Point(0, 0);
            this.uToolbar.Name = "uToolbar";
            this.uToolbar.Size = new System.Drawing.Size(925, 24);
            this.uToolbar.TabIndex = 0;
            // 
            // toolbarTitle
            // 
            this.toolbarTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.toolbarTitle.Controls.Add(this.btnClose);
            this.toolbarTitle.Controls.Add(this.TitleDocument);
            this.toolbarTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolbarTitle.Location = new System.Drawing.Point(12, 0);
            this.toolbarTitle.Name = "toolbarTitle";
            this.toolbarTitle.Size = new System.Drawing.Size(100, 22);
            this.toolbarTitle.TabIndex = 4;
            this.toolbarTitle.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(78, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 22);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TitleDocument
            // 
            this.TitleDocument.AutoSize = true;
            this.TitleDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleDocument.ForeColor = System.Drawing.Color.White;
            this.TitleDocument.Location = new System.Drawing.Point(16, 3);
            this.TitleDocument.Margin = new System.Windows.Forms.Padding(5);
            this.TitleDocument.Name = "TitleDocument";
            this.TitleDocument.Size = new System.Drawing.Size(0, 16);
            this.TitleDocument.TabIndex = 0;
            // 
            // linha
            // 
            this.linha.Dock = System.Windows.Forms.DockStyle.Left;
            this.linha.Location = new System.Drawing.Point(0, 0);
            this.linha.Name = "linha";
            this.linha.Size = new System.Drawing.Size(12, 22);
            this.linha.TabIndex = 3;
            // 
            // linhaToolbar
            // 
            this.linhaToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linhaToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaToolbar.Location = new System.Drawing.Point(0, 22);
            this.linhaToolbar.Name = "linhaToolbar";
            this.linhaToolbar.Size = new System.Drawing.Size(925, 2);
            this.linhaToolbar.TabIndex = 2;
            // 
            // Area
            // 
            this.Area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.Area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Area.Location = new System.Drawing.Point(0, 24);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(925, 523);
            this.Area.TabIndex = 1;
            this.Area.Visible = false;
            // 
            // SectionViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Area);
            this.Controls.Add(this.uToolbar);
            this.Name = "SectionViews";
            this.Size = new System.Drawing.Size(925, 547);
            this.uToolbar.ResumeLayout(false);
            this.toolbarTitle.ResumeLayout(false);
            this.toolbarTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uToolbar;
        private System.Windows.Forms.Panel Area;
        private System.Windows.Forms.Panel toolbarTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label TitleDocument;
        private System.Windows.Forms.Panel linha;
        private System.Windows.Forms.Panel linhaToolbar;
    }
}
