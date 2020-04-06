using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_SoloPlayers
{
    public partial class Updates_Panel : Form
    {
        public Updates_Panel()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            string v058 = "Version: 0.5.8 \r\nNew: \r\n\t-> More adventure hooks, giving a total of 78 possible answers;\r\n\t-> More random encounters, giving a total of 63 possible answers;\r\n\t-> The removal of quests;";
            string v060 = "Version: 0.6.0 \r\nNew: \r\n\t-> Fixed minor bugs;";
            string v076a = "Version: 0.7.6a \r\nNew: \r\n\t-> New design;\r\n\t-> More plot hooks;\r\n\t-> More encounters;\r\n\t-> New town on world builder;\r\n\t-> Fixed minor bugs;";
            string v100 = "Version: 1.0.0 \r\nNew: \r\n\t-> New design;\r\n\t-> Hooks group created;\r\n\t-> Added side quests;\r\n\t-> Added items;\r\n\t-> New random encounters;\r\n\t-> New npc's;\r\n\t-> Added dice bag;\r\n\t-> Added player sheet;";
            string v113 = "Version: 1.1.3 \r\nNew: \r\n\t-> Added weaponsmith on items;\r\n\t-> Added roll for time on dice bag;\r\n\t-> Major update on player sheet;";
            string v120 = "Version: 1.2.0 \r\nNew: \r\n\t-> Added more adventure and campaign hooks;\r\n\t-> Added more magic weapons and weaponsmith items;\r\n\t-> Added new side quests;\r\n\t-> Added new npc's;\r\n\t-> Rolling dice now shows every value;\r\n\t-> You can now randomdly generate a new player sheet;\r\n\t-> Added custom search for hooks(beta);\r\n\t-> Added custom search for npc's(beta);\r\n\t-> Added usage tracking";
            string v124 = "Version: 1.2.4 \r\nNew: \r\n\t-> Added off-feature \"update.exe\";\r\n\t-> Fixed minor bugs;";
            string v140 = "Version: 1.4.0 \r\nNew: \r\n\t-> New design (version 2.0b);\r\n\t-> Fixed bug on generate random player sheet where ability scores would all \r\n\t get the same value;\r\n\t-> Added more Adventure / Campaign Hooks;\r\n\t-> Added custom quests on side-quests;\r\n\t-> Added new weaponsmith items (some really neat ones);\r\n\t-> Fixed some bugs on custom search (hooks and npc);";
            string v141 = "Version: 1.4.1 \r\nNew: \r\n\t-> Bug fixes on rolling dice and custom quests;\r\n\t-> Quests will now be reviewed before being available;";
            string v143 = "Version: 1.4.3 \r\nNew: \r\n\t-> Bug fixes on player sheet edit;";
            string v144 = "Version: 1.4.4 \r\nNew: \r\n\t-> Minor bug fixes;\r\n\t-> Updated database";
            string v146 = "Version: 1.4.6 \r\nNew: \r\n\t-> Fixed windows;\r\n\t-> Fixed bugs on PlayerSheet Edit;\r\n\t-> Added PetSheet and PetSheet Edit;\r\n\t-> Added Armorsmith;\r\n\t-> Fixed bugs from last update;";
            string v147 = "Version: 1.4.7 \r\nNew: \r\n\t Message from the developer: \"Last update brought some new bugs, sorry for\r\n\t the inconvenience\"\r\n\t-> Changed database location;\r\n\t-> Fixed bugs from last update;\r\n\t-> Fixed some issues in the design;";
            string v150 = "Version: 1.5.0 \r\nNew: \r\n\t-> Added Random Combat;\r\n\t-> Fixed minor bugs that came with version 1.4.7\r\n\t-> Changed database provider";

            textBox1.Text = v150 + "\r\n\r\n" + v147 + "\r\n\r\n" + v146 + "\r\n\r\n" + v144 + "\r\n\r\n" + v143 + "\r\n\r\n" + v141 + "\r\n\r\n" + v140 + "\r\n\r\n" + v124 + "\r\n\r\n" + v120 + "\r\n\r\n" + v113 + "\r\n\r\n" + v100 + "\r\n\r\n" + v076a + "\r\n\r\n" + v060 + "\r\n\r\n" + v058;
        }
    }
}
