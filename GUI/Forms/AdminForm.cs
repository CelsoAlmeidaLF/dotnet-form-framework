using System;
using System.Windows.Forms;

namespace Systekna.Framework.Forms
{
    public partial class AdminForm : Form
    {
        int idDoc = 0;

        public AdminForm()
        {
            InitializeComponent();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(Menu.Width == 42)
                Menu.Width = 164;
            else
                Menu.Width = 42;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        { 
            _configForm.ShowDialog();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {   idDoc ++;
            string title = $"Novo Documento [{idDoc}]";
            SectionViews.Start(true, title);
        }

        private ConfigForm _configForm = new ConfigForm();
    }
}
