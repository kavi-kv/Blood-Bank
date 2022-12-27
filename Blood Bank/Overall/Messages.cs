using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank.Overall
{
    public class Messages
    {
        public static void ShowMessage(string message, string title = "Message", string type = "info")
        {
            if (type == "info")
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (type == "error")
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (type == "warning")
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
