using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adinas_Booking
{
    public partial class TempahanBaru : Form
    {
        public TempahanBaru()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mukaDepanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home main = new Home();
            main.Show();
            this.Hide();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
}
