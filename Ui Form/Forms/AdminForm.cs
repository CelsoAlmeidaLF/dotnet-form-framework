using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Systekna.Framework.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnMenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (fLateral.Width == 42)
                fLateral.Width = 164;
            else
                fLateral.Width = 42;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Users");
            DataRow dr;
            {
                dt.Columns.Add("Name");
                dt.Columns.Add("Celular");
                dt.Columns.Add("Email");

                dr = dt.NewRow();
                dr["Name"] = "Celso de Almeida Leite Filho";
                dr["Celular"] = "11 997870299";
                dr["Email"] = "celso.almeida.leite@hotmail.com";
                dt.Rows.Add(dr);
            }
            sectionViews.Start(true, "Documents [0]", dt);
        }
    }
}
