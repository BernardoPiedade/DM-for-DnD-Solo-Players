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
    public partial class DB_Roll_Time : Form
    {
        public DB_Roll_Time()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void Short_Time_B_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int shortTime = rnd.Next(1, 5);

            Result_Label.Text = shortTime.ToString() + " hours have passed...";
        }

        private void Medium_Time_B_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int mediumTime = rnd.Next(5, 9);

            Result_Label.Text = mediumTime.ToString() + " hours have passed...";
        }

        private void Long_Time_B_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int longTime = rnd.Next(9, 13);

            Result_Label.Text = longTime.ToString() + " hours have passed...";
        }
    }
}
