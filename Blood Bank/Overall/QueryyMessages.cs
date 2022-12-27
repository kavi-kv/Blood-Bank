using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Overall
{
    public interface QueryyMessages
    {
        bool QueryHasError { get; set; }
        string ErrorMessage { get; set; }
    }
}
