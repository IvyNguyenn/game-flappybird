﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class FlappyBird : Form
    {
        public FlappyBird()
        {
            InitializeComponent();
        }

        #region Declare
        PictureBox nenDat = new PictureBox();
        PictureBox nenDat2 = new PictureBox();
        PictureBox Bird = new PictureBox();
        PictureBox OngncT = new PictureBox();
        PictureBox OngncT1 = new PictureBox();
        PictureBox OngncD = new PictureBox();
        PictureBox OngncD1 = new PictureBox();

        SoundPlayer msQuaCot = new SoundPlayer(Properties.Resources.QuaCot);
        SoundPlayer msKetThuc = new SoundPlayer(Properties.Resources.fail);
        SoundPlayer msGame = new SoundPlayer(Properties.Resources.gamesound);

        Label lbChiDan = new Label();
        Random rand = new Random();

        int x = 300, x1 = 565;
        int ybrid = 100; //Toa do Y cua Bird : 100;
        int randyT = -360, randyT1 = -360;// Tọa độ ống nước trên 
        int randyD = 260, randyD1 = 260;// Tọa độ ống nước dưới
        int Cot = 300, Cot1 = 565;// tọa độ cột nước
        int diem = 0;
        bool flag = false, flagBird = false;
        bool flag1 = true, flag2 = false, flag3 = false, flag4 = false;

        #endregion

        #region Khởi tạo
        private void TaoNenDat()
        {
            nenDat.Location = new Point(0, 400);
            nenDat.Size = new Size(700, 100);
            nenDat.BackgroundImage = new Bitmap(Properties.Resources.NenDat);
            this.Controls.Add(nenDat);
        }

        private void TaoBird()
        {
            Bird.Location = new Point(30, 100);
            Bird.Size = new Size(50, 50);
            Bird.BackgroundImage = new Bitmap(Properties.Resources.Bird1);
            Bird.BackgroundImageLayout = ImageLayout.Stretch;
            this.Controls.Add(Bird);
        }

        private void TaoOng()
        {
            OngncT.Location = new Point(300, -350);
            OngncT.Size = new Size(65, 500);
            OngncT.BackgroundImage = new Bitmap(Properties.Resources.OngnuocTren);
            OngncT.BackColor = Color.Transparent;

            OngncD.Location = new Point(300, 250);
            OngncD.Size = new Size(65, 500);
            OngncD.BackgroundImage = new Bitmap(Properties.Resources.OngnuocDuoi);
            OngncD.BackColor = Color.Transparent;

            OngncT1.Location = new Point(565, -350);
            OngncT1.Size = new Size(65, 500);
            OngncT1.BackgroundImage = new Bitmap(Properties.Resources.OngnuocTren);
            OngncT1.BackColor = Color.Transparent;

            OngncD1.Location = new Point(565, 250);
            OngncD1.Size = new Size(65, 500);
            OngncD1.BackgroundImage = new Bitmap(Properties.Resources.OngnuocDuoi);
            OngncD1.BackColor = Color.Transparent;

            this.Controls.Add(OngncT);
            this.Controls.Add(OngncT1);
            this.Controls.Add(OngncD);
            this.Controls.Add(OngncD1);
        }

        private void TaoLabelGame()
        {
            lbChiDan.Location = new Point(230, 180);
            lbChiDan.Size = new Size(300, 50);
            lbChiDan.BackColor = Color.Transparent;
            lbChiDan.Font = new Font("Tahoma", 16, FontStyle.Bold);
            lbChiDan.Text = "Press F to play";
            this.Controls.Add(lbChiDan);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TaoBird();
            TaoNenDat();
            TaoOng();
            pbOver.Hide();
            TaoLabelGame();
            msGame.Play();
            this.BackgroundImage = new Bitmap(Properties.Resources.BG);
            this.Bird.BackColor = Color.Transparent;
            this.lbDiem.BackColor = Color.Transparent;
            this.pictureBox1.BackColor = Color.Transparent;
            this.pbReady.BackColor = Color.Transparent;
            this.pbOver.BackColor = Color.Transparent;
            this.pbReady.BackColor = Color.Transparent;
            timerCotNuoc.Interval = 20;
            timerBird.Interval = 10;
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        #endregion

        #region Sự kiện Timer
        private void btnVaoGame_Click(object sender, EventArgs e)
        {
            pnGame.Hide();
            this.Focus();
        }

        private void timerCotNuoc_Tick(object sender, EventArgs e)
        {
            x -= 3;
            Cot = x;
            x1 -= 3;
            Cot1 = x1;


            OngncT.Location = new Point(x, randyT);
            OngncD.Location = new Point(x, randyD);
            OngncT1.Location = new Point(x1, randyT1);
            OngncD1.Location = new Point(x1, randyD1);
            if (x <= -60)
            {
                x = 500;
                randyT = rand.Next(-380, -310);
                randyD = rand.Next(270, 330);
            }
            if (x1 <= -60)
            {
                x1 = 500;
                randyT1 = rand.Next(-380, -310);
                randyD1 = rand.Next(270, 330);
            }
            CongDiem();
        }

        private void timerBird_Tick(object sender, EventArgs e)
        {
            if (flagBird == true)
            {
                ybrid += 3;
                if (flag1 == true)
                {
                    Bird.BackgroundImage = new Bitmap(Properties.Resources.Bird1);
                    Bird.Location = new Point(50, ybrid);
                    flag1 = false;
                    flag2 = true;
                    flag3 = false;
                    flag4 = false;
                }
                else if (flag2 == true)
                {
                    Bird.BackgroundImage = new Bitmap(Properties.Resources.Bird2);
                    Bird.Location = new Point(50, ybrid);
                    flag1 = false;
                    flag2 = false;
                    flag3 = true;
                    flag4 = false;
                }
                else if (flag3 == true)
                {
                    Bird.BackgroundImage = new Bitmap(Properties.Resources.Bird3);
                    Bird.Location = new Point(50, ybrid);
                    flag1 = false;
                    flag2 = false;
                    flag3 = false;
                    flag4 = true;
                }
                else if (flag4 == true)
                {
                    Bird.BackgroundImage = new Bitmap(Properties.Resources.Bird1);
                    Bird.Location = new Point(50, ybrid);
                    flag1 = true;
                    flag2 = false;
                    flag3 = false;
                    flag4 = false;
                }
                XuLiVaCham();
            }
            if (ybrid >= 354)
            {
                this.Bird.BackgroundImage = new Bitmap(Properties.Resources.GameOver);
                timerBird.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nguyễn Ngọc Hoàng Vy - 16110530\n" +
                            "Nguyễn Văn Rum             - 16110438","Sinh viên thực hiện");
        }

        private void btnVaoGame_MouseMove(object sender, MouseEventArgs e)
        {
            btnVaoGame.BackColor = Color.SkyBlue;
            btnVaoGame.ForeColor = Color.DarkRed;
        }

        private void btnVaoGame_MouseLeave(object sender, EventArgs e)
        {
            btnVaoGame.BackColor = Color.Transparent;
            btnVaoGame.ForeColor = Color.Black;
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            lbChiDan.Hide();
            pbReady.Hide();
            if (e.KeyCode == Keys.F)
            {
                timerCotNuoc.Start();
                timerBird.Start();
                ybrid -= 35;
                this.Bird.BackgroundImage = new Bitmap(Properties.Resources.Bird2);
                this.Bird.BackColor = Color.Transparent;
                this.Bird.Location = new Point(50, ybrid);
                flagBird = true;
            }
        }

        private void timerNenDat_Tick(object sender, EventArgs e)
        {
            do
            {
                if (x <= 0 && x1 <= 500)
                {
                    x -= 10;
                    x1 -= 10;
                    nenDat.Location = new Point(x, 400);
                    nenDat2.Location = new Point(x1, 400);
                }
                if (x == -500)
                {
                    timerNenDat.Stop();
                    break;
                }
            } while (flag == true);
        }
        #endregion

        #region Xử lý 

        private void XuLiVaCham()
        {
            //Xử lí va chạm cột trên dưới.
            //Cot là tọa độ cột.
            int X = Cot + 65;
            if ((Cot <= 90 && Cot >= 50) && ybrid <= (randyT + 500) ||
                ((Cot + 65) <= 75 && (Cot + 65) >= 50 && ybrid <= (randyT + 500)) ||
                ((X + Cot) / 2 <= 75 && ((X + Cot) / 2) >= 50 && ybrid <= (randyT + 500))
                )
            {
                timerBird.Stop();
                timerCotNuoc.Stop();
                ThongBaoKetThuc();
            }


            else if (Cot <= 90 && Cot >= 50 && (ybrid + 45) >= randyD ||
                ((Cot + 65) <= 75 && (Cot + 65) >= 50 && (ybrid + 45) >= randyD) ||
                (((X + Cot) / 2) <= 75 && ((X + Cot) / 2) >= 50 && (ybrid + 45) >= randyD)
                )
            {
                timerBird.Stop();
                timerCotNuoc.Stop();
                ThongBaoKetThuc();
            }


            //Xử lí va chạm cột trên dưới 1.
            int X1 = Cot1 + 65;
            if ((Cot1 <= 90 && Cot1 >= 50) && ybrid <= (randyT1 + 500) ||
               ((Cot1 + 65) <= 75 && (Cot1 + 65) >= 50 && ybrid <= (randyT1 + 500)) ||
               ((X1 + Cot1) / 2 <= 75 && ((X1 + Cot1) / 2) >= 50 && ybrid <= (randyT1 + 500))
               )
            {
                timerBird.Stop();
                timerCotNuoc.Stop();
                ThongBaoKetThuc();
            }


            else if (Cot1 <= 90 && Cot1 >= 50 && (ybrid + 45) >= randyD1 ||
                ((Cot1 + 65) <= 75 && (Cot1 + 65) >= 50 && (ybrid + 45) >= randyD1) ||
                (((X1 + Cot1) / 2) <= 75 && ((X1 + Cot1) / 2) >= 50 && (ybrid + 45) >= randyD1)
                )
            {
                timerBird.Stop();
                timerCotNuoc.Stop();
                ThongBaoKetThuc();
            }

        }

        private void CongDiem()
        {
            if ((x + 65) == 50 || (x1 + 65) == 45 || (x + 65) == 31 || (x1 + 65) == 37)
            {
                diem++;
                msQuaCot.Play();
                this.lbDiem.Text = diem.ToString();
            }
        }

        private void ThongBaoKetThuc()
        {
            pbOver.Show();
            msKetThuc.Play();
            Bird.BackgroundImage = new Bitmap(Properties.Resources.BirdDie);
            Bird.BackgroundImageLayout = ImageLayout.Stretch;
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("GAME OVER \n" + "Scores :  " + lbDiem.Text.ToString());
            if (dr == DialogResult.OK)
            {
                timerBird.Stop();
                timerCotNuoc.Stop();
                TaoBird();
                TaoNenDat();
                TaoOng();
                TaoLabelGame();
                lbChiDan.Show();
                pbReady.Show();
                msGame.Play();
                this.BackgroundImage = new Bitmap(Properties.Resources.BG);
                this.Bird.BackColor = Color.Transparent;
                this.lbDiem.BackColor = Color.Transparent;
                this.lbDiem.Text = "0";
                timerCotNuoc.Interval = 20;
                timerBird.Interval = 10;
                x = 300; x1 = 565;
                ybrid = 100; //Toa do Y cua Bird : 100;
                randyT = -360; randyT1 = -360;
                randyD = 260; randyD1 = 260;
                Cot = 300; Cot1 = 565;
                diem = 0;
                flag = false; flagBird = false;
                flag1 = true; flag2 = false; flag3 = false; flag4 = false;
                pbOver.Hide();
            }
        }
       
        #endregion
    }
}
