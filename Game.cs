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
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (Table[i, j].ID == item)
                        {
                            list.Add(Table[i, j]);
                        }
                    }

                }
            }
            return list;
        }
        public static void ReEnable(List<RuzzleBoxControl> list)
        {
            foreach(var item in list)
            {
                item.ClickAvailable = true;
            }
        }
    }
}
