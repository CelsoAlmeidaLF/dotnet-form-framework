using System;
using System.Windows.Forms;

namespace Systekna.Framework.WFControl.Views
{
    public partial class SectionViews : UserControl
    {
        int doc = 0;
        public SectionViews()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            bool visible = false;

            Area.Visible = visible;
            toolbarTitle.Visible = visible;
            toolbarTitle.Width = 100;
        }

        public void Start(bool visible, string title)
        {
            doc++;
            Area.Visible = visible;
            toolbarTitle.Visible = visible;
            toolbarTitle.Width = 180;
            TitleDocument.Text = title;
        }
    }
}
