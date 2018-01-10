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

namespace Createlogin
{
    public partial class Register : MaterialSkin.Controls.MaterialForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-R7V17QH\\PAAVAISQLEXPRESS; Database=logininfo; Integrated Security=SSPI");
            try
            {
                conn.Open();
                MessageBox.Show("Connection Open ! ");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
            String newcom = "insert into login(Name,Username,Password,Email) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";

            SqlCommand cmd = new SqlCommand(newcom, conn);

            cmd.ExecuteNonQuery();

            label5.Text = "Registered";
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 r = new Form1();
            r.Show();
            this.Hide();
        }
    }
}
