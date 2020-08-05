using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class GUI : Form
    {
        public GUI()
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
