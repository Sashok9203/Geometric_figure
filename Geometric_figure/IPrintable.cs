using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figure
{
    internal interface IPrintable : IСolored , ILocated
    {
        public char PrintSymbol { get; set; }
        public void Print();
    }
}
