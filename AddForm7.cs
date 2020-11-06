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
    public partial class AddForm7 : Form
    {
        public AddForm7()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Genere six = this.Owner as Genere;
            if (six != null)
            {
                DataRow nRow = six.radiostationDataSet0.Tables[0].NewRow();
                int rc = six.dataGridView1.RowCount + 1;
                nRow[0] = tbgenere.Text;
                nRow[1] = tbname1.Text;
                nRow[2] = tbdescript.Text;
                six.radiostationDataSet0.Tables[0].Rows.Add(nRow);
                six.generesTableAdapter.Update(six.radiostationDataSet0.generes);
                six.radiostationDataSet0.Tables[0].AcceptChanges();
                six.dataGridView1.Refresh();
                tbgenere.Text = "";
                tbname1.Text = "";
                tbdescript.Text = "";
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
          this.Close();
        }
    }
}
