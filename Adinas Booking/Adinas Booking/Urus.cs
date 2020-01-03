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
    public partial class Urus : Form
    {
        static string constr = "Data Source=ADGWORKSTATION\\SQLEXPRESS;Initial Catalog=adinasbookingdata;Integrated Security=True";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        string filterCategory;

        public Urus()
        {
            InitializeComponent();
        }

        private void Urus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adinasbookingdataDataSet._tblBooking_' table. You can move, or remove it, as needed.
            this.tblBooking_TableAdapter.Fill(this.adinasbookingdataDataSet._tblBooking_);
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 15;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Kemaskini main = new Kemaskini();
            
            main.Show();
            this.Hide();
        }

        public void btnSearch_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(constr))
            {
                con.Open();
                string statement = "Select * from tblBooking$ ";
                string control = "WHERE ";

                if (txtCustName.Text != null)
                {
                    statement += control;
                    statement += "custName = '" + txtCustName.Text.Trim() + "' ";
                    control = "AND ";
                }

                if (cboxTailor.SelectedItem != null)
                {
                    statement += control;
                    statement += "orderTailor = '" + cboxTailor.SelectedItem + "' ";
                    control = "AND ";
                }

                if (rbtnDone.Checked)
                {
                    statement += control;
                    statement += "orStatus = 'Y'";
                }

                else if (rbtnNotDone.Checked)
                {
                    rbtnDone.Checked = false;
                    statement += control;
                    statement += "orStatus = 'N'";
                }

                if (rbtnPaid.Checked)
                {
                    statement += control;
                    statement += "orPayStatus = 'Y'";
                }

                else if (rbtnNotPaid.Checked)
                {
                    statement += control;
                    statement += "orPayStatus = 'N'";
                }

                SqlDataAdapter adapt = new SqlDataAdapter(statement, con);
                DataSet dataset = new DataSet();
                adapt.Fill(dataset, "result");
                dataGridView1.DataSource = dataset.Tables["result"];
            }
        }

        private void rbtnDone_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
