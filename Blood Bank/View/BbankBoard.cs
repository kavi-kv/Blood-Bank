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
            Shared.BankDtaView = bBankDtaView;
        }
       
        //public void getblood()
        //{
        //    var main = new Main();
        //    SqlConnection conn = main.GetSqlConnection();
        //    conn.Open();
        //    SqlCommand cm = new SqlCommand("dbo.readFromBbank", conn);
        //    SqlDataAdapter da = new SqlDataAdapter(cm);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    bBankDtaView.DataSource = dt;
        //    conn.Close();
        //}


        public void fromBloodGroup()
        {
            APos.Text = Overall.Main.ReadBloodGroups<string>("A+", "readFromEachBBank").ToString() + "ml";
            BPos.Text = Overall.Main.ReadBloodGroups<string>("B+", "readFromEachBBank").ToString() + "ml";
            ABPos.Text = Overall.Main.ReadBloodGroups<string>("AB+", "readFromEachBBank").ToString() + "ml";
            OPos.Text = Overall.Main.ReadBloodGroups<string>("O+", "readFromEachBBank").ToString() + "ml";
            ONeg.Text = Overall.Main.ReadBloodGroups<string>("O-", "readFromEachBBank").ToString() + "ml";
            ABNeg.Text = Overall.Main.ReadBloodGroups<string>("AB-", "readFromEachBBank").ToString() + "ml";
            BNeg.Text = Overall.Main.ReadBloodGroups<string>("B-", "readFromEachBBank").ToString() + "ml";
            ANeg.Text = Overall.Main.ReadBloodGroups<string>("A-", "readFromEachBBank").ToString() + "ml";
        }

        private void BbankBoard_Load(object sender, EventArgs e)
        {
            fromBloodGroup();
            if (!this.DesignMode)
                bBankDtaView.DataSource = Main.ReadData<string>("readFromBbank");
           

        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            AddToTrans add = new AddToTrans(bId,  quantity,  bloodGroup);
            add.Owner = this.FindForm();
            add.ShowDialog();
            Shared.BankDtaView.DataSource = Main.ReadData<string>("readFromBbank");
        }

        private void bBankDtaView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bId = (int)bBankDtaView.SelectedRows[0].Cells["bBankId"].Value;
            quantity = (double)bBankDtaView.SelectedRows[0].Cells["quantity"].Value;
            bloodGroup = bBankDtaView.SelectedRows[0].Cells["bloodGroup"].Value.ToString();
        }

    }
}
