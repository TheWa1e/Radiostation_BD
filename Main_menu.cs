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
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Position af = new Position();
            af.Owner = this;
            af.Show();
        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            Customers af = new Customers();
            af.Owner = this;
            af.Show();
        }*/

        private void button3_Click(object sender, EventArgs e)
        {
            Employees af = new Employees();
            af.Owner = this;
            af.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Records af = new Records();
            af.Owner = this;
            af.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Workinglist af = new Workinglist();
            af.Owner = this;
            af.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Artist af = new Artist();
            af.Owner = this;
            af.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Genere af = new Genere();
            af.Owner = this;
            af.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Records_list af = new Records_list();
            af.Owner = this;
            af.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Запросы
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Фильтры
        }
    }
}
