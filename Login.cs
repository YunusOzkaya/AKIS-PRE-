namespace Akis3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuserName.Text=="Yunus Özkaya"&&txtpassword.Text=="190551")
            {
                new Anasayfa().Show();
                this.Hide();
            }
            else if(txtuserName.Text!="Yunus Özkaya"&&txtpassword.Text=="190551")
            {
                MessageBox.Show("Kullanýcý adýnýzý hatalý girdiniz.");
            }
            else if (txtuserName.Text=="Yunus Özkaya"&&txtpassword.Text!="190551")
            {
                MessageBox.Show("Parolanýzý hatalý girdiniz.");
            }
            else
            {
                MessageBox.Show("Kullanýcý adýnýzý ve parolanýzý hatalý girdiniz.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}