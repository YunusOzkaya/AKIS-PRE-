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

namespace Akis3
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtSicilNo_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlDataAdapter sda= new SqlDataAdapter("SELECT FROM personel where ID='1'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtSicilNo.Text = dt.Rows[0][0].ToString();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
