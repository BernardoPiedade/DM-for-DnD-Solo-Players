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
    public partial class RNPC : Form
    {
        public RNPC()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            show_m();
        }

        public void show_m()
        {
            List<string> answer = new List<string>();

            //List content

            answer.Add("Kilov Retsei - A flamboyant ship captain who loves dancing more than he does steering the ship. He has a terrible track record of having every crew he's ever sailed with munity against him");
            answer.Add("Forchun - A homeless, rusted automaton who limps through the city telling people's fortune for 1 sp. But after paying he disapears with the money.");
            answer.Add("Jamba Tapeli - An elf shaman whose neck has been extended with dozens of rings made from bone and who conducts ceremonial rituals alongside Umbala, his ethereal pet chameleon.");
            answer.Add("A werewolf bard that performs silly songs about their condition to hopefully make people feel more at ease around them.");
            answer.Add("A treant that has a passion for bonsai and treats the smaller trees like its children. It loves to show them off to strangers.");
            answer.Add("A centaur has rigged itself a jockey-and-horse disguise so it can pursue its deepest passion: to become a racehorse.");
            answer.Add("Plotis Hik - A girl named after her grandmother who fought against Timokil the ancient dragon, the girl lives in great pressure, people assume she's like her grandmother and will one day be able to kill Timokil baby dragons.");
            answer.Add("An Eladrin paladin didn't understand how loans worked and ended up massively in debt. She now is trying to find someone who'll help her find 1000gp to pay her loans.");
            answer.Add("A brilliant alchemist has gotten himself addicted to a kind of hallucinogenic and is now trapped in it's illusions.");
            answer.Add("A monk who was banished from his monastery for being too into singing and playing instruments, has now become a wandering entertainer.");
            answer.Add("A charcoal maker has made a deal with the local druid circle only to use the trees they bring himin exchange for excess ash.");
            answer.Add("A gnome disguised itself as a dog several years ago for a small child's temporary gift. He's now in too deep and are forced to maintain the ruse.");
            answer.Add("A simple looking, unassuming monk that gets by on alms as they wonder. Those who help him are blessed by his assistance in turn.");
            answer.Add("Millin - A female tortle with a glass eye and terrible balamce. Everyone always seems to find her tipped over on her back in the middle of the road while on their way to new destinations.");
            answer.Add("Wi Lanj - An elderly dwarven monk with rediculously slow reflexes and severe joint pain. Despite this, she insists on sparring with adventures to \"teach them a thing or two about self-defense\".");
            answer.Add("Julia Polis - A blacksmith, people in town don't trust her because she is a woman, but she'll make you some great weapons in change of some extra gold");
            answer.Add("Phythia Jolls - An elderly woman, everyone in the city knows who she is, she can tell you the future but it costs 100gp, she doesn't play in service.");
            answer.Add("Clyde Junior - An awfull bard who plays around town, his father is the prince, no one is brave enough to confront him.");
            answer.Add("Phil Lurkin - It's not a goblin nor an orc but loves gold like goblins and is big and strong like orcs");
            answer.Add("Philipa Hide - The oldest man here, what's surprising is that he's only 40 years old, he runs the local Inn, he's a nice guy, apart from being the leader of a chicken fight club");
            answer.Add("Rufus Phillins - This old blacksmith can make surprisingly awesome weapons for you, for every weapon made you have to pay 400gp, the thing is, every weapon breaks after the first hit made. He changes place every time a weapon is made.");
            answer.Add("Adril Kymo - Herbalist teacher addicted to making poison and acid, ask him for some he gives it away, but watchout his acid is strong.");
            answer.Add("Sven Trull - Local adamantine miner he can sell some for you for 250gp a piece, for more 200gp he tells you where you can find a blacksmith who will forge it for you without asking how you got it.(sounds like a good deal)");
            answer.Add("Tira Sid - The most friendly city guard you can meet, unless you did a crime, in that case you ain't going to like having her near you.");
            answer.Add("Poli & Jill - This two twins are always together and seem to have fun by pranking people. (pokémon ripoff)");
            answer.Add("H'ull Cruel - You don't want to see him, he attacks you for no reason and will try to make you suffer the most he can and then leaves you with nothing, the city guards haven't been able to capture him. Tira Sid has said she will capture it, dead or alive.");
            answer.Add("Captain Coral - The coral-obsessed captain of the 'Seven Seas', a ship so named because it's built from the salvaged wreckage of the seven different ships he lost in seven different seas.");
            answer.Add("Tilly has been locked in a cellar most of her life and only recently escaped when her captors died.\r\n\r\n(Her captor were her adoptive parents)");
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
