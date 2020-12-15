using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Systekna.Framework.Forms
{
    public partial class AdminForm : Form
    {
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
        {
            
            var title = $"Documento [{SectionViews.NDoc}]";
            SectionViews.Start(true, title);
        }

        private ConfigForm _configForm = new ConfigForm();
    }
}
