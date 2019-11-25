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
    public partial class DiceRoll : Form
    {
        public DiceRoll()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            Random rnd = new Random();
            int die = rnd.Next(1, 7);

            switch (die)
            {
                case 1:
                    textBox1.Text = "No but...";
                    break;
                case 2:
                    textBox1.Text = "No.";
                    break;
                case 3:
                    textBox1.Text = "No and...";
                    break;
                case 4:
                    textBox1.Text = "Yes but...";
                    break;
                case 5:
                    textBox1.Text = "Yes.";
                    break;
                case 6:
                    textBox1.Text = "Yes and...";
                    break;
            }
        }
    }
}
