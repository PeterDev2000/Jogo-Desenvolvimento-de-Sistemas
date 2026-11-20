using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pokemons
{

    public partial class Game : Form
    {
        private Player player;
        public Game()
        {
            InitializeComponent();
            CreatePlayer();
        }

        public void CreatePlayer()
        {
            player = new Player();
            player.Location = new Point(50, 340);
            Controls.Add(player);
            KeyPreview = true;
            KeyDown += Game_KeyDown;
        }

        private void Game_KeyDown(object? sender, KeyEventArgs e)
        {
            player.Movement(e.KeyCode, ClientSize.Width, ClientSize.Height);

            if (e.KeyCode == Keys.Space)
            {
                Bullet bullet = player.Shoot();
                Controls.Add(bullet);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = player.Bullets.Count - 1; i >= 0; i--)
            {
                Bullet bullet = player.Bullets[i];
                bullet.Move();

                if (bullet.OffScreen())
                {
                    Controls.Remove(bullet);
                    player.Bullets.RemoveAt(i);
                    bullet.Dispose();
                }
            }
        }
    }
}
