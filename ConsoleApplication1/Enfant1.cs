using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class EnfantSimple : Parent, IMonInterface
    {
        public string Test { get; set; }
    }
}
