using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_SoloPlayers
{
    public partial class Dungeon_Crawler : Form
    {
        public Dungeon_Crawler()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void Dungeon_Crawler_FormClosing1(object sender, FormClosingEventArgs e)
        {
            DungeonCrawler_UserControl.UserControl1.Monster_Positions1.Clear();
            DungeonCrawler_UserControl.UserControl1.List_Last_Positions1.Clear();
        }

        private void Dungeon_Crawler_FormClosed(object sender, FormClosedEventArgs e)
        {
            DungeonCrawler_UserControl.UserControl1.Monster_Positions1.Clear();
            DungeonCrawler_UserControl.UserControl1.List_Last_Positions1.Clear();
        }
    }
}
