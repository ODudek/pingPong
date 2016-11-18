using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ping_pong
{
    public partial class Form1 : Form
    {

        public int speed_left = 4;      //Szybkosc pilki
        public int speed_top = 4;
        public int point = 0;       //Liczba punktow
        bool left;
        bool right;
        public string score;
        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();                  //Ukrycie kursora
            label_f1.Visible = false;
            label_esc.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;        //Usuwanie border'a
            this.TopMost = true;            //Form na wierzchu
            this.Bounds = Screen.PrimaryScreen.Bounds;      //Fullscreen
            label_score.Text = "0";     //Wyswietlanie wyniku
            racket.Top = panel1.Bottom - (panel1.Bottom / 10);      //Zmiana pozycji rakiety

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (racket.Left < 0) { left = false;}
            if (racket.Right > this.ClientSize.Width) { right = false; }
            if (right == true) { racket.Left += 10; }
            if (left == true) { racket.Left -= 10; }

            ball.Left += speed_left;        //Ruch pilki
            ball.Top += speed_top;

            if(ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)     //Kolizja rakiety
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                point += 1;
                label_score.Text = point.ToString();        //Aktualizacja wyniku

            }


            if(ball.Left <= panel1.Left)
            {
                speed_left = -speed_left;
            }
            if(ball.Right >= panel1.Right)
            {
                speed_left = -speed_left;
            }
            if(ball.Top <= panel1.Top)
            {
                speed_top = -speed_top;
            }
            if(ball.Bottom >= panel1.Bottom)
            {
                timer1.Enabled = false;     //Pilka jest poza polem -> zatrzymuje gre

                //Ekran koncowy
                racket.Visible = false;
                ball.Visible = false;
                wynik.Left = (this.ClientSize.Width - wynik.Width) / 2;
                wynik.Top = (this.ClientSize.Height - wynik.Height) / 2;
                //label_score.Visible = false;
                label_score.Left = (this.ClientSize.Width - label_score.Width) / 2;
                label_score.Top = (this.ClientSize.Height - label_score.Height) / 2 + 50;
                wynik.Visible = true;
                label_f1.Left = (this.ClientSize.Width - label_f1.Width) / 2;
                label_f1.Top = (this.ClientSize.Height - label_f1.Height) / 2 - 75;
                label_f1.Visible = true;
                label_esc.Left = (this.ClientSize.Width - label_esc.Width) / 2;
                label_esc.Top = (this.ClientSize.Height - label_esc.Height) / 2 - 100;
                label_esc.Visible = true;
            }

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Left) { left = true; }
            if (e.KeyCode == Keys.Escape)        //ESC wychodzi z gry
            {
                this.Close();
            }
            if(e.KeyCode == Keys.F1)
            {
                racket.Visible = true;
                ball.Visible = true;
                wynik.Visible = false;
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                point = 0;
                label_score.Text = point.ToString();
                label_score.Left = 15; 
                label_score.Top = 15;
                timer1.Enabled = true;
                label_f1.Visible = false;
                label_esc.Visible = false;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }

    }
}
