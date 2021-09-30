using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SecondMenu : Form
    {
        public SecondMenu()
        {
            InitializeComponent();
        }
        static string UserName="";
        private void ExitButton3_Click(object sender, EventArgs e)
        {
            Form form1 = new StartMenu();
            form1.Show();
            this.Close();
        }
        private void ButtonSize_Click(object sender, EventArgs e)
        {
            UserName = "";
            string[] username = UserNametextBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (username.Length == 0)
            {
                UserNametextBox.Text = "";
                ErrorLabel.Visible = true;
            }
            else
            {
                foreach (string words in username)
                    UserName += words + " ";
                ErrorLabel.Visible = false;
                Button btn = (Button)sender;
                int size = Convert.ToInt16(btn.Text.Remove(btn.Text.IndexOf("x"), btn.Text.Length - btn.Text.IndexOf("x")));
                Form form3 = new Form1(size, UserName);
                form3.Show();
                this.Hide();
            }
            
        }
    }
}
