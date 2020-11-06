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
    public partial class AddForm1 : Form
    {
        public AddForm1()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Position main = this.Owner as Position;
            if (main != null)
            {
                DataRow Row = main.radiostationDataSet0.Tables[0].NewRow();
                int n = main.dataGridView1.RowCount + 1;
                Row[0] = idposition.Text;
                Row[1] = nameposition.Text;
                Row[2] = salary.Text;
                Row[3] = duties.Text;
                Row[4] = demands.Text;
                main.radiostationDataSet0.Tables[0].Rows.Add(Row);
                main.positionsTableAdapter.Update(main.radiostationDataSet0.positions);
                main.radiostationDataSet0.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                idposition.Text = "";
                nameposition.Text = "";
                salary.Text = "";
                duties.Text = "";
                demands.Text = "";
            }
            else
            {
                MessageBox.Show("заполните все поля.", "Ошибка.");
            }

        }


        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
