using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace rpg_test
{
    class Map
    {
        List<int> mapTiles = new List<int>();
        int playerCase = 23;
        Panel pan;

        public void addMapTiles(int id)
        {
            mapTiles.Add(id);
        }
        public Panel initPanel()
        {
            pan = new Panel();
            pan.Height = 416;
            pan.Width = 576;
            pan.Top = 12;
            pan.Left = 12;
            pan.BackColor = Color.Black;

            return pan;
        }
        public void testPlayerMove()
        {
            if (Keyboard.IsKeyDown(Key.Right))
            {
                playerCase += 1;
                DrawMap();
            }
            if (Keyboard.IsKeyDown(Key.Left))
            {
                playerCase -= 1;
                DrawMap();
            }
            if (Keyboard.IsKeyDown(Key.Down))
            {
                playerCase += 18;
                DrawMap();
            }
            if (Keyboard.IsKeyDown(Key.Up))
            {
                playerCase -= 18;
                DrawMap();
            }
        }
        public void DrawMap()
        {
            pan.Controls.Clear();
            int i = 0;
            for (int y = 0; y < 13; y++)
            {
                for (int x = 0; x < 18; x++)
                {
                    PictureBox pb = new PictureBox();

                    pb.Height = 32;
                    pb.Width = 32;
                    pb.Left = x * 32;
                    pb.Top = y * 32;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;

                    if (mapTiles[i] == 0)
                    {
                        pb.BackgroundImage = Properties.Resources.grass1;

                    }
                    if (mapTiles[i] == 1)
                    {
                        pb.BackgroundImage = Properties.Resources.grassFlower;
                    }
                    if (mapTiles[i] == 2)
                    {
                        pb.BackgroundImage = Properties.Resources.grassG;
                    }
                    if (mapTiles[i] == 3)
                    {
                        pb.BackgroundImage = Properties.Resources.grassFlowerx2;
                    }


                    if (playerCase == i)
                    {
                        Console.WriteLine("PLAYER");
                        PictureBox player = new PictureBox();
                        player.Height = 32;
                        player.Width = 32;
                        player.Left = x * 32;
                        player.Top = y * 32;
                        player.SizeMode = PictureBoxSizeMode.StretchImage;
                        player.BackColor = Color.Fuchsia;
                        player.BackgroundImageLayout = ImageLayout.Stretch;
                        player.Image = Properties.Resources.Idle__1_;

                        if (mapTiles[i] == 0)
                        {
                            player.BackgroundImage = Properties.Resources.grass1;

                        }
                        if (mapTiles[i] == 1)
                        {
                            player.BackgroundImage = Properties.Resources.grassFlower;
                        }
                        if (mapTiles[i] == 2)
                        {
                            player.BackgroundImage = Properties.Resources.grassG;
                        }
                        if (mapTiles[i] == 3)
                        {
                            player.BackgroundImage = Properties.Resources.grassFlowerx2;
                        }

                        pan.Controls.Add(player);
                    }
                    else
                    {
                        
                        pan.Controls.Add(pb);
                    }
                    //Console.WriteLine(i);
                    i++;
                }
            }
        }
    }
}
