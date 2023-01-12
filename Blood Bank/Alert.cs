using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank
{
    public partial class Alert : Form
    {
        public Alert()
        {
            InitializeComponent();
        }
        public bool? IsYes { get; set; } = null;
        public Alert(string msg, string title,string yesbtn = "Yes", string nobtn = "No")
        {
            InitializeComponent();
            saaLabel1.Text = title;
            saaLabel2.Text = msg;
            saaButton1.Value = yesbtn;
            saaButton2.Value = nobtn;
        }
        private void Alert_Load(object sender, EventArgs e)
        {
            saaFormControlBox2.Invalidate(true);
        }

        private void saaButton1_Click(object sender, EventArgs e)
        {
            IsYes = true;
            Close();
        }

        private void saaButton2_Click(object sender, EventArgs e)
        {

            IsYes = false;
            Close();
        }
    }
}
