namespace BUI
{
    partial class uHeader
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
            this.inf_Empresa = new System.Windows.Forms.Panel();
            this.infEmp_Descricao = new System.Windows.Forms.Label();
            this.infEmp_nomeEmpresa = new System.Windows.Forms.Label();
            this.infEmp_imgLogo = new System.Windows.Forms.PictureBox();
            this.inf_User = new System.Windows.Forms.Panel();
            this.infUser_Descricao = new System.Windows.Forms.Label();
            this.infUser_Nome = new System.Windows.Forms.Label();
            this.infUser_fotoPerfil = new System.Windows.Forms.PictureBox();
            this.uPainel = new System.Windows.Forms.Panel();
            this.inf_Empresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infEmp_imgLogo)).BeginInit();
            this.inf_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infUser_fotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // inf_Empresa
            // 
            this.inf_Empresa.Controls.Add(this.infEmp_Descricao);
            this.inf_Empresa.Controls.Add(this.infEmp_nomeEmpresa);
            this.inf_Empresa.Controls.Add(this.infEmp_imgLogo);
            this.inf_Empresa.Dock = System.Windows.Forms.DockStyle.Left;
            this.inf_Empresa.Location = new System.Drawing.Point(0, 0);
            this.inf_Empresa.Name = "inf_Empresa";
            this.inf_Empresa.Size = new System.Drawing.Size(232, 64);
            this.inf_Empresa.TabIndex = 0;
            // 
            // infEmp_Descricao
            // 
            this.infEmp_Descricao.AutoSize = true;
            this.infEmp_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infEmp_Descricao.ForeColor = System.Drawing.Color.White;
            this.infEmp_Descricao.Location = new System.Drawing.Point(66, 34);
            this.infEmp_Descricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.infEmp_Descricao.Name = "infEmp_Descricao";
            this.infEmp_Descricao.Size = new System.Drawing.Size(124, 18);
            this.infEmp_Descricao.TabIndex = 2;
            this.infEmp_Descricao.Text = "suaempresa.com";
            // 
            // infEmp_nomeEmpresa
            // 
            this.infEmp_nomeEmpresa.AutoSize = true;
            this.infEmp_nomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infEmp_nomeEmpresa.ForeColor = System.Drawing.Color.White;
            this.infEmp_nomeEmpresa.Location = new System.Drawing.Point(65, 6);
            this.infEmp_nomeEmpresa.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.infEmp_nomeEmpresa.Name = "infEmp_nomeEmpresa";
            this.infEmp_nomeEmpresa.Size = new System.Drawing.Size(126, 24);
            this.infEmp_nomeEmpresa.TabIndex = 1;
            this.infEmp_nomeEmpresa.Text = "suaEmpresa";
            // 
            // infEmp_imgLogo
            // 
            this.infEmp_imgLogo.Image = global::BUI.Properties.Resources.Cube_Molecule_256;
            this.infEmp_imgLogo.Location = new System.Drawing.Point(12, 6);
            this.infEmp_imgLogo.Margin = new System.Windows.Forms.Padding(4);
            this.infEmp_imgLogo.Name = "infEmp_imgLogo";
            this.infEmp_imgLogo.Size = new System.Drawing.Size(48, 48);
            this.infEmp_imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infEmp_imgLogo.TabIndex = 0;
            this.infEmp_imgLogo.TabStop = false;
            // 
            // inf_User
            // 
            this.inf_User.Controls.Add(this.infUser_Descricao);
            this.inf_User.Controls.Add(this.infUser_Nome);
            this.inf_User.Controls.Add(this.infUser_fotoPerfil);
            this.inf_User.Dock = System.Windows.Forms.DockStyle.Right;
            this.inf_User.Location = new System.Drawing.Point(696, 0);
            this.inf_User.Name = "inf_User";
            this.inf_User.Size = new System.Drawing.Size(204, 64);
            this.inf_User.TabIndex = 1;
            // 
            // infUser_Descricao
            // 
            this.infUser_Descricao.AutoSize = true;
            this.infUser_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infUser_Descricao.ForeColor = System.Drawing.Color.White;
            this.infUser_Descricao.Location = new System.Drawing.Point(55, 34);
            this.infUser_Descricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.infUser_Descricao.Name = "infUser_Descricao";
            this.infUser_Descricao.Size = new System.Drawing.Size(98, 18);
            this.infUser_Descricao.TabIndex = 3;
            this.infUser_Descricao.Text = "administrador";
            // 
            // infUser_Nome
            // 
            this.infUser_Nome.AutoSize = true;
            this.infUser_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infUser_Nome.ForeColor = System.Drawing.Color.White;
            this.infUser_Nome.Location = new System.Drawing.Point(72, 6);
            this.infUser_Nome.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.infUser_Nome.Name = "infUser_Nome";
            this.infUser_Nome.Size = new System.Drawing.Size(81, 24);
            this.infUser_Nome.TabIndex = 3;
            this.infUser_Nome.Text = "Usuario";
            // 
            // infUser_fotoPerfil
            // 
            this.infUser_fotoPerfil.Image = global::BUI.Properties.Resources.Employee_256;
            this.infUser_fotoPerfil.Location = new System.Drawing.Point(156, 10);
            this.infUser_fotoPerfil.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.infUser_fotoPerfil.Name = "infUser_fotoPerfil";
            this.infUser_fotoPerfil.Size = new System.Drawing.Size(42, 42);
            this.infUser_fotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infUser_fotoPerfil.TabIndex = 3;
            this.infUser_fotoPerfil.TabStop = false;
            // 
            // uPainel
            // 
            this.uPainel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uPainel.Location = new System.Drawing.Point(232, 0);
            this.uPainel.Name = "uPainel";
            this.uPainel.Size = new System.Drawing.Size(464, 64);
            this.uPainel.TabIndex = 2;
            // 
            // uHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.uPainel);
            this.Controls.Add(this.inf_User);
            this.Controls.Add(this.inf_Empresa);
            this.Name = "uHeader";
            this.Size = new System.Drawing.Size(900, 64);
            this.inf_Empresa.ResumeLayout(false);
            this.inf_Empresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infEmp_imgLogo)).EndInit();
            this.inf_User.ResumeLayout(false);
            this.inf_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infUser_fotoPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel inf_Empresa;
        private System.Windows.Forms.Label infEmp_Descricao;
        private System.Windows.Forms.Label infEmp_nomeEmpresa;
        private System.Windows.Forms.PictureBox infEmp_imgLogo;
        private System.Windows.Forms.Panel inf_User;
        private System.Windows.Forms.Label infUser_Nome;
        private System.Windows.Forms.PictureBox infUser_fotoPerfil;
        private System.Windows.Forms.Label infUser_Descricao;
        private System.Windows.Forms.Panel uPainel;
    }
}
