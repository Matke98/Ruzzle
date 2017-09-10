using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Ruzzle
{
    public partial class RuzzleBoxControl : UserControl
    {
        private static Random RND = new Random(); //STATICA PERCHE' ALTRIMENTI GENEREREBBE VALORI SEMPRE UGUALI
        //ATTRIBUTI
        private char _letter; //LETTERA DELLA CASELLA
        private int _points; //PUNTEGGIO DELLA CASELLA
        private bool _selected; //SELEZIONATA PER COMPORRE LA PAROLA
        private bool _clickAvailable; //POSSO CLICCARE IL CONTROLLO IN QUESTO MOMENTO?
        private IDBox _id;

        //PROPRIETA'
        public char Letter { get { return _letter; } private set { _letter = value; } }
        public int Points { get { return _points; } private set { _points = value; } }
        public bool Selected { get { return _selected; } set { _selected = value; } }
        public bool ClickAvailable { get { return _clickAvailable; } set { _clickAvailable = value; } }
        public IDBox ID { get { return _id; } private set { _id = value; } }

        //COSTRUTTORE
        public RuzzleBoxControl(int Column, int Row)
        {
            InitializeComponent();
            Letter = RandomLetter(); //ASSEGNA VALORE ATTRAVERSO IL METODO
            Points = RandomPoints(); //ASSEGNA VALORE ATTRAVERSO IL METODO
            Selected = false; //DI DEFAULT
            ClickAvailable = true; //AL PRIMO CLICK SONO TUTTI DISPONIBILI
            Paint += RuzzleBoxControl_Paint;
            Click += RuzzleBoxControl_Click;
            ID = new IDBox(Column, Row);

        }

        private void RuzzleBoxControl_Click(object sender, EventArgs e)
        {
            if (ClickAvailable && !Selected)
            {
                SoundPlayer click = new SoundPlayer("media/click.wav");
                click.Play();
                Selected = (Selected) ? false : true;
                Invalidate();
                foreach (var item in Game.Table)
                {
                    item.ClickAvailable = false;
                }
                Game.ReEnable(Game.FromIDs(ID.NearThis()));
                Game.UserWord += Letter;
                Game.TempPoints += Points;
            }

        }

        private void RuzzleBoxControl_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder3D(e.Graphics, ((Control)sender).ClientRectangle, Border3DStyle.Bump);
            BackColor = (Selected) ? Color.Red : Color.Orange;
            e.Graphics.DrawString(Letter.ToString(), new Font("Arial", 20), Brushes.Black, new Point(12, 10));
            e.Graphics.DrawString(Points.ToString(), new Font("Arial", 10), Brushes.Black, new Point(0, 0));
            e.Graphics.DrawString(ID.Row.ToString() + "," + ID.Column.ToString(), new Font("Arial", 10), Brushes.Black, new Point(30, 30));
        }


        /// <summary>
        /// RITORNA UNA LETTERA CASUALE DELL'ALFATBETO
        /// </summary>
        /// <returns>CARATTERE RANDOM DELLL'ALFABETO</returns>
        private char RandomLetter()
        {
            char[] alphabet = "ABCDEFGHILMNOPQRSTUVZ".ToCharArray();

            return alphabet[RND.Next(0, 21)];
        }

        /// <summary>
        /// RITORNA UN INT CON VALORE CASUALE DA 1 A 5
        /// </summary>
        /// <returns>NUMERO INTERO CON VALORE CASUALE</returns>
        private int RandomPoints()
        {
            return RND.Next(1, 6);
        }
    }
}
