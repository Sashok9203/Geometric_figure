using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figure
{
    internal interface IMovable : ILocated
    {
        public void Move(uint XMove, uint YMove)
        {
            X += XMove;
            Y += YMove;
        }
    }
}
