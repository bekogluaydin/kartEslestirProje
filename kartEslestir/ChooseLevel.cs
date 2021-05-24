using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kartEslestir
{
    public partial class ChooseLevel : Form
    {
        public ChooseLevel()
        {
            InitializeComponent();
        }

        private void ChooseLevel_Load(object sender, EventArgs e)
        {
            lblUserName.Text = "Hoşgeldin " + MainMenu.userName;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            MainMenu.exit.Enabled = true;
            MainMenu.start.Enabled = true;
            MainMenu.clearUserName.Enabled = true;
            this.Close();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {   //List<MainMenu> mainMenus = Application.OpenForms.Cast<MainMenu>().ToList();
            //mainMenus[0].Close();

            MainMenu.introSound.Stop();
            new EasyGame().Show();
            this.Close();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            MainMenu.introSound.Stop();
            new NormalGame().Show();
            this.Close();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            MainMenu.introSound.Stop();
            new HardGame().Show();
            this.Close();
        }
    }
}
