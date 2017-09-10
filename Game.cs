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

        public static string UserWord
        {
            get;
            set;
        }
        public static int TotalPoints
        {
            get;
            set;
        }
        public static int TempPoints
        {
            get;
            set;
        }
        public static List<string> EnteredWords
        {
            get;
            set;
        }

        public static bool NewGame()
        {
            EnteredWords = new List<string>();
            UserWord = "";
            TotalPoints = 0;
            TempPoints = 0;
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
                        list.Add(box);
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
        public static void ReEnable() //POLYMORPHISM!!!1!!!
        {
            foreach(var item in Table)
            {
                item.ClickAvailable = true;
            }
        } 
        public static void UnselectAll()
        {
            foreach (var item in Table)
            {
                item.Selected = false;
                item.Invalidate();
            }
        }
        public static bool AlreadyUsed(string word)
        {
            foreach (var item in EnteredWords)
            {
                if (item == word)
                    return true;
            }
            return false;
        }
    }
}
