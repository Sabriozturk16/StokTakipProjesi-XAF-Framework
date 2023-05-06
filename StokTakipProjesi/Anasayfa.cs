using DevExpress.XtraEditors;
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

namespace StokTakipProjesi
{
    public partial class Anasayfa : DevExpress.XtraEditors.XtraForm
    {
        public Anasayfa()
        {
            
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ONUR;Initial Catalog=Mutakabat;Integrated Security=True");
        public void Stok_Kart()
        {
            if (textEdit1.Text != "" && textEdit2.Text != "")
            {
                baglanti.Open();
                string kayit = "insert into  (kullaniciad,firmaad,yetkili,il,ilce,vergidaire,vergino,mutabakatmail,telefon,adres,borc) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)";
                SqlCommand ekle = new SqlCommand(kayit, baglanti);
                ekle.Parameters.AddWithValue("@p1", textEdit1.Text);
                ekle.Parameters.AddWithValue("@p2", textEdit2.Text);
                ekle.ExecuteNonQuery();
                baglanti.Close();
                labelControl17.Visible = true;
                labelControl17.ForeColor = Color.Green;
                labelControl17.Text = "Stok Kart Başarıyla Kaydedildi";
            }
            else
            {
                labelControl17.Visible = true;
                labelControl17.ForeColor = Color.Red;
                labelControl17.Text = "'Stok Kodu' ve Stok Adı Boş Bırakılamaz";
            }
        }
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokProjesiDataSet3.stokHarekets' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.stokHareketsTableAdapter.Fill(this.stokProjesiDataSet3.stokHarekets);
            // TODO: Bu kod satırı 'stokProjesiDataSet2.StokTedarikcisi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.stokTedarikcisiTableAdapter.Fill(this.stokProjesiDataSet2.StokTedarikcisi);
            // TODO: Bu kod satırı 'stokProjesiDataSet1.Birims' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.birimsTableAdapter.Fill(this.stokProjesiDataSet1.Birims);
            // TODO: Bu kod satırı 'stokProjesiDataSet.stokKarts' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.stokKartsTableAdapter.Fill(this.stokProjesiDataSet.stokKarts);
            timer1.Start();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelControl4.Text = DateTime.Now.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            XtraForm1 xtraForm1 = new XtraForm1();
            this.Close();
            xtraForm1.Show();
        }

        private void tabPane1_Click(object sender, EventArgs e)
        {
           

        }

        private void tabNavigationPage1_Click(object sender, EventArgs e)
        {
            

        }

        private void tabNavigationPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabNavigationPage3_Click(object sender, EventArgs e)
        {
           
        }

        private void tabNavigationPage4_Click(object sender, EventArgs e)
        {
           
        }

        private void tabNavigationPage1_MouseClick(object sender, MouseEventArgs e)
        {
            

        }

        private void tabNavigationPage1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Stok_Kart();
        }
    }
}