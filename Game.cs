using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ruzzle
{
    static class Game
    {
        static RuzzleBoxControl[,] _table = new RuzzleBoxControl[4,4]; //TABELLA DI GIOCO

        public static RuzzleBoxControl[,] Table { get { return _table;} set { _table = value; } }

        public static bool NewGame()
        {
            //COORDINATE DOVE VERRANNO DISEGNATI I CONTROLLI
            int x = 50;
            int y = 50;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Table[i,j] = new RuzzleBoxControl(i,j);
                    Table[i,j].Location = new Point(x * j, y * i);
                }
            }           
            int vowels = 0;
            foreach (var item in Table)
            {
                if (item.Letter == 'A' || item.Letter == 'E' || item.Letter == 'I' ||
                    item.Letter == 'O' || item.Letter == 'U')
                {
                    vowels++;
                }
            }
            if (vowels >= 8)
            {
                return true;
            }
            else return false;
        }

        public static List<RuzzleBoxControl> FromIDs(List<IDBox> IDs)
        {
            List<RuzzleBoxControl> list = new List<RuzzleBoxControl>();
            foreach (var item in IDs)
            {
                foreach (var box in Table) 
                {
                    //if (box.ID == item) //PROBABILMENTE EQUALS DI IDBOX NON FUNZIONANTE
                    //{
                    //    ReEnable(Table[item.Row, item.Column]);
                    //}
                    if (box.ID.Column == item.Column && box.ID.Row == item.Row)
                    {
                        ReEnable(Table[item.Row, item.Column]);
                    }
                }


            }
            return list;
        }
        public static void ReEnable(RuzzleBoxControl box) 
        {
            box.ClickAvailable = true;
        }
    }
}
