using DevExpress.XtraEditors;
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


namespace StokTakipProjesi
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        

        public XtraForm1()
        {
            InitializeComponent();
        }
        static string conString = "server=.;database=StokProjesi;trusted_connection=true;";
        SqlConnection baglanti = new SqlConnection(conString);
        private void XtraForm1_Load(object sender, EventArgs e)
        {
            

            

        }

        private void pictureEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string kayit = "Select * from Logins where Username=@P1  AND Password=@P2";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@P1", textEdit1.Text);
                komut.Parameters.AddWithValue("@P2", textEdit2.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Anasayfa anaSayfa = new Anasayfa();
                    anaSayfa.labelControl2.Text = textEdit1.Text;
                    MessageBox.Show("Sisteme Giriş Yapıldı.");
                    this.Hide();
                    anaSayfa.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Şifre Yanlış");
                }                
                baglanti.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
    }
}