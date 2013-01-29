using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LittleGameBox
{
    public partial class Form1 : Form
    {
        enum turn
        { 
            xturn,
            oturn
        };

        string XPlayerName;
        string OPlayerName;
        bool named = false; 

        public char XPlayer = 'X';
        public char OPlayer = 'O';
        private turn whoseturn;

        List<Char> Owners = new List<char>();
        int currentCell; 

        public Form1()
        {
            InitializeComponent();
            mainMenuToolStripMenuItem.Enabled = true;
            setupOwners(); 
            whoseturn = turn.xturn;
            this.Text = "It is " + XPlayer + "'s turn.";

        }

        public Form1(String X, String O)
        {
            InitializeComponent();
            named = true;
            XPlayerName = X;
            OPlayerName = O;
            mainMenuToolStripMenuItem.Enabled = true;
            setupOwners();
        }

        void setupOwners()
        {
            for (int i = 0; i < 9; i++)
                Owners.Add(' ');
            if (named)
                this.Text = "It is " + XPlayerName + "'s turn.";
        }

        void checkForWin()
        {
            if (whoseturn == turn.xturn)
            {
                if (cellCheck())
                {
                    winner();
                    if (named)
                        MessageBox.Show(XPlayerName + " Wins!");
                    else
                        MessageBox.Show(XPlayer + " Wins!");
                }

                if (playCanContinue())
                {
                    whoseturn = turn.oturn;
                    if (named)
                        this.Text = "It is " + OPlayerName + "'s turn.";
                    else
                        this.Text = "It is " + OPlayer + "'s turn.";
                }
                else
                    gameOver();
                
            }
            else
            {
                if (cellCheck())
                {
                    winner();
                    if (named)
                        MessageBox.Show(OPlayerName + " Wins!");
                    else
                        MessageBox.Show(OPlayer + " Wins!");
                }
                if (playCanContinue())
                {
                    whoseturn = turn.xturn;
                    if (named)
                        this.Text = "It is " + XPlayerName + "'s turn.";
                    else
                        this.Text = "It is " + XPlayer + "'s turn.";
                }
                else
                    gameOver(); 
            }
            
        }

        bool playCanContinue()
        {
            return (UpLeft.Enabled || UpCenter.Enabled || UpRight.Enabled
                    || MidLeft.Enabled || MidCenter.Enabled || MidRight.Enabled
                    || LowLeft.Enabled || LowCenter.Enabled || LowRight.Enabled);
        }

        bool cellCheck()
        {
            char playerstoken = (whoseturn == turn.xturn) ? XPlayer : OPlayer; 

            switch (currentCell)
            {
                case 0: return (((Owners[1] == playerstoken) && (Owners[2] == playerstoken)) 
                                || ((Owners[3] == playerstoken) && (Owners[6] == playerstoken))
                                || ((Owners[4] == playerstoken) && (Owners[8] == playerstoken)));

                case 1: return (((Owners[0] == playerstoken) && (Owners[2] == playerstoken))
                                || ((Owners[4] == playerstoken) && (Owners[7] == playerstoken)));
                    
                case 2: return (((Owners[1] == playerstoken) && (Owners[0] == playerstoken))
                                || ((Owners[5] == playerstoken) && (Owners[8] == playerstoken))
                                || ((Owners[4] == playerstoken) && (Owners[6] == playerstoken)));

                case 3: return (((Owners[0] == playerstoken) && (Owners[6] == playerstoken))
                                || ((Owners[4] == playerstoken) && (Owners[5] == playerstoken)));

                case 4: return (((Owners[3] == playerstoken) && (Owners[5] == playerstoken))
                                || ((Owners[1] == playerstoken) && (Owners[7] == playerstoken))
                                || ((Owners[0] == playerstoken) && (Owners[8] == playerstoken))
                                || ((Owners[2] == playerstoken) && (Owners[6] == playerstoken)));

                case 5: return (((Owners[3] == playerstoken) && (Owners[4] == playerstoken))
                                || ((Owners[2] == playerstoken) && (Owners[8] == playerstoken)));

                case 6: return (((Owners[7] == playerstoken) && (Owners[8] == playerstoken))
                                || ((Owners[0] == playerstoken) && (Owners[3] == playerstoken))
                                || ((Owners[4] == playerstoken) && (Owners[2] == playerstoken)));

                case 7: return (((Owners[6] == playerstoken) && (Owners[8] == playerstoken))
                                || ((Owners[1] == playerstoken) && (Owners[4] == playerstoken)));

                case 8: return (((Owners[6] == playerstoken) && (Owners[7] == playerstoken))
                                || ((Owners[2] == playerstoken) && (Owners[5] == playerstoken))
                                || ((Owners[0] == playerstoken) && (Owners[4] == playerstoken))); 
            }

            return false; 

        }

        void winner()
        {
            UpLeft.Enabled = false;
            UpCenter.Enabled = false;
            UpRight.Enabled = false;
            MidLeft.Enabled = false;
            MidCenter.Enabled = false;
            MidRight.Enabled = false;
            LowLeft.Enabled = false;
            LowCenter.Enabled = false;
            LowRight.Enabled = false;
        }

        void gameOver() 
        {
            MessageBox.Show("Game Over"); 
        }
       

        private void UpLeft_Click(object sender, EventArgs e)
        {
            currentCell = 0;
            UpLeft.Enabled = false;
            Owners[currentCell] = (whoseturn == turn.xturn) ? XPlayer : OPlayer;
            if(!named)
                UpLeft.Text = (whoseturn == turn.xturn) ? XPlayer.ToString() : OPlayer.ToString();
            else
                UpLeft.Text = (whoseturn == turn.xturn) ? XPlayerName : OPlayerName;
            checkForWin(); 
        }

        private void UpCenter_Click(object sender, EventArgs e)
        {
            currentCell = 1; 
            UpCenter.Enabled = false;
            Owners[currentCell] = (whoseturn == turn.xturn) ? XPlayer : OPlayer;
            if (!named)
                UpCenter.Text = (whoseturn == turn.xturn) ? XPlayer.ToString() : OPlayer.ToString();
            else
                UpCenter.Text = (whoseturn == turn.xturn) ? XPlayerName : OPlayerName;
            checkForWin(); 
        }

        private void UpRight_Click(object sender, EventArgs e)
        {
            currentCell = 2; 
            UpRight.Enabled = false;
            Owners[currentCell] = (whoseturn == turn.xturn) ? XPlayer : OPlayer;
            if (!named)
                UpRight.Text = (whoseturn == turn.xturn) ? XPlayer.ToString() : OPlayer.ToString();
            else
                UpRight.Text = (whoseturn == turn.xturn) ? XPlayerName : OPlayerName;
            checkForWin();
        }

        private void MidLeft_Click(object sender, EventArgs e)
        {
            currentCell = 3;
            MidLeft.Enabled = false;
            Owners[currentCell] = (whoseturn == turn.xturn) ? XPlayer : OPlayer;
            if (!named)
                MidLeft.Text = (whoseturn == turn.xturn) ? XPlayer.ToString() : OPlayer.ToString();
            else
                MidLeft.Text = (whoseturn == turn.xturn) ? XPlayerName : OPlayerName;
            checkForWin();
        }

        private void MidCenter_Click(object sender, EventArgs e)
        {
            currentCell = 4;
            MidCenter.Enabled = false;
            Owners[currentCell] = (whoseturn == turn.xturn) ? XPlayer : OPlayer;
            if (!named)
                MidCenter.Text = (whoseturn == turn.xturn) ? XPlayer.ToString() : OPlayer.ToString();
            else
                MidCenter.Text = (whoseturn == turn.xturn) ? XPlayerName : OPlayerName; checkForWin();
        }

        private void MidRight_Click(object sender, EventArgs e)
        {
            currentCell = 5; 
            MidRight.Enabled = false;
            Owners[currentCell] = (whoseturn == turn.xturn) ? XPlayer : OPlayer;
            if (!named)
                MidRight.Text = (whoseturn == turn.xturn) ? XPlayer.ToString() : OPlayer.ToString();
            else
                MidRight.Text = (whoseturn == turn.xturn) ? XPlayerName : OPlayerName; checkForWin();
        }

        private void LowLeft_Click(object sender, EventArgs e)
        {
            currentCell = 6;
            LowLeft.Enabled = false;
            Owners[currentCell] = (whoseturn == turn.xturn) ? XPlayer : OPlayer;
            if (!named)
                LowLeft.Text = (whoseturn == turn.xturn) ? XPlayer.ToString() : OPlayer.ToString();
            else
                LowLeft.Text = (whoseturn == turn.xturn) ? XPlayerName : OPlayerName;
            checkForWin();
        }

        private void LowCenter_Click(object sender, EventArgs e)
        {
            currentCell = 7;
            LowCenter.Enabled = false;
            Owners[currentCell] = (whoseturn == turn.xturn) ? XPlayer : OPlayer;
            if (!named)
                LowCenter.Text = (whoseturn == turn.xturn) ? XPlayer.ToString() : OPlayer.ToString();
            else
                LowCenter.Text = (whoseturn == turn.xturn) ? XPlayerName : OPlayerName;
            checkForWin();
        }

        private void LowRight_Click(object sender, EventArgs e)
        {
            currentCell = 8;
            LowRight.Enabled = false;
            Owners[currentCell] = (whoseturn == turn.xturn) ? XPlayer : OPlayer;
            if (!named)
                LowRight.Text = (whoseturn == turn.xturn) ? XPlayer.ToString() : OPlayer.ToString();
            else
                LowRight.Text = (whoseturn == turn.xturn) ? XPlayerName : OPlayerName;
            checkForWin();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 NextGame = new Form1();
            if (named)
                NextGame = new Form1(OPlayerName, XPlayerName);
            
            NextGame.Show(); 
        }

        private void setPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameForm n = new NameForm();
            n.Show();
            this.Hide();  
        }


    }
}
