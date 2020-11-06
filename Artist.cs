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
    public partial class Artist : Form
    {
        public Artist()
        {
            InitializeComponent();
        }

        private void Artist_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "radiostationDataSet0.artist". При необходимости она может быть перемещена или удалена.
            this.artistTableAdapter.Fill(this.radiostationDataSet0.artist);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Запись сохранена!", "Сохранение", MessageBoxButtons.OK);
            artistTableAdapter.Update(radiostationDataSet0.artist);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
           DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
           if (dr == DialogResult.Cancel)
           {
            e.Cancel = true;
           }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddForm6 af = new AddForm6();
            af.Owner = this;
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[1].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Edit
            MessageBox.Show("Изменения сохранены!", "Сохранение", MessageBoxButtons.OK);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    artistTableAdapter.Update(radiostationDataSet0.artist);
                }
                catch // (Exception ex)
                {
                    // MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }
    }
}
