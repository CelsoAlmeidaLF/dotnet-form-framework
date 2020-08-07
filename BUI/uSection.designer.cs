namespace BUI
{
    partial class uSection
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
            this.toolBar_Title = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.uTitle = new System.Windows.Forms.Label();
            this.linha = new System.Windows.Forms.Panel();
            this.linhaToolbar = new System.Windows.Forms.Panel();
            this.uArea = new System.Windows.Forms.Panel();
            this.uToolbar.SuspendLayout();
            this.toolBar_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // uToolbar
            // 
            this.uToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uToolbar.Controls.Add(this.toolBar_Title);
            this.uToolbar.Controls.Add(this.linha);
            this.uToolbar.Controls.Add(this.linhaToolbar);
            this.uToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.uToolbar.Location = new System.Drawing.Point(0, 0);
            this.uToolbar.Name = "uToolbar";
            this.uToolbar.Size = new System.Drawing.Size(800, 24);
            this.uToolbar.TabIndex = 0;
            // 
            // toolBar_Title
            // 
            this.toolBar_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.toolBar_Title.Controls.Add(this.btnClose);
            this.toolBar_Title.Controls.Add(this.uTitle);
            this.toolBar_Title.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolBar_Title.Location = new System.Drawing.Point(12, 0);
            this.toolBar_Title.Name = "toolBar_Title";
            this.toolBar_Title.Size = new System.Drawing.Size(180, 22);
            this.toolBar_Title.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(158, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 22);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // uTitle
            // 
            this.uTitle.AutoSize = true;
            this.uTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uTitle.ForeColor = System.Drawing.Color.White;
            this.uTitle.Location = new System.Drawing.Point(24, 3);
            this.uTitle.Margin = new System.Windows.Forms.Padding(5);
            this.uTitle.Name = "uTitle";
            this.uTitle.Size = new System.Drawing.Size(111, 16);
            this.uTitle.TabIndex = 0;
            this.uTitle.Text = "Documento  [ 01 ]";
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
            this.linhaToolbar.Size = new System.Drawing.Size(800, 2);
            this.linhaToolbar.TabIndex = 2;
            // 
            // uArea
            // 
            this.uArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.uArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uArea.Location = new System.Drawing.Point(0, 24);
            this.uArea.Name = "uArea";
            this.uArea.Size = new System.Drawing.Size(800, 476);
            this.uArea.TabIndex = 1;
            // 
            // uSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uArea);
            this.Controls.Add(this.uToolbar);
            this.Name = "uSection";
            this.Size = new System.Drawing.Size(800, 500);
            this.uToolbar.ResumeLayout(false);
            this.toolBar_Title.ResumeLayout(false);
            this.toolBar_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uToolbar;
        private System.Windows.Forms.Panel uArea;
        private System.Windows.Forms.Panel toolBar_Title;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label uTitle;
        private System.Windows.Forms.Panel linha;
        private System.Windows.Forms.Panel linhaToolbar;
    }
}
