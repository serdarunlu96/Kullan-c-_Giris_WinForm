namespace Kullanıcı_Giris_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSifre.PasswordChar = '*'; // Sıfre Gızleme
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            if (txtKullaniciAdi.Text.ToLower() == "admin" && txtSifre.Text == "123")
                MessageBox.Show("Giris Basarili!");
            else
                MessageBox.Show("Giris Basarisiz!");
        }
    }
}