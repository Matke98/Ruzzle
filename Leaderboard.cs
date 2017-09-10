using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ruzzle
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
            GetScores();
        }
        private void GetScores()
        {
            string line;
            string[] player = new string[2];
            StreamReader file = new StreamReader("scores.dat");
            line = file.ReadLine();
            player = line.Split(',');
            nome1.Text = player[0];
            Punteggio1.Text = player[1];

            line = file.ReadLine();
            player = line.Split(',');
            nome2.Text = player[0];
            Punteggio2.Text = player[1];

            line = file.ReadLine();
            player = line.Split(',');
            nome3.Text = player[0];
            Punteggio3.Text = player[1];

            line = file.ReadLine();
            player = line.Split(',');
            nome4.Text = player[0];
            Punteggio4.Text = player[1];

            line = file.ReadLine();
            player = line.Split(',');
            nome5.Text = player[0];
            Punteggio5.Text = player[1];
        }
    }
}
