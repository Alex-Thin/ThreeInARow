using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EndGame : Form
    {
        public EndGame(string username, int score, int size)
        {
            InitializeComponent();
            Username = username;
            Score = score;
            this.size = size;
            SaveResult(Username, Score, size);
        }
        string Username;
        int Score;
        int size;

        private void EndGame_Paint(object sender, PaintEventArgs e)
        {
            UserNameScoreLabel2.Text = Username + ", ваш счет равен " + Score + ".";
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Form form = new StartMenu();
            form.Show();
            this.Close();
        }
        private void SaveResult(string username, int score, int size)
        {
            StreamReader sr = new StreamReader("Results.txt");
            string results = sr.ReadToEnd();
            if (results=="")
            {
                results = Username + "//" + Score + "//" + size;
            }else results += "\r\n" + Username + "//" + Score + "//" + size;
            sr.Close();
            StreamWriter sw = new StreamWriter("Results2.txt");
            sw.Write(results);
            sw.Close();
            File.Delete("Results.txt");
            File.Copy("Results2.txt", "Results.txt");
            File.Delete("Results2.txt");

        }
    }
}
