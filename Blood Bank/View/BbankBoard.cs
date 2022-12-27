using Blood_Bank.Overall;
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

namespace Blood_Bank.View
{
    public partial class BbankBoard : UserControl
    {
        public int bId { get; set; }
        public double quantity { get; set; }
        public string bloodGroup { get; set; }
        public BbankBoard()
        {
            InitializeComponent();
        }
       
        private void getblood()
        {
            var main = new Main();
            SqlConnection conn = main.GetSqlConnection();
            conn.Open();
            SqlCommand cm = new SqlCommand("dbo.readFromBbank", conn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bBankDtaView.DataSource = dt;
            conn.Close();
        }


        public void fromBloodGroup()
        {
            //APos.Text = Overall.Main.ReadBloodGroups<string>("A+", "readFromEachBBank").ToString() + "ml";
        }

        private void BbankBoard_Load(object sender, EventArgs e)
        {
            fromBloodGroup();
            //bBankDtaView.DataSource = Main.ReadData<string>("EXEC readFromBbank");
            getblood();
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Id: {bId}\nQuantity {quantity}\nBlood Gorup {bloodGroup}");
            AddToTrans add = new AddToTrans(bId,  quantity,  bloodGroup);
            add.ShowDialog();
        }

        private void bBankDtaView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bId = (int)bBankDtaView.SelectedRows[0].Cells["bBankId"].Value;
            quantity = (double)bBankDtaView.SelectedRows[0].Cells["quantity"].Value;
            bloodGroup = bBankDtaView.SelectedRows[0].Cells["bloodGroup"].Value.ToString();
        }
    }
}
