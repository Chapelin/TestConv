using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class EnfantRedefinit : Parent
    {
        public string Toto { get; set; }

        public EnfantRedefinit()
        {
            this.Toto = String.Empty;
        }
    }
}
