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

        private void btnMenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (fLateral.Width == 42)
                fLateral.Width = 164;
            else
                fLateral.Width = 42;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            sectionViews.Start(true, "Documents [0]");
        }
    }
}
