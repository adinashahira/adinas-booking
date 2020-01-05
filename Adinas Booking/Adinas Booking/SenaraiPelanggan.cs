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
    public partial class SenaraiPelanggan : Form
    {
        public SenaraiPelanggan()
        {
            InitializeComponent();
        }

        private void SenaraiPelanggan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adinasbookingdataDataSet1.custInfo' table. You can move, or remove it, as needed.
            this.custInfoTableAdapter.Fill(this.adinasbookingdataDataSet1.custInfo);

        }
    }
}
