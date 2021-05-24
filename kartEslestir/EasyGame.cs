using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace kartEslestir
{
      public partial class EasyGame : Form
    {
        //Variables
        SoundPlayer correctMatchSound = new SoundPlayer();
        SoundPlayer correctMatch2Sound = new SoundPlayer();
        SoundPlayer wrongMatchSound = new SoundPlayer();
        SoundPlayer lastTenSecondSound = new SoundPlayer();
        SoundPlayer gameOverSound = new SoundPlayer();
        SoundPlayer gameWinSound = new SoundPlayer();
        SoundPlayer gameSceneSound = new SoundPlayer();
        Random cardLocation = new Random();
        List<Point> points = new List<Point>();
        PictureBox selectImage1;
        PictureBox selectImage2;
        int cardMatchTimer, kalan;
        byte timeLeft, startGameTime;

        public EasyGame()
        {
            InitializeComponent();
        }

        private void EasyGame_Load(object sender, EventArgs e)
        {
            newGame();
        }

        void newGame()
        {
            lblUserName.Text = MainMenu.userName;
            string soundDirectory = Application.StartupPath + "\\sound";
            correctMatchSound.SoundLocation = soundDirectory + "\\correctMatch.wav";
            correctMatch2Sound.SoundLocation = soundDirectory + "\\correctMatch2.wav";
            wrongMatchSound.SoundLocation = soundDirectory + "\\wrongMatch2.wav";
            lastTenSecondSound.SoundLocation = soundDirectory + "\\lastTenSecond.wav";
            gameOverSound.SoundLocation = soundDirectory + "\\gameOver.wav";
            gameWinSound.SoundLocation = soundDirectory + "\\gameWin.wav";
            gameSceneSound.SoundLocation = soundDirectory + "\\gameScene.wav";
            

            cardMatchTimer = 1;
            kalan = 6;
            lblEslestirme.Text = "Kalan Eşleştirme: " + kalan;
            lblInfo.Text = "Bilgilendirme Alanı!";

            lblScorePoint.Text = "0";
            lblTimerMes.Text = "The game is starting!";

            startGameTime = 5;
            lblTimer.Text = startGameTime.ToString();
            easyGameTimer2.Enabled = true;
            easyGameTimer.Enabled = false;
            btnReset.Visible = false;

            foreach (PictureBox cardPicture in CardsHolder.Controls)
            {
                cardPicture.Enabled = false;
                cardPicture.Visible = true;
                points.Add(cardPicture.Location);
            }

            foreach (PictureBox cardPicture in CardsHolder.Controls)
            {
                int next = cardLocation.Next(points.Count);
                Point po = points[next];
                cardPicture.Location = po;
                points.Remove(po);
            }

            card1.Image = Properties.Resources.BAYINDIR;
            Dupcard1.Image = Properties.Resources.BAYINDIR;

            card2.Image = Properties.Resources.ERKIN;
            Dupcard2.Image = Properties.Resources.ERKIN;

            card3.Image = Properties.Resources.ÖZIL;
            Dupcard3.Image = Properties.Resources.ÖZIL;

            card4.Image = Properties.Resources.PEROTTI;
            Dupcard4.Image = Properties.Resources.PEROTTI;

            card5.Image = Properties.Resources.SOSA;
            Dupcard5.Image = Properties.Resources.SOSA;

            card6.Image = Properties.Resources.SOUZA;
            Dupcard6.Image = Properties.Resources.SOUZA;
        }

        void EndGame()
        {
            easyGameTimer.Enabled = !easyGameTimer.Enabled;
            lblTimerMes.Text = "";

            foreach (PictureBox cardPicture in CardsHolder.Controls)
            {
                cardPicture.Enabled = false;
            }

            if (timeLeft == 0)
            {
                card1.Image = Properties.Resources.BAYINDIR;
                Dupcard1.Image = Properties.Resources.BAYINDIR;

                card2.Image = Properties.Resources.ERKIN;
                Dupcard2.Image = Properties.Resources.ERKIN;

                card3.Image = Properties.Resources.ÖZIL;
                Dupcard3.Image = Properties.Resources.ÖZIL;

                card4.Image = Properties.Resources.PEROTTI;
                Dupcard4.Image = Properties.Resources.PEROTTI;

                card5.Image = Properties.Resources.SOSA;
                Dupcard5.Image = Properties.Resources.SOSA;

                card6.Image = Properties.Resources.SOUZA;
                Dupcard6.Image = Properties.Resources.SOUZA;


                gameOverSound.PlayLooping();
                lblTimer.Text = "0";
                lblInfo.Text = lblUserName.Text + ", Verilen Sürede Oyunu Bitiremedin! \nToplayabildiğin Puan: " + lblScorePoint.Text;

                if (MessageBox.Show("Oyunu Kabettin!", "", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    gameOverSound.Stop();
                }
            }
            else
            {
                gameWinSound.PlayLooping();
                lblInfo.Text = "Tebrikler " + lblUserName.Text + ", Güzel Oyun! Topladığın Puan: " + lblScorePoint.Text + " \n Kalan Süre: " + lblTimer.Text;

                if (MessageBox.Show("Oyunu Kazandın!", "", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    gameWinSound.Stop();
                }
            }
        }

        private void easyGameTimer_Tick(object sender, EventArgs e)
        {
            lblTimerMes.Text = "Remaining Time: ";
            timeLeft--;
                        
            if (timeLeft <=10){lastTenSecondSound.Play();}

            if (timeLeft == 0)
            {
                EndGame();  
            }
            else
                lblTimer.Text = timeLeft.ToString();
        }

        private void easyGameTimer2_Tick(object sender, EventArgs e)
        {
            if (--startGameTime == 0)
            {
                easyGameTimer2.Enabled = !easyGameTimer2.Enabled;
                lblTimerMes.Text = "";
                
                timeLeft = 60;
                lblTimer.Text = startGameTime.ToString();
                easyGameTimer.Enabled = true;

                foreach (PictureBox cardPicture in CardsHolder.Controls)
                {
                    cardPicture.Enabled = true;
                    cardPicture.Cursor = Cursors.Hand;
                    cardPicture.Image = Properties.Resources.fbCover;
                }
                btnReset.Visible = true;
            }
            else
                lblTimer.Text = startGameTime.ToString();
        }

        private void easyGameSelectTimer_Tick(object sender, EventArgs e)
        {
            cardMatchTimer--;
            if (cardMatchTimer == 0)
            {
                easyGameSelectTimer.Stop();
                selectImage1.Image = Properties.Resources.fbCover;
                selectImage2.Image = Properties.Resources.fbCover;
                selectImage1.Enabled = true;
                selectImage2.Enabled = true;
                selectImage1 = null;
                selectImage2 = null;
                CardsHolder.Enabled = true;
                cardMatchTimer = 2;
            }      
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lastTenSecondSound.Stop();
            newGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainMenu.exit.Enabled = true;
            MainMenu.start.Enabled = true;
            MainMenu.clearUserName.Enabled = true;
            MainMenu.introSound.PlayLooping();
            this.Close();
        }

        public void correctMatch()
        {
            correctMatchSound.Play();
            //MessageBox.Show("Doğru Eşleştirme!","",MessageBoxButtons.OK);
            lblInfo.Text = "Tebrikler, Doğru Eşleştirtiniz!";

            selectImage1.Visible = false;
            selectImage2.Visible = false;
            lblScorePoint.Text = Convert.ToString(Convert.ToInt32(lblScorePoint.Text) + 10);
            selectImage1 = null;
            selectImage2 = null;
            CardsHolder.Enabled = true;
            kalan--;
            lblEslestirme.Text = "Kalan Eşleştirme: " + kalan;
            if (kalan == 0)
            {
                EndGame();
            }
        }

        public void wrongMatch()
        {
            easyGameSelectTimer.Start();
            wrongMatchSound.Play();
            //MessageBox.Show("Yanlış Eşleştirme!", "", MessageBoxButtons.OK);
            lblInfo.Text = "Maalesef, Yanlış Eşleştirme! Şansını Tekrar Dene...";
        }

        //Select Card Value
        #region Cards
        private void card1_Click(object sender, EventArgs e)
        {
            card1.Image = Properties.Resources.BAYINDIR;
            card1.Enabled = false;

            if (selectImage1 == null)
            {
                selectImage1 = card1;
            }
            else if (selectImage1 !=null && selectImage2 == null)
            {
                selectImage2 = card1;
            }
            if (selectImage1 != null && selectImage2 != null)
            {
                CardsHolder.Enabled = false;
                if (selectImage1.Tag == selectImage2.Tag)
                {         
                    correctMatch();
                }
                else
                {
                    wrongMatch();
                }
            }
        }
        
        private void Dupcard1_Click(object sender, EventArgs e)
        {
            Dupcard1.Image = Properties.Resources.BAYINDIR;
            Dupcard1.Enabled = false;

            if (selectImage1 == null)
            {
                selectImage1 = Dupcard1;
            }
            else if (selectImage1 != null && selectImage2 == null)
            {
                selectImage2 = Dupcard1;
            }
            if (selectImage1 != null && selectImage2 != null)
            {
                CardsHolder.Enabled = false;
                if (selectImage1.Tag == selectImage2.Tag)
                {
                    correctMatch();
                }
                else
                {
                    wrongMatch();
                }
            }
        }

        private void card2_Click(object sender, EventArgs e)
        {
            card2.Image = Properties.Resources.ERKIN;
            card2.Enabled = false;

            if (selectImage1 == null)
            {
                selectImage1 = card2;
            }
            else if (selectImage1 != null && selectImage2 == null)
            {
                selectImage2 = card2;
            }

            if (selectImage1 != null && selectImage2 != null)
            {
                CardsHolder.Enabled = false;
                if (selectImage1.Tag == selectImage2.Tag)
                {
                    correctMatch();
                }
                else
                {
                    wrongMatch();
                }
            }
        }

        private void Dupcard2_Click(object sender, EventArgs e)
        {
            Dupcard2.Image = Properties.Resources.ERKIN;
            Dupcard2.Enabled = false;

            if (selectImage1 == null)
            {
                selectImage1 = Dupcard2;
            }
            else if (selectImage1 != null && selectImage2 == null)
            {
                selectImage2 = Dupcard2;
            }

            if (selectImage1 != null && selectImage2 != null)
            {
                CardsHolder.Enabled = false;
                if (selectImage1.Tag == selectImage2.Tag)
                {
                    correctMatch();
                }
                else
                {
                    wrongMatch();
                }
            }
        }

        private void card3_Click(object sender, EventArgs e)
        {
            card3.Image = Properties.Resources.ÖZIL;
            card3.Enabled = false;

            if (selectImage1 == null)
            {
                selectImage1 = card3;
            }
            else if (selectImage1 != null && selectImage2 == null)
            {
                selectImage2 = card3;
            }

            if (selectImage1 != null && selectImage2 != null)
            {
                CardsHolder.Enabled = false;
                if (selectImage1.Tag == selectImage2.Tag)
                {
                    correctMatch();
                }
                else
                {
                    wrongMatch();
                }
            }
        }

        private void Dupcard3_Click(object sender, EventArgs e)
        {
            Dupcard3.Image = Properties.Resources.ÖZIL;
            Dupcard3.Enabled = false;

            if (selectImage1 == null)
            {
                selectImage1 = Dupcard3;
            }
            else if (selectImage1 != null && selectImage2 == null)
            {
                selectImage2 = Dupcard3;
            }

            if (selectImage1 != null && selectImage2 != null)
            {
                CardsHolder.Enabled = false;
                if (selectImage1.Tag == selectImage2.Tag)
                {
                    correctMatch();
                }
                else
                {
                    wrongMatch();
                }
            }
        }

        private void card4_Click(object sender, EventArgs e)
        {
            card4.Image = Properties.Resources.PEROTTI;
            card4.Enabled = false;

            if (selectImage1 == null)
            {
                selectImage1 = card4;
            }
            else if (selectImage1 != null && selectImage2 == null)
            {
                selectImage2 = card4;
            }

            if (selectImage1 != null && selectImage2 != null)
            {
                CardsHolder.Enabled = false;
                if (selectImage1.Tag == selectImage2.Tag)
                {
                    correctMatch();
                }
                else
                {
                    wrongMatch();
                }
            }
        }

        private void Dupcard4_Click(object sender, EventArgs e)
        {
            Dupcard4.Image = Properties.Resources.PEROTTI;
            Dupcard4.Enabled = false;

            if (selectImage1 == null)
            {
                selectImage1 = Dupcard4;
            }
            else if (selectImage1 != null && selectImage2 == null)
            {
                selectImage2 = Dupcard4;
            }

            if (selectImage1 != null && selectImage2 != null)
            {
                CardsHolder.Enabled = false;
                if (selectImage1.Tag == selectImage2.Tag)
                {
                    correctMatch();
                }
                else
                {
                    wrongMatch();
                }
            }
        }

        private void card5_Click(object sender, EventArgs e)
        {
            card5.Image = Properties.Resources.SOSA;
            card5.Enabled = false;

            if (selectImage1 == null)
            {
                selectImage1 = card5;
            }
            else if (selectImage1 != null && selectImage2 == null)
            {
                selectImage2 = card5;
            }

            if (selectImage1 != null && selectImage2 != null)
            {
                CardsHolder.Enabled = false;
                if (selectImage1.Tag == selectImage2.Tag)
                {
                    correctMatch();
                }
                else
                {
                    wrongMatch();
                }
            }
        }

        private void Dupcard5_Click(object sender, EventArgs e)
        {
            Dupcard5.Image = Properties.Resources.SOSA;
            Dupcard5.Enabled = false;

            if (selectImage1 == null)
            {
                selectImage1 = Dupcard5;
            }
            else if (selectImage1 != null && selectImage2 == null)
            {
                selectImage2 = Dupcard5;
            }

            if (selectImage1 != null && selectImage2 != null)
            {
                CardsHolder.Enabled = false;
                if (selectImage1.Tag == selectImage2.Tag)
                {
                    correctMatch();
                }
                else
                {
                    wrongMatch();
                }
            }
        }

        private void card6_Click(object sender, EventArgs e)
        {
            card6.Image = Properties.Resources.SOUZA;
            card6.Enabled = false;

            if (selectImage1 == null)
            {
                selectImage1 = card6;
            }
            else if (selectImage1 != null && selectImage2 == null)
            {
                selectImage2 = card6;
            }
            if (selectImage1 != null && selectImage2 != null)
            {
                CardsHolder.Enabled = false;
                if (selectImage1.Tag == selectImage2.Tag)
                {
                    correctMatch();
                }
                else
                {
                    wrongMatch();
                }
            }
        }

        private void Dupcard6_Click(object sender, EventArgs e)
        {
            Dupcard6.Image = Properties.Resources.SOUZA;
            Dupcard6.Enabled = false;

            if (selectImage1 == null)
            {
                selectImage1 = Dupcard6;
            }
            else if (selectImage1 != null && selectImage2 == null)
            {
                selectImage2 = Dupcard6;
            }

            if (selectImage1 != null && selectImage2 != null)
            {
                CardsHolder.Enabled = false;
                if (selectImage1.Tag == selectImage2.Tag)
                {
                    correctMatch();
                }
                else
                {
                    wrongMatch();
                }
            }
        }
        #endregion       
    }
}
