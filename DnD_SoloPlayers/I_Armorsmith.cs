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
    public partial class I_Armorsmith : Form
    {
        public I_Armorsmith()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            show_m();
        }

        public void show_m()
        {
            List<string> answer = new List<string>();

            //Start list content

            answer.Add("Deafening Conqueror, Halberd - Weapon attacks deal +1d8 (3) thunder damage.\r\nWeapon attacks deal + 2d12(13) lightning damage.\n\rWhile equipping this item, your Strength ability score cannot be reduced below 11.\r\nAnytime you deal cold damage, the amount of cold damage dealt is increased by + 1d6.\r\n\r\nPrice: 30pp");
            answer.Add("Amulet of the Green Dragon - Grants resistance to poison damage.\r\n\r\nPrice: 10gp");
            answer.Add("Studded Leather Armor of the Black Dragon - Grants resistance to acid damage.\r\n\r\nPrice: ");
            answer.Add("Scale Mail of the Performer - Once per day, you may grant yourself advantage on any Performance skill check.\r\n\r\nPrice: 40gp");
            answer.Add("Chain Shirt of the Silver Dragon - Grants resistance to cold damage.\r\n\r\nPrice: 100sp");
            answer.Add("Breastplate of the Blue Dragon - Grants resistance to lightning damage.\r\n\r\nPrice: 150sp");
            answer.Add("Sanguine Splint of the Healer - Your maximum hit points are increased by +7.\r\nOnce per day, you may grant yourself advantage on any Medicine skill check.\r\n\r\nPrice: 13gp");
            answer.Add("Ring Mail of the Gold Dragon - Grants resistance to fire damage.\r\n\r\nPrice: 14gp");
            answer.Add("Agile Accuracy, Plate - Your maximum hit points are increased by +5.\r\nWhen you are the target of an attack roll, roll a d10.On a result of a 9 or higher, the attack misses.\r\nYou do not gain any benefits from an equipped shield.\r\nOnce per day, you may grant yourself advantage on any Performance skill check.\r\nGrants resistance to poison damage.\r\nYou gain a + 2 bonus to all combat checks.\r\n\r\nPrice: 60pp");
            answer.Add("Studded Leather Armor of the Red Dragon - Grants resistance to fire damage.\r\n\r\nPrice: 20gp");
            answer.Add("Breastplate of the Black Dragon - Grants resistance to acid damage.\r\n\r\nPrice: 5gp");
            answer.Add("Shield of Aiming - You gain a +2 bonus to all combat checks.\r\n\r\nPrice: 40sp");
            answer.Add("Spiny Shield of Accuracy - If you are hit by a melee weapon attack, the attacker suffers 1d6 (3) piercing damage.\r\nYou gain a + 1 bonus to all combat checks.\r\n\r\nPrice: 30gp");
            answer.Add("Shield of the Bulwark - Your AC is increased by +3.\r\n\r\nPrice: 30sp");
            answer.Add("Thorny Shield of the Sentinel - If you are hit by a melee weapon attack, the attacker suffers 1d4 (2) piercing damage.\r\nYour AC is increased by +2.\r\n\r\nPrice: 45sp");
            answer.Add("Thorny Shield of Accuracy - If you are hit by a melee weapon attack, the attacker suffers 1d4 (2) piercing damage.\r\nYou gain a +1 bonus to all combat checks.\r\n\r\nPrice: 20gp");
            answer.Add("Helmet of the Lizard - Your Constitution ability score is increased by +2.\r\n\r\nPrice: 32sp");
            answer.Add("Helmet of the Newt - Your Constitution ability score is increased by +1.\r\n\r\nPrice: 10sp");
            answer.Add(" Helmet of the Gremlin - Your Wisdom ability score is increased by +2.\r\n\r\nPrice: 22gp");
            answer.Add("Helmet of the Troll - Your Constitution ability score is increased by +4.\r\n\r\nPrice: 23sp");
            answer.Add("Unbreakable Silver Dragon, Helmet - You gain a +4 bonus to maintain your concentration on a spell.\r\nThe duration of negative conditions on you is reduced by 1 round.\r\nGrants resistance to cold damage.\r\nYour Strength ability score is increased by +2.\r\n\r\nPrice: 1pp");
            answer.Add("Boots of the Healer - Once per day, you may grant yourself advantage on any Medicine skill check.\r\n\r\nPrice: 23sp");
            answer.Add("Boots of the Lizard - Your Constitution ability score is increased by +2.\r\n\r\nPrice: 20gp");
            answer.Add("Boots of the Pixie - Your Wisdom ability score is increased by +1.\r\n\r\nPrice: 50gp");

            //End list content

            //random to select answer from list
            Random rnd = new Random();

            int select = rnd.Next(0, answer.Count);

            textBox1.Text = (answer[select].ToString());
        }

        private void New_One_Click(object sender, EventArgs e)
        {
            show_m();
        }
    }
}
