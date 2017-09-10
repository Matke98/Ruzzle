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
        public List<IDBox> NearThis()
        {
            List<IDBox> list = new List<IDBox>();
            if (Column + 1 < 4) //A DESTRA
                list.Add(new IDBox(Row, Column + 1));
            if (Column - 1 >= 0) //A SINISTRA
                list.Add(new IDBox(Row, Column - 1));
            if (Row - 1 >= 0) //IN ALTO
                list.Add(new IDBox(Row - 1, Column));
            if (Row + 1 < 4) //IN BASSO
                list.Add(new IDBox(Row + 1, Column));
            if (Row + 1 < 4 && Column + 1 < 4) //IN BASSO A DESTRA
                list.Add(new IDBox(Row + 1, Column + 1));
            if (Row + 1 < 4 && Column - 1 >= 0) //IN BASSO A SINISTRA
                list.Add(new IDBox(Row + 1, Column - 1));
            if (Row - 1 >= 0 && Column + 1 < 4) //IN ALTO A DESTRA
                list.Add(new IDBox(Row - 1, Column + 1));
            if (Row - 1 >= 0 && Column - 1 >= 0) //IN ALTO A SINISTRA
                list.Add(new IDBox(Row - 1, Column - 1));
            return list;
        }
    }
}
