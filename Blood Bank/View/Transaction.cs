using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank.View
{
    public partial class Transaction : UserControl
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void transDtaView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void Transaction_Load(object sender, EventArgs e)
        {
            transDtaView.DataSource = Overall.Main.ReadData<string>("readTrans");
        }
    }
}
