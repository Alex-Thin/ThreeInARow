using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1(int size1, string username)
        {
            Username = username;
            size = size1;
            InitializeComponent();
            buttons = new Button[size, size];
            this.Size = new Size(size*35+190, size * 35+30);
            do
            {
                MakeButtons();
                while (Colors.FindLines())
                {
                    Colors.DeleteFirstLines();
                }
            } while (Colors.IsThereAMove() == false);
            ChangeButtons();
        }
        int moves = 20;
        string Username;
        static int size;
        Button[,] buttons;
        ColorsArray Colors;
        int score = 0;
        public void MakeButtons()
        {
            Colors = new ColorsArray(size);
            for (int i= 0; i<size; i++)
            {
                for (int j=0; j<size; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(30, 30);
                    buttons[i, j].Location = new Point(j * 33, i * 33);
                    buttons[i, j].FlatStyle = FlatStyle.Flat;
                    buttons[i, j].FlatAppearance.BorderSize = 0;
                    buttons[i, j].Tag = i+" "+j;
                    buttons[i, j].Click += new EventHandler(button_Click);
                    this.Controls.Add(buttons[i, j]);
                }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            int choosedI = -1, choosedJ = 0;
            Button btn = (Button)sender;
            for (int i=0; i<size; i++)
            {
                for (int j=0; j<size; j++)
                {
                    if (buttons[i, j].FlatAppearance.BorderSize > 0)
                    {
                        choosedI = i;
                        choosedJ = j;
                    }
                }
            }
            if (choosedI==-1)
            {
                btn.FlatAppearance.BorderSize = 1;
            }else
            {
                if (buttons[choosedI, choosedJ].Location == btn.Location)
                    btn.FlatAppearance.BorderSize = 0;
                else
                {
                    buttons[choosedI, choosedJ].FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.BorderSize = 0;
                    string str = (string)btn.Tag;
                    int index = str.IndexOf(" ");
                    if (CanChange(choosedI, choosedJ, Convert.ToInt16(str.Remove(index)), Convert.ToInt16(str.Remove(0, index))))
                    {
                        if (Colors.IsItAMatch(choosedI, choosedJ, Convert.ToInt16(str.Remove(index)), Convert.ToInt16(str.Remove(0, index))))
                        { ChangeButtons();
                            MakeButtonsUnable();
                            moves--;
                            labelMoves.Text = "Moves: " + Convert.ToString(moves);
                            do
                            {
                                Wait();
                                Colors.DeleteLines();
                                ChangeButtons();
                            } while (Colors.FindLines());
                            ChangeButtons();
                            MakeButtonsAble();
                            if (moves==0)
                            {
                                Form form = new EndGame(Username, score, size);
                                form.Show();
                                this.Close();
                            }
                            if (Colors.IsThereAMove() == false)
                            {
                                MessageBox.Show("Нет хода!");
                                MakeButtons();
                                do
                                {
                                    MakeButtons();
                                    while (Colors.FindLines())
                                    {
                                        Colors.DeleteFirstLines();
                                    }
                                } while (Colors.IsThereAMove() == false);
                                ChangeButtons();
                            }
                        }                        
                    }                    
                }
            }
        }
        private bool CanChange(int i1, int j1, int i2, int j2)
        {
            if ((Math.Abs(i1 - i2) <= 1) && (Math.Abs(j1 - j2) <= 1))
                return true;
            else return false;
        }
        public void ChangeButton(int i, int j)
        {
            buttons[i, j].BackgroundImage = Resources.bang;
        }

        public void ChangeButtons()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Colors[i, j] == 1)
                        buttons[i, j].BackgroundImage = Resources.Black_Widow;
                    else if (Colors[i, j] == 2)
                        buttons[i, j].BackgroundImage = Resources.Captain_America;
                    else if (Colors[i, j] == 3)
                        buttons[i, j].BackgroundImage = Resources.Hulk;
                    else if (Colors[i, j] == 4)
                        buttons[i, j].BackgroundImage = Resources.Iron_Man;
                    else buttons[i, j].BackgroundImage = Resources.Thor;
                }
            }
        }
        public void Wait()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.ElapsedMilliseconds < 500)
                Application.DoEvents();
        }
        public void ChangeScore()
        {
            score += 10;
            scorelabel.Text = Convert.ToString(score);
        }
        public void MakeButtonsUnable()
        {
            for (int i=0; i<size; i++)
                for (int j=0; j<size; j++)
                {
                    buttons[i, j].Enabled = false;
                }
        }
        public void MakeButtonsAble()
        {
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    buttons[i, j].Enabled = true;
                }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Location = new Point(size * 33, 0);
            pictureBox1.Size = new Size(200, size * 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal ;
            this.BackColor = Color.FromArgb(26, 43, 80);
            this.labelScore.Parent = this.pictureBox1;
            this.labelScore.BackColor = Color.Transparent;
            labelScore.Font = new Font("Segoe Print", 25, FontStyle.Bold);
            labelScore.Location = new Point(40, 0);
            this.scorelabel.Parent = this.pictureBox1;
            this.scorelabel.BackColor = Color.Transparent;
            scorelabel.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            scorelabel.Location = new Point(15, 60);
            this.labelMoves.Parent = this.pictureBox1;
            this.labelMoves.BackColor = Color.Transparent;
            labelMoves.Font = new Font("Segoe Print", 15, FontStyle.Bold);
            labelMoves.Location = new Point(15, size*10+17);
            buttonExit.Parent = pictureBox1;
            buttonExit.Location = new Point(pictureBox1.Width-100, pictureBox1.Height - 50);
            buttonExit.BackColor = this.BackColor;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form1 = new StartMenu();
            form1.Show();
        }
    }
}
