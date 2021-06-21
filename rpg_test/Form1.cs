using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace rpg_test
{
    public partial class Form1 : Form
    {
        Map map = new Map();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            for (int y = 0; y < 13; y++)
            {
                for (int x = 0; x < 18; x++)
                {
                    //map.Add(rnd.Next(0, 4));
                    map.addMapTiles(rnd.Next(0, 4));
                }
            }
            this.Controls.Add(map.initPanel());
            map.DrawMap();
            loop.Start();
        }
        

        private void loop_Tick(object sender, EventArgs e)
        {
            map.testPlayerMove();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
