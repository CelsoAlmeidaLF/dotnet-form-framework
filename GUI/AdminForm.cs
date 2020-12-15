using System;
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
            if(UMenu.Width == 42)
            {
                UMenu.Width = 164;
            }
            else
            {
                UMenu.Width = 42;
            }
        }
    }
}
