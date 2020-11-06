using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiostation_BD
{
    public partial class AddForm6 : Form
    {
        public AddForm6()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Artist six = this.Owner as Artist;
            if (six != null)
            {
                DataRow nRow = six.radiostationDataSet0.Tables[0].NewRow();
                int rc = six.dataGridView1.RowCount + 1;
                nRow[0] = tbid.Text;
                nRow[1] = tbName.Text;
                nRow[2] = tbdescription.Text;
                six.radiostationDataSet0.Tables[0].Rows.Add(nRow);
                six.artistTableAdapter.Update(six.radiostationDataSet0.artist);
                six.radiostationDataSet0.Tables[0].AcceptChanges();
                six.dataGridView1.Refresh();
                tbid.Text = "";
                tbName.Text = "";
                tbdescription.Text = "";
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
