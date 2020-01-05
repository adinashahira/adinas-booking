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
    public partial class PelangganBaru : Form
    {
        static string constr = "Data Source=ADGWORKSTATION\\SQLEXPRESS;Initial Catalog=adinasbookingdata;Integrated Security=True";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        int newId = 0;

        public PelangganBaru()
        {
            InitializeComponent();
        }

        private void mukaDepanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home main = new Home();
            main.Show();
            this.Hide();
        }

        //public int getId
        //{
        //    set { newId = value; }
        //}

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(constr))
            {
                con.Open();

                var register = "INSERT INTO custInfo ([custName], [custContact], [custShoulder], [custChest], ";
                register += "[custWaist], [custHip], [custTopLength], [custTopLengthShort], [custBottomLength], ";
                register += "[custSleeveLength], [custShoulderDown], [custArmCirc], [custPtP], [custSleeveOpen], ";
                register += "[custFullDress], [custPT], [custSleeveLength2])";
                register += "VALUES (@custName, @custContact, @custShoulder, @custChest, @custWaist, @custHip, ";
                register += "@custTopLength, @custTopLengthShort, @custBottomLength, @custSleeveLength, ";
                register += "@custShoulderDown, @custArmCirc, @custPtP, @custSleeveOpen, @custFullDress, ";
                register += "@custPT, @custSleeveLength2)";
                var registerCmd = new SqlCommand(register, con);

                registerCmd.Parameters.AddWithValue("@custName", txtCustName.Text.Trim());
                registerCmd.Parameters.AddWithValue("@custContact", txtPhoneNum.Text.Trim());

                registerCmd.Parameters.AddWithValue("@custShoulder", txtShoulder.Text.Length > 0 ? Convert.ToInt16(txtShoulder.Text) : (object)DBNull.Value);
                registerCmd.Parameters.AddWithValue("@custChest", txtChest.Text.Length > 0 ? Convert.ToInt16(txtChest.Text) : (object)DBNull.Value);
                registerCmd.Parameters.AddWithValue("@custWaist", txtWaist.Text.Length > 0 ? Convert.ToInt16(txtWaist.Text) : (object)DBNull.Value);
                registerCmd.Parameters.AddWithValue("@custHip", txtHips.Text.Length > 0 ? Convert.ToInt16(txtHips.Text) : (object)DBNull.Value);
                registerCmd.Parameters.AddWithValue("@custTopLength", txtTopLength.Text.Length > 0 ? Convert.ToInt16(txtTopLength.Text) : (object)DBNull.Value);
                registerCmd.Parameters.AddWithValue("@custTopLengthShort", txtTopLengthShort.Text.Length > 0 ? Convert.ToInt16(txtTopLengthShort.Text) : (object)DBNull.Value);
                registerCmd.Parameters.AddWithValue("@custBottomLength", txtBottomLength.Text.Length > 0 ? Convert.ToInt16(txtBottomLength.Text) : (object)DBNull.Value);
                registerCmd.Parameters.AddWithValue("@custSleeveLength", txtSleeve.Text.Length > 0 ? Convert.ToInt16(txtSleeve.Text) : (object)DBNull.Value);
                registerCmd.Parameters.AddWithValue("@custShoulderDown", txtShoulderDown.Text.Length > 0 ? Convert.ToInt16(txtShoulderDown.Text) : (object)DBNull.Value);
                registerCmd.Parameters.AddWithValue("@custArmCirc", txtArmCirc.Text.Length > 0 ? Convert.ToInt16(txtArmCirc.Text) : (object)DBNull.Value);
                registerCmd.Parameters.AddWithValue("@custPtP", txtPtP.Text.Length > 0 ? Convert.ToInt16(txtPtP.Text) : (object)DBNull.Value);
                registerCmd.Parameters.AddWithValue("@custSleeveOpen", txtSleeveOpen.Text.Length > 0 ? Convert.ToInt16(txtSleeveOpen.Text) : (object)DBNull.Value);
                registerCmd.Parameters.AddWithValue("@custFullDress", txtFull.Text.Length > 0 ? Convert.ToInt16(txtFull.Text) : (object)DBNull.Value);
                registerCmd.Parameters.AddWithValue("@custPT", txtPT.Text.Length > 0 ? Convert.ToInt16(txtPT.Text) : (object)DBNull.Value);
                registerCmd.Parameters.AddWithValue("@custSleeveLength2", txtSleeve2.Text.Length > 0 ? Convert.ToInt16(txtSleeve2.Text) : (object)DBNull.Value);

                registerCmd.ExecuteNonQuery();

                DialogResult ok = MessageBox.Show(this, "Anda akan kembali ke paparan Urus", "Ciptaan Berjaya!", MessageBoxButtons.OK);
                if (ok == DialogResult.OK)
                {
                    SenaraiPelanggan main = new SenaraiPelanggan();
                    main.Show();
                    this.Hide();
                }
            }
        }
    }
}
