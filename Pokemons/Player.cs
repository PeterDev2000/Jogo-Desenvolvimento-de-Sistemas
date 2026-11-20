using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.ComponentModel;

namespace Pokemons
{
    public class Player : PictureBox
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Speed { get; set; } = 10;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Bullet> Bullets { get; set; } = new List<Bullet>();

        public Player() {
            Size = new Size(100, 100);
            SizeMode = PictureBoxSizeMode.StretchImage;
            string path = Path.Combine(Application.StartupPath, "assets", "player.png");
            Image = Image.FromFile(path);
            BackColor = Color.Transparent;
        }

        public void Movement(Keys key, int withScreen, int heightScreen)
        {
            if (key == Keys.W || key == Keys.Up)
            {
                Top -= Speed;
                if (Top + Height < 0)
                {
                    Top = heightScreen;
                };
            };
            if (key == Keys.A || key == Keys.Left)
            {
                Left -= Speed;

                if (Left + Width < 0)
                {
                    Left = withScreen;
                }
            };
            if (key == Keys.S || key == Keys.Down)
            {
                Top += Speed;

                if (Top > heightScreen)
                {
                    Top = -Height;
                }
            }
            if (key == Keys.D || key == Keys.Right)
            {
                Left += Speed;

                if (Left > withScreen)
                {
                    Left = -Width;
                }
            }
        }
        public Bullet Shoot()
        {
            Bullet bullet = new Bullet(Left + (Width / 2) - 5, Top - 20);
            Bullets.Add(bullet);


            return bullet;
        }
    }
}
