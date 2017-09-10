using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruzzle
{
    public class IDBox : IEquatable<IDBox>
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public IDBox(int r, int c)
        {
            Row = r;
            Column = c;
        }

        public bool Equals(IDBox other)
        {
            if (Row == other.Row && Column == other.Column)
                return true;
            else return false;
        }
    }
}
