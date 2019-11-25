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
    public partial class I_Weaponsmith : Form
    {
        public I_Weaponsmith()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            List<string> answer = new List<string>();

            //List content

            answer.Add("Disc Blade - A circular blade of razor sharp steel with a central handle wrapped in leather. The use of a disc blade is an art itself, usually reserved for the martial prowess of those trained in the combat styles of the monk. A light finesse weapon that deals 1d8 slashing damage. If dual wielded, the wielder may also add their acrobatics modifier to attack rolls with this weapon.\r\n\r\nPrice: 100gp");
            answer.Add("Ricochet Shield - This magical shield can be used to make a ranged weapon attack (range 20/60 ft.). In a hit, the shild deals 1d6 bludgeoning damage then magically returns to the wielder's hand.\r\n\r\nPrice: 250gp");
            answer.Add("Kalindra - A lute with hardcore skulls and flames painted on it. Speaking its command word causes it to transform into a heavy crossbow that shoots bolts out of the mouth of a human skull.\r\n\r\nPrice: 1pp");
            answer.Add("Blowgun of the Bronze Dragon - Deals 3 piercing damage \r\n\r\nPrice: 30gp");
            answer.Add("Quarterstaff of Rime - Anytime you deal cold damage, the amount of cold damage dealt is increased by +2d6.\r\n\r\nPrice: 3gp");
            answer.Add("Sickle of Embers - Anytime you deal fire damage, the amount of fire damage dealt is increased by +1d6. \r\n\r\nPrice: 20sp");
            answer.Add("Warhammer of Needling - Your weapon attacks with this weapon critical on a 19-20. \r\n\r\nPrice: 4gp");
            answer.Add("Smouldering Hand Crossbow of the Brass Dragon - Weapon attacks deal +2d6 fire damage.\r\n\r\nPrice: 40gp");
            answer.Add("Dagger of the Repeater - When you take the Attack action, you can make an additional attack with disadvantage. If you fail the second attack the enemy you targeted gets advantage on his next turn\r\n\r\nPrice: 20sp");
            answer.Add("Burning Dagger of the Occultist - Weapon attacks deal +2d4 fire damage. At the start of their next turn, enemies hit by this attack suffer 1d4 fire damage.\r\n\r\nYou may store a spell of level 6 or lower in this weapon along with a metamagic or other such enhancement. The stored spell must have a casting time of 1 action or less. Casting the stored spell is an action that consumes the stored spell. The spell must be used by the next dawn.\r\n\r\nPrice: 1pp");
            answer.Add("Shortsword of the Black Dragon - This sword was made with hashes from the great black dragon that once lived among us. When you wield it you can feel the dark energy giving you a +4 on attack rolls\r\n\r\nPrice: 40gp");
            answer.Add("Shortbow of the Adept - While equipping this item, your Intelligence ability score cannot be reduced below 11.\r\n\r\nPrice: 10sp");
            answer.Add("Greataxe of Victory - When you land the killing blow on an enemy, regain 2d6+3 hit points.\r\n\r\nPrice: 40sp");
            answer.Add("Glaive of Snow - Anytime you deal cold damage, the amount of cold damage dealt is increased by +1d6.\r\n\r\nPrice: 1gp");
            answer.Add("Great Club of Static - Anytime you deal lightning damage, the amount of lightning damage dealt is increased by +1d8.\r\n\r\nPrice: 2gp");
            answer.Add("Sling of the Rascal - While equipping this item, your Dexterity ability score cannot be reduced below 13.\r\n\r\nPrice: 30sp");
            answer.Add("Overpowering Pike of Stinging - When you make a weapon attack to sunder, trip, disarm, or other such special combat action, you do so with advantage.\r\n\r\nYour weapon attacks with this weapon critical on an 18-20.\r\n\r\nPrice: 3gp");
            answer.Add("Arc, Staff of Lightning, Javelin - Weapon attacks deal +1d6 lightning damage.\r\n\r\nWeapon attacks deal +1d6 thunder damage.\r\n\r\nWeapon attacks deal no bludgeoning, piercing, or slashing damage.\r\n\r\nWeapon attacks affect foes within 10 ft. of the target.\r\n\r\n\"You know what they say about artifacts, you gotta learn to love them\"\r\n\r\nPrice: 20pp");
            answer.Add("Quarterstaff +2 - Just a simple quarterstaff that gives a +2 to attack rolls and hits\r\n\r\nPrice: 10sp");
            answer.Add(" Overpowering Spear of Snow - When you make a weapon attack to sunder, trip, disarm, or other such special combat action, you do so with advantage.\r\n\r\nAnytime you deal cold damage, the amount of cold damage dealt is increased by +1d6.\r\n\r\nPrice: 5gp");
            answer.Add("Dagger of Snow - Anytime you deal cold damage, the amount of cold damage dealt is increased by +1d6.\r\n\r\nPrice: 4sp");
            answer.Add("Light Hammer of the Warrior - While equipping this item, your Strength ability score cannot be reduced below 11.\r\n\r\nPrice: 5gp");
            answer.Add("Javelin of Triumph - When you land the killing blow on an enemy, regain 3d6 hit points.\r\n\r\nPrice: 20gp");

            //End list content

            //random to select answer from list
            Random rnd = new Random();

            int select = rnd.Next(0, answer.Count);

            textBox1.Text = (answer[select].ToString());
        }
    }
}
