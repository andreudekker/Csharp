using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pacman
{
    public partial class frmPacman : Form
    {
        public frmPacman()
        {
            InitializeComponent();
        }
        
        private void frmPacman_Load(object sender, EventArgs e)
        {
           
        }

        public enum flechas : int
        {
            arriba = 1,
            abajo = 2,
            izquierda = 3,
            derecha = 4
        }

        flechas flecha;
        private void frmPacman_KeyDown(object sender, KeyEventArgs e)
        {
              
            if (e.KeyCode==Keys.Up)
	        {
		                flecha=flechas.arriba;
	        }
            else if (e.KeyCode == Keys.Down)
            {
                flecha =flechas.abajo;
            }
            else if (e.KeyCode == Keys.Left)
            {
                flecha = flechas.izquierda;
            }
            else if (e.KeyCode == Keys.Right)
            {
                flecha = flechas.derecha;
            }

        }

        private void TmPacman_Tick(object sender, EventArgs e)
        {
            switch (flecha)
            {
                case flechas.arriba:
                    if (picPacman.Location.Y > -picPacman.Height)
                    {
                        picPacman.Location = new Point(picPacman.Location.X, picPacman.Location.Y - 10);
                    }
                    else {
                        picPacman.Location = new Point(picPacman.Location.X, this.Height);
                          }
                    break;
                case flechas.abajo:
                    if (picPacman.Location.Y < this.Height)
                    {
                        picPacman.Location = new Point(picPacman.Location.X, picPacman.Location.Y +10);
                    }
                    else 
                    {
                        picPacman.Location= new Point(picPacman.Location.X,-picPacman.Height);
                    }
                    break;
                case flechas.izquierda:
                    if (picPacman.Location.X > -picPacman.Width)
                    {
                        picPacman.Location = new Point(picPacman.Location.X - 10, picPacman.Location.Y);
                    }
                    else
                    {
                        picPacman.Location = new Point(this.Width, picPacman.Location.Y);
                    }
                    
                    break;
                case flechas.derecha:

                    if (picPacman.Location.X < this.Width)
                    {
                        picPacman.Location = new Point(picPacman.Location.X + 10, picPacman.Location.Y);
                    }
                    else
                    {
                        picPacman.Location = new Point(0, picPacman.Location.Y);
                    }
                    break;
                default:
                    break;
            }
        }
        }
    }

