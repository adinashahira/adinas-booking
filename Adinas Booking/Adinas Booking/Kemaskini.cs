using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Adinas_Booking
{
    public partial class Kemaskini : Form
    {
        static string constr = "Data Source=ADGWORKSTATION\\SQLEXPRESS;Initial Catalog=adinasbookingdata;Integrated Security=True";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();

        public Kemaskini()
        {
            InitializeComponent();
        }

        public string custNametoPass
        {
            set { txtCustName.Text = value; }
        }

        public string orFabric
        {
            set { txtOrFabric.Text = value; }
        }

        public string orDesign
        {
            set { txtOrDesign.Text = value; }
        }

        public string remarksToPass
        {
            set { txtRemarks.Text = value; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Urus main = new Urus();
            main.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(constr))
            {
                //con.Open();
                //var updateInfo = "UPDATE tblBooking$ set "
            }
        }
    }
}
