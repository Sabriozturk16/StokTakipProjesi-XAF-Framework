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
    public partial class DirectXForm1 : DevExpress.XtraEditors.DirectXForm
    {
        public DirectXForm1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            WaitForm1 waitForm1 = new WaitForm1();
            this.Hide();
            waitForm1.Show();
            
        }
    }
}