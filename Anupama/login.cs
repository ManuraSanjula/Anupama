using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Anupama
{
    public partial class login : Form
    {
        SqlConnection con;

        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void logins_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from UserTable where UserName = '" + textBox1.Text + "'", con);
                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    /*List<string> list = (from IDataRecord r in reader
                                         select (string)r["UserName Password Invalid"]
                    ).ToList();*/
                    if (reader.Read())
                    {
                        if (textBox2.Text == reader[2].ToString())
                        {
                            MessageBox.Show("login succerfully");
                            new Form1(textBox1.Text).Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("UserName Password Invalid");
                        }
                    }
                    else
                    {
                        MessageBox.Show("UserName Password Invalid");
                        this.Close();
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-2MIJHAB9;Initial Catalog=Anupama;Integrated Security=True");
        }
    }
}
