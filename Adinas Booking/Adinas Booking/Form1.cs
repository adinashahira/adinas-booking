using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Adinas_Booking
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
           
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Urus main = new Urus();
            main.Show();
            this.Hide();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            PelangganBaru main = new PelangganBaru();
            main.Show();
            this.Hide();
        }

        private void btnNewBook_Click(object sender, EventArgs e)
        {
            TempahanBaru main = new TempahanBaru();
            main.Show();
            this.Hide();
        }
    }
}
