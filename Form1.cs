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
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public static string settext = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();

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

            String newcom = "select Username from login where Username = '" + textBox1.Text + "' and Password= '" + textBox2.Text + "'";

            SqlDataAdapter adp = new SqlDataAdapter(newcom, conn);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count >= 1)
            {
                settext = textBox1.Text;
                welcome wc = new welcome();
                wc.Show();
                this.Hide(); 
            }

            else
            {
                label3.Text = "Invalid login";
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
