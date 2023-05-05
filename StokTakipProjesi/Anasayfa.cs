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

namespace StokTakipProjesi
{
    public partial class Anasayfa : DevExpress.XtraEditors.XtraForm
    {
        public Anasayfa()
        {
            
            InitializeComponent();
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
            groupControl1.Enabled = true;
            groupControl2.Enabled = false;
            groupControl3.Enabled = false;
            groupControl4.Enabled = false;

        }

        private void tabNavigationPage1_Click(object sender, EventArgs e)
        {
            groupControl1.Enabled = true;
            groupControl2.Enabled = false;
            groupControl3.Enabled = false;
            groupControl4.Enabled = false;

        }

        private void tabNavigationPage2_Click(object sender, EventArgs e)
        {
            groupControl1.Enabled = false;
            groupControl2.Enabled = true;
            groupControl3.Enabled = false;
            groupControl4.Enabled = false;
        }

        private void tabNavigationPage3_Click(object sender, EventArgs e)
        {
            groupControl1.Enabled = false;
            groupControl2.Enabled = false;
            groupControl3.Enabled = true;
            groupControl4.Enabled = false;
        }

        private void tabNavigationPage4_Click(object sender, EventArgs e)
        {
            groupControl1.Enabled = false;
            groupControl2.Enabled = false;
            groupControl3.Enabled = false;
            groupControl4.Enabled = true;
        }
    }
}