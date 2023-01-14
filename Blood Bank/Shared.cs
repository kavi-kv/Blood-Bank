using Blood_Bank.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank
{
    public static class Shared
    {
        public static Dash  Dash { get; set; }
        public static Action fromBloodGroup { get; set;}
        public static Guna.UI2.WinForms.Guna2DataGridView viewDta { get; set; }
        public static Guna.UI2.WinForms.Guna2DataGridView BankDtaView { get; set; }
    }
}
