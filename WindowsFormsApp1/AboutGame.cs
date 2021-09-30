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
    public partial class AboutGame : Form
    {
        public AboutGame()
        {
            InitializeComponent();
        }

        private void ExitButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form1 = new StartMenu();
            form1.Visible = true;
        }
    }
}
