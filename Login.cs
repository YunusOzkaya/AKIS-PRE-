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
            if (txtuserName.Text=="Yunus �zkaya"&&txtpassword.Text=="190551")
            {
                new Anasayfa().Show();
                this.Hide();
            }
            else if(txtuserName.Text!="Yunus �zkaya"&&txtpassword.Text=="190551")
            {
                MessageBox.Show("Kullan�c� ad�n�z� hatal� girdiniz.");
            }
            else if (txtuserName.Text=="Yunus �zkaya"&&txtpassword.Text!="190551")
            {
                MessageBox.Show("Parolan�z� hatal� girdiniz.");
            }
            else
            {
                MessageBox.Show("Kullan�c� ad�n�z� ve parolan�z� hatal� girdiniz.");
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