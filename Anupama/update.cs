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
using System.Diagnostics;

namespace Anupama
{
    public partial class update : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public update()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String userName = username.Text;
            String first_name = textBox1.Text;
            String last_name = textBox2.Text;
            String tel = textBox3.Text;
            String add = textBox4.Text;
            String nic = textBox5.Text;
            String email = textBox6.Text;

            try
            {
                con.Open();

                cmd = new SqlCommand("UPDATE UserTable set FirstName = '" + username + "',LastName = '" + last_name + "', Telephone='" + tel + "', Address = '" + add + "', Nic ='" + nic + "', Email ='" + email + "' where UserName = '" + userName + "' ", con);

                int __ = cmd.ExecuteNonQuery();
                con.Close();
                if (__ == 1)
                    MessageBox.Show("Data Updated Sucessfully");
                else
                    MessageBox.Show("Data Not Updated Sucessfully");
            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-2MIJHAB9;Initial Catalog=Anupama;Integrated Security=True");

        }
    }
}
