using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandysChristmas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Movimiento(acelaracion);
            Greanch(acelaracion);
            perder();
            Puntos(acelaracion);
            PuntajeMasivo();
        }
        int puntaje = 0;

        Random r = new Random();
        int x, y;
            
        void Greanch(int speed)
        {
            if (enemigo.Top >= 500)
            {
                x=r.Next(0, 200);
              enemigo.Location = new Point(x, 0);

            }
            else
            {
                enemigo.Top += speed;
            }
            if (enemigo2.Top >= 500)
            {
                
                x = r.Next(0, 260);
                enemigo2.Location = new Point(x, 0);

            }
            else
            {
                enemigo2.Top += speed;
            }

            if (enemigo3.Top >= 500)
            {
            
                x = r.Next(200, 550);
                enemigo3.Location = new Point(x, 0);

            }
            else
            {
                enemigo3.Top += speed;
            }
        }
        void Puntos(int speed)
        {
            if (caramelo1.Top >= 500)
            {
                x = r.Next(0, 200);
                caramelo1.Location = new Point(x, 0);

            }
            else
            {
                caramelo1.Top += speed;
            }
            if (caramelo2.Top >= 500)
            {

                x = r.Next(0, 260);
                caramelo2.Location = new Point(x, 0);

            }
            else
            {
                caramelo2.Top += speed;
            }

            if (caramelo3.Top >= 500)
            {

                x = r.Next(200, 550);
                caramelo3.Location = new Point(x, 0);

            }
            else
            {
                caramelo3.Top += speed;
            }
            if (baston1.Top >= 500)
            {
                x = r.Next(0, 200);
                baston1.Location = new Point(x, 0);

            }
            else
            {
                baston1.Top += speed;
            }
            if (baston2.Top >= 500)
            {

                x = r.Next(0, 260);
                baston2.Location = new Point(x, 0);

            }
            else
            {
                baston2.Top += speed;
            }

            if (baston3.Top >= 500)
            {

                x = r.Next(200, 550);
                baston3.Location = new Point(x, 0);

            }
            else
            {
                baston3.Top += speed;
            }


        }

        void Movimiento(int speed)
        {
            if(obstaculo.Top>=500 )
            {
                obstaculo.Top = 0;
                
            }
            else
            {
                obstaculo.Top += speed;
                
            }
            if( obstaculo2.Top >= 500)
            {
                obstaculo2.Top = 0;
            }
            else
            {
                obstaculo2.Top += speed;
            }
                 
                if(obstaculo3.Top >= 500)
            {
                obstaculo3.Top = 0;
            }
            else
            {
                obstaculo3.Top += speed;
            }
             if( obstaculo4.Top >= 500)
            {
                obstaculo4.Top = 0;

            }
            else
            {
                obstaculo4.Top += speed;


            }

        }
        int acelaracion = 0;

        private void over_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (noel.Left > 0)
                {
                    noel.Left += -8;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (noel.Right < 630)
                {
                    noel.Left +=8;
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (acelaracion < 21)
                {
                    acelaracion++;
                }
             }
            if (e.KeyCode == Keys.Down)
            {
                if (acelaracion > 0)
                {
                    acelaracion--;
                }
            }

        }
        void perder()
        {
            if (noel.Bounds.IntersectsWith(enemigo.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (noel.Bounds.IntersectsWith(enemigo2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (noel.Bounds.IntersectsWith(enemigo3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }

        private void baston1_Click(object sender, EventArgs e)
        {

        }

        void PuntajeMasivo()
        {
            if (noel.Bounds.IntersectsWith(caramelo1.Bounds))
            {
                puntaje++;
                label1.Text = "Caramelos" + puntaje.ToString();
                x = r.Next(0, 200);
                caramelo1.Location = new Point(x, 0);

            }
            if (noel.Bounds.IntersectsWith(caramelo2.Bounds))
            {
                puntaje++;
                label1.Text = "Caramelos" + puntaje.ToString();
                x = r.Next(0, 200);
                caramelo2.Location = new Point(x, 0);
            }
            if (noel.Bounds.IntersectsWith(caramelo3.Bounds))
            {
                puntaje++;
                label1.Text = "Caramelos" + puntaje.ToString();
                x = r.Next(0, 200);
                caramelo3.Location = new Point(x, 0);
            }
            if (noel.Bounds.IntersectsWith(baston1.Bounds))
            {
                puntaje++;
                label1.Text = "Caramelos" + puntaje.ToString();
                x = r.Next(0, 200);
                baston1.Location = new Point(x, 0);
            }
            if (noel.Bounds.IntersectsWith(baston2.Bounds))
            {
                puntaje++;
                label1.Text = "Caramelos" + puntaje.ToString();
                x = r.Next(0, 200);
                baston2.Location = new Point(x, 0);
            }
            if (noel.Bounds.IntersectsWith(baston3.Bounds))
            {
                puntaje++;
                label1.Text = "Caramelos" + puntaje.ToString();
                x = r.Next(0, 200);
                baston3.Location = new Point(x, 0);
            }
        }
    }
}
