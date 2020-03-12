using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        bool Turn = true; // X-O Check
        bool IsGameOver = false;

        private void buttonClick(object sender, EventArgs e)
        {
            if (IsGameOver) return;

            Button b = (Button)sender;
            
            if (Turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            Turn = !Turn;
            b.Enabled = false;
            menuStrip1.Focus();

            if(CheckWinner())
            {
                IsGameOver = true;
            }
        }

        private bool CheckWinner()
        {
            //Check Winner !!
            if (A1.Text == A2.Text && A2.Text == A3.Text)
            {
                if (A1.Text == "X")
                {
                    MessageBox.Show("X Winner !!");

                    return true;
                }
                else if (A1.Text == "O")
                {
                    MessageBox.Show("O Winner !!");

                    return true;
                }
            }
            else if (B1.Text == B2.Text && B2.Text == B3.Text)
            {
                if (B1.Text == "X")
                {
                    MessageBox.Show("X Winner !!");

                    return true;
                }
                else if (B1.Text == "O")
                {
                    MessageBox.Show("O Winner !!");

                    return true;
                }
            }
            else if (C1.Text == C2.Text && C2.Text == C3.Text)
            {
                if (C1.Text == "X")
                {
                    MessageBox.Show("X Winner !");

                    return true;
                }
                else if (C1.Text == "O")
                {
                    MessageBox.Show("O Winner !!");

                    return true;
                }
            }
            else if(A1.Text == B1.Text && B1.Text == C1.Text)
            {
                if (A1.Text == "X")
                {
                    MessageBox.Show("X Winner !");

                    return true;
                }
                else if (A1.Text == "O")
                {
                    MessageBox.Show("O Winner !!");

                    return true;
                }
            }
            else if(A2.Text == B2.Text && B2.Text == C2.Text)
            {
                if (A2.Text == "X")
                {
                    MessageBox.Show("X Winner !");

                    return true;
                }
                else if (A2.Text == "O")
                {
                    MessageBox.Show("O Winner !!");

                    return true;
                }
            }
            else if(A3.Text == B3.Text && B3.Text == C3.Text)
            {
                if (A3.Text == "X")
                {
                    MessageBox.Show("X Winner !");

                    return true;
                }
                else if (A3.Text == "O")
                {
                    MessageBox.Show("O Winner !!");

                    return true;
                }
            }
            else if(A1.Text == B2.Text && B2.Text == C3.Text)
            {
                if (A1.Text == "X")
                {
                    MessageBox.Show("X Winner !");

                    return true;
                }
                else if (A1.Text == "O")
                {
                    MessageBox.Show("O Winner !!");

                    return true;
                }
            }
            else if(A3.Text == B2.Text && B2.Text == C1.Text)
            {
                if (A3.Text == "X")
                {
                    MessageBox.Show("X Winner !");

                    return true;
                }
                else if (A3.Text == "O")
                {
                    MessageBox.Show("O Winner !!");

                    return true;
                }
            }
            else
            {
                if (IsBoardFilled())
                {
                    MessageBox.Show("Draw !!");

                    return true;
                }
            }

            return false;
        }

        private bool IsBoardFilled()
        {
            if(A1.Text == "" || A2.Text == "" || A3.Text == "" || B1.Text == "" || B2.Text == "" || B3.Text == "" || C1.Text == "" || C2.Text == "" || C3.Text == "")
            {
                return false;
            }

            return true;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //BUTTON TEXT RESET
            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            C1.Text = "";
            C2.Text = "";
            C3.Text = "";

            //BUTTON ENABLED TRUE
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;

            IsGameOver = false;
            Turn = true; 
        }
    }
}
