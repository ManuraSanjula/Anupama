using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Anupama
{
    public partial class Regisation : Form
    {
        SqlConnection con;

        public Regisation()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Regisation_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-2MIJHAB9;Initial Catalog=Anupama;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userName = username.Text;
            String userPassword = password.Text;
            String first_namr = textBox1.Text;
            String last_name = textBox2.Text;
            String tel = textBox3.Text;
            String add = textBox4.Text;
            String nic = textBox5.Text;
            String email = textBox6.Text;

            try
            {
                SqlCommand cmd = new SqlCommand("insert into UserTable values('" + userName + "', '" + userPassword + "', '" + first_namr + "', '" + last_name + "' ,'" + tel + "', '" + add + "', '" + nic + "', '" + email + "')", con);

                if (first_namr != "" & last_name != "" & tel != "" & add !=""  & nic != "" & email != "")
                {
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    con.Close();

                    if (i != 0)
                    {
                        MessageBox.Show("Data Saved");
                    }

                }
                else
                {
                    MessageBox.Show("Missing Required Fields ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Not Saved To the Database ||" + ex.Message);
            }
        }
    }
}
