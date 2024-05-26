using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pac_man_2part_
{
    public abstract class BaseEntity
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public BaseEntity(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
