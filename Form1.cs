using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Ruzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            while (Game.NewGame() == false)
            {
                Game.NewGame();
            }
            foreach (var item in Game.Table)
            {
                Controls.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = Game.UserWord.ToLower();
            
            if (ItalianWordList.Search(word) && !Game.AlreadyUsed(word))
            {
                label1.Text += word + "\n";
                Game.TotalPoints += Game.TempPoints;
                PointsLBL.Text = Game.TotalPoints.ToString();
                Game.UnselectAll();
                Game.UserWord = "";
                Game.TempPoints = 0;
                Game.ReEnable();
                Game.EnteredWords.Add(word);
            }
            else
            {
                Game.UnselectAll();
                Game.ReEnable();
                Game.UserWord = "";
                Game.TempPoints = 0;
            }
        }

    }
}
