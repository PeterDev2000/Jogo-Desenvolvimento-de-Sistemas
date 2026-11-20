using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace Pokemons
{
    public  class Bullet : PictureBox
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BulletSpeed { get; set; } = 10;
        public Bullet(int x, int y)
        {
            Size = new Size(100, 70);
            SizeMode = PictureBoxSizeMode.StretchImage;
            string path = Path.Combine(Application.StartupPath, "assets", "bullet.png");
            Image = Image.FromFile(path);
            BackColor = Color.Transparent;
            Left = x;
            Top = y;
        }

        public void Move()
        {
            Left += BulletSpeed;
        }

        public bool OffScreen()
        {
            return Left + Width > 1920;
        }
    }
}
