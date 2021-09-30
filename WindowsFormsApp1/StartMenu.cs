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
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void StartMenu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutGameButton_Click(object sender, EventArgs e)
        {
            Form form2 = new AboutGame();
            form2.Show(); 
        }

        private void StartNewGameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form1 = new SecondMenu();
            form1.Show();
            
        }

        private void WatchResaultsButton_Click(object sender, EventArgs e)
        {
            Form form = new Results();
            form.Show();
        }
    }
}
