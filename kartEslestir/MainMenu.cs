using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kartEslestir
{
   
    public partial class MainMenu : Form
    {
        //Variables
        static public SoundPlayer introSound = new SoundPlayer();
        static public string userName;
        static public Label exit, clearUserName;
        static public Button start;
        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            userName = txtUserName.Text;
            if (userName != "")
            {
                if (Application.OpenForms.Count == 1)
                {
                    new ChooseLevel().Show();
                    start = btnStart;
                    exit = lblExit;
                    clearUserName = lblClear;

                    btnStart.Enabled = false;
                    lblExit.Enabled = false;
                    lblClear.Enabled = false;
                }
            }
            else MessageBox.Show("Kullanıcı Adı Boş Bırakılamaz!!!");
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            string soundDirectory = Application.StartupPath + "\\sound";
            introSound.SoundLocation = soundDirectory + "\\mainMenu.wav";
            introSound.PlayLooping();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
