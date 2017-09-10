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
using System.IO;

namespace Ruzzle
{
    public partial class Menu : Form
    {
        Timer timer = new Timer();
        static int time;
        public Menu()
        {
            timer.Tick += Timer_Tick;
            Logo = new PictureBox();
            Logo.Image = Image.FromFile("media/Ruzzle_logo.png");
            InitializeComponent();
            BackToMenuBTN.Hide();
            PointsLBL.Hide();
            Points2LBL.Hide();
            ConfirmBTN.Hide();
            TimeLBL.Hide();
            InsertName.Hide();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (Game.NewGame() == false)
            {
                Game.NewGame();
            }
            LoadGame();
            foreach (var item in Game.Table)
            {
                Controls.Add(item);
            }
           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time--;
            TimeLBL.Text = time.ToString();
            if (time > 15)
            {
                SoundPlayer tick = new SoundPlayer("media/tick.wav");
                tick.Play();
            }

            if (time <= 15 && time > 5)
            {
                SoundPlayer tick = new SoundPlayer("media/tickx2.wav");
                tick.Play();
            }
            else if (time <= 5 && time != 0)
            {
                SoundPlayer tick = new SoundPlayer("media/tickx4.wav");
                tick.Play();
            }
            if (time == 0)
            {
                timer.Stop();
                LoadForm();
                EndGame();
            }

        }

        private void BackToMenuBTN_Click(object sender, EventArgs e)
        {
            LoadMenu();
        }
        private void LoadMenu()
        {
            timer.Stop();
            LeaderBoardBTN.Show();
            TenMovesBTN.Show();
            TimeAttackBTN.Show();
            Logo.Show();
            BackToMenuBTN.Hide();
            PointsLBL.Hide();
            Points2LBL.Hide();
            ConfirmBTN.Hide();
            TimeLBL.Hide();
            WordListLBL.Text = "";
            WordListLBL.Hide();
            InfoLBL.Hide();
            Game.Hide();
            InsertName.Hide();
            InsertNameBTN.Hide();
        }
        private void LoadGame()
        {
            Game.Show();
            LeaderBoardBTN.Hide();
            TenMovesBTN.Hide();
            TimeAttackBTN.Hide();
            Logo.Hide();
            BackToMenuBTN.Show();
            PointsLBL.Show();
            Points2LBL.Show();
            ConfirmBTN.Show();
            TimeLBL.Show();
            time = 5;
            TimeLBL.Text = time.ToString();
            timer.Interval = 1000; // specify interval time as you want
            timer.Start();
            WordListLBL.Show();
            InfoLBL.Hide();
            InsertName.Hide();
            InsertNameBTN.Hide();
        }
        private void LoadForm()
        {
            Game.Hide();
            LeaderBoardBTN.Hide();
            TenMovesBTN.Hide();
            TimeAttackBTN.Hide();
            Logo.Show();
            PointsLBL.Hide();
            Points2LBL.Hide();
            ConfirmBTN.Hide();
            TimeLBL.Hide();
            WordListLBL.Hide();
            InfoLBL.Show();
            InsertName.Hide();
            InsertNameBTN.Hide();
        }
        private void EndGame()
        {
            if (true)
            {
                InfoLBL.Text = "Hai totalizzato " + Game.TotalPoints + " punti! \n Sei anche entrato nella top 5! come ti chiami?";
                InsertName.Show();
                InsertNameBTN.Show();
            }
            else
            {
                InfoLBL.Text = "Hai totalizzato " + Game.TotalPoints + " punti! \n tuttavia non sei entrato nella top 5";
            }

        }
        private void ConfirmBTN_Click(object sender, EventArgs e)
        {
            string word = Game.UserWord.ToLower();

            if (ItalianWordList.Search(word) && !Game.AlreadyUsed(word) && word.Length >= 2)
            {
                int bonuspoints = Game.BonusPoints(word);
                if (bonuspoints > 0)
                    WordListLBL.Text += word + " " + Game.TempPoints + "+" + bonuspoints + "\n";
                else
                    WordListLBL.Text += word + " " + Game.TempPoints;
                Game.TotalPoints += Game.TempPoints + bonuspoints;
                Points2LBL.Text = Game.TotalPoints.ToString();
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

        private void InsertNameBTN_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("scores.dat", FileMode.Open);
            BinaryWriter bw = new BinaryWriter(fs);
            string text = InsertName.Text +"," + Game.TotalPoints.ToString();
            ASCIIEncoding asc = new ASCIIEncoding();
            InfoLBL.Text = text;
            byte[] str = asc.GetBytes(text);
            bw.Write(str);
            bw.Close();
        }

        private void LeaderBoardBTN_Click(object sender, EventArgs e)
        {
            Leaderboard leaderboard = new Leaderboard();
            leaderboard.Show();
        }
    }
}
