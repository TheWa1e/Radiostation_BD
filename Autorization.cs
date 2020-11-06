using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiostation_BD
{
    public partial class  Autorization : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public Autorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usr = loginTextBox.Text;
            string psw = PasswordBox.Text;
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source= C:\Users\the_w\source\repos\Radiostation_BD\dbUsers.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            string str = "SELECT * FROM tblUser where user='" + loginTextBox.Text + "' AND pass='" + PasswordBox.Text + "'";
            cmd.CommandText = str;

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {

                if (usr == "editor")
                {
                    Main_menu1 ae = new Main_menu1();
                    ae.Owner = this;
                    ae.Show();
                    this.Hide();
                }
                else if (usr == "personnel _department")
                {
                    Main_menu2 ae = new Main_menu2();
                    ae.Owner = this;
                    ae.Show();
                    this.Hide();
                }
                else if (usr == "сommissioning_editor")
                {
                    /*Main_menu3 ae = new Main_menu3();
                    ae.Owner = this;
                    ae.Show();
                    this.Hide();*/
                }
                else if (usr == "admin")
                {
                    Main_menu af = new Main_menu();
                    af.Owner = this;
                    af.Show();
                    this.Hide();
                }
            }
            else
            {
              MessageBox.Show("Неправильный логин или пароль");
            }
        con.Close();
        }
    }
}
