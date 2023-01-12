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
        public static Guna.UI2.WinForms.Guna2DataGridView transView { get; set; } = new Guna.UI2.WinForms.Guna2DataGridView();
        public Transaction()
        {
            InitializeComponent();
            transView = transDtaView;
        }

        private void transDtaView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //  //  e.Graphics.DrawLine(Pens.Red, 0, 0, this.Width - 5, this.Height - 5);
        //    //e.Graphics.DrawString("Waa lagu boodaa", this.Font,Brushes.Black, new Point(0, 0));
        //    base.OnPaint(e);
        //}
        private void Transaction_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
                transDtaView.DataSource = Overall.Main.ReadData<string>("readTrans");
        }

        private void disMonthComBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItems = disMonthComBx.SelectedItem.ToString();
            transDtaView.DataSource = Overall.Main.getDataByMonth(selectedItems, "readTrByMonth");
        }
    }
}
