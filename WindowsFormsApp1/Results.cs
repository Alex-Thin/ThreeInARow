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
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
            WriteResults();
        }

        private void WriteResults()
        {
            ResultTextBox.Text = "";
            string[] results = File.ReadAllLines("Results.txt");
            string[] str;
            Result[] MasResult = new Result[results.Length];
            if (results != null)
            {
                for (int i = 0; i < results.Length; i++)
                {
                    str = results[i].Split(new[] { "//" }, StringSplitOptions.None);
                    Result result = new Result(str[0], Convert.ToInt32(str[1]), Convert.ToInt16(str[2]));
                    MasResult[i] = result;
                }
                Array.Sort(MasResult, new Result.SortByScore());
                for (int j = 0; j < MasResult.Length; j++)
                {
                    ResultTextBox.Text += MasResult[j] + "\r\n";
                }
            }

        }

        private void ExitButton3_Click(object sender, EventArgs e)
        {
            Form form = new StartMenu();
            form.Show();
            this.Close();
        }
    }
}
