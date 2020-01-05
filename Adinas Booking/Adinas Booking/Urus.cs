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
        private int index;

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

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            Kemaskini main = new Kemaskini();
            main.custNametoPass = _custNametoPass; //pass name
            main.orFabric = _orFabrictoPass; //pass fabric details
            main.orDesign = _orDesigntoPass; //pass design
            main.remarksToPass = _orRemarkstoPass; //pass remarks
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

        public string _custNametoPass
        {
            get { return txtCustName.Text.Trim(); }
        }

        public string _orFabrictoPass
        {
            get { return dataGridView1.Rows[index].Cells[2].Value.ToString(); }
        }

        public string _orDesigntoPass
        {
            get { return dataGridView1.Rows[index].Cells[3].Value.ToString(); }
        }

        public string _orRemarkstoPass
        {
            get { return dataGridView1.Rows[index].Cells[13].Value.ToString(); }
        }

        //public int _id
        //{
        //    get { return dataGridView1.Rows.Count; }
        //}

        private void daftarPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PelangganBaru main = new PelangganBaru();
            //main.getId = _id;
            main.Show();
            this.Hide();
        }
    }
}
