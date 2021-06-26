using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Systekna.Framework.WFControl.Views
{
    public partial class SectionViews : UserControl
    {
        List<Documento> documents = new List<Documento>();

        public int NDoc { get; set; }

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

            documents.Clear();
            NDoc = 0;
        }

        public void Start(bool visible, string title)
        {
            Area.Visible = visible;
            toolbarTitle.Visible = visible;
            toolbarTitle.Width = 180;
            TitleDocument.Text = title;

            documents.Add(new Documento { Id = NDoc });
            NDoc = documents.Count;
        }

        public void Start(bool visible, string title, DataTable dataTable)
        {
            Area.Visible = visible;
            toolbarTitle.Visible = visible;
            toolbarTitle.Width = 180;
            TitleDocument.Text = title;

            documents.Add(new Documento { Id = NDoc });
            NDoc = documents.Count;
            dgv.DataSource = dataTable;
        }
    }
}
