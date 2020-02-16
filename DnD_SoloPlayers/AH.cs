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
    public partial class AH : Form
    {
        public AH()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            show_m();
        }

        public void show_m()
        {
            List<string> answer = new List<string>();

            //List content

            answer.Add("A night hag is willing to stop terrorizing the locals if you can retrive the linen wraps of a mummy for her which she wants to use to tie bows in her mangy hair with.");
            answer.Add("A clutch of kobolds(5) is building and painting giant wooden dinosaur puppets which they are driving around to scare away local villagers in order to steal their food, water, and gold.");
            answer.Add("A wildly ambitious farmer imported a bunch of dinosaurs because \"they have big eggs\". \r\nAs you might imagine, this has gone poorly for everyone involved.");
            answer.Add("You find a map of a well-known beginner dungeon complex that seems to indicate there is a really big treasure hiden in a secret room, no one was able to find that room.");
            answer.Add("People are going missing in town. \r\nStrangely, in their place, statues of the missing people in elegant costumes have been appearing.");
            answer.Add("A nobleman has declared himself \"The King of the Dance\" and has started a perpetual party in his state. \r\nYou have just received an invite.");
            answer.Add("A lich's ex-lover stole his phylactery and is using it to get the unded wizard to date him again.\r\n The lich would like you to kill this person in exchange for several enchanted wands.");
            answer.Add("A portal to the shadowfell has been rediscovered and opened accidentally in the city, and shadowy being are coming through the night.");
            answer.Add("You are chanllenged by one assassin... who is killed by another assassin in front of them, who now also attacks the party.");
            answer.Add("An elven princess has asked you to act as \"adventurer\" entertainer for her sweet 180th birthday party.\r\n She just wants a little fun.");
            answer.Add("A subterranean druid has been lurking in the sewers below a developing city, summoning bees and bears to hamper construction.");
            answer.Add("Rumor holds that an oasis in the desert has diamonds in its lake bed as numerous as the sand.\r\n You're invited to go with another party of 3 rogues.");
            answer.Add("Something has been stalking you through the woods for days.\r\n You know it because of the tracks that were left by them.");
            answer.Add("While sleeping at the Inn, you appear to have been robbed! \r\nThe thief left behind a single flower");
            answer.Add("The party finds a map to an opening into the Underdark. \r\nIt appears to have originally been written in Undercommon.");
            answer.Add("A manic bard claims there is a ledge that, if jumped off of, will open a path to the Feywild.");
            answer.Add("The elven forest kingdom has banned the consumption of meat. \r\nNobles are willing to pay 200 gold pieces per pound of bacon");
            answer.Add("A novelist hires you in order to witness real combat so she can improve her fight scene narrations.");
            answer.Add("You're hired by a distraught mother to prove the innocence of her child before the execution.");
            answer.Add("A local boy has gone missing. \r\nHis friends had dared him to venture into an old, abandoned cottage in the woods outside town. \r\nThat was the last they saw of him.");
            answer.Add("The rotting corpse of a giant is found alongside a well-traveled road. \r\nThe giant looks like it has been dead for weeks, but travelers at a nearby wayside inn swear that it wasn't there when they ventured through yesterday afternoon.");
            answer.Add("Two lovers are having in a very loud spat in the street. \r\nSuddenly, one of them falls dead, their face contorted in a look of horror. \r\nA strange symbol glows on the side of their neck and slowly begins to fade into nothingness.");
            answer.Add("The animals in the nearby area have been acting strangely. \r\nThey no longer seem to fear people, and are all suffering an insatiable hunger for meat... even the herbivores.");
            answer.Add("A shopkeeper, while renovating the cellar of his business, discovers a strange, stone door behind a shelf.");
            answer.Add("A small town is unsure of what to do. \r\n\tA small child's voice can be heard from a long-dry well, but no children in the town are missing. \r\nWhat's more concerning is that every person who has ventured into the well in an attempt to rescue the child has not come back.");
            answer.Add("A man in a long black coat and wide-brimmed hat hastily checks out of an inn. \r\nAs he rushes out the door, a small vial of swirling green liquid falls from his pocket.");
            answer.Add("A farmer rides into town, white as a sheet. \r\nHe claims his scarecrows have been moving closer to his home each day. \r\nThis morning they were outside the windows of his house. \r\nIs this the work of local pranksters, or something else?");
            answer.Add("A tall, handsome man in fine clothes stands in the center of a crossroads. \r\nHe seems to know your name and says he has information that would be very valuable to you if you choose to return to this spot tonight when the moon is at its apex.");
            answer.Add("The stuffed head of a fantastic beast that adorns a place above the mantle in a popular local tavern suddenly comes to life and screams something in a strange language before bursting into flames.");
            answer.Add("Locals say a star fell from the sky last night and landed somewhere nearby.");
            answer.Add("Every mirror in town ceases to show reflections, but rather gives glimpses into a shadowy keep.");
            answer.Add("The sound of yelling echoes in the night as a band of villagers, armed with torches and pitchforks, gather outside a home, demanding the residents surrender their young daughter.");
            answer.Add("A cloaked man in a dark corner of the tavern tells you he has work for them but promptly dies, a dagger in his back and a sealed letter in his hand.");
            answer.Add("A concerned father approaches you at a tavern and asks for your help. \r\nHis daughter is seeing a man and he doesn't approve. \r\nHe pleads you to end the union. \r\nThe only catch; his daughter has died two years ago.");
            answer.Add("An innkeeper informs the players that a package arrived for them last night. \r\nIt is a small silver locket with a date engraved on it. \r\nThe date is one week from today.");
            answer.Add("The caretaker of a local cemetery is screaming that there are people in the mausoleums scratching at the doors.");
            answer.Add("Something big has been attacking Farmer Biden's cows. \r\nWhatever it is, it's killed five in the last week, but strangely it hasn't eaten them, only drained them of their blood.");
            answer.Add("Late at night, the sound of far-off drums can be heard in the darkness. \r\nWar drums, and lots of them.");
            answer.Add("In a large city, to rival street gangs vie for control over a neighborhood, leaving many innocent bystanders dead. \r\nThe local thieve' guild sits back and waits to endorse the winner.");
            answer.Add("A city official approaches the party discreetly, offering them a fair sum of money to kill her husband. \r\nShe then reveals her husband died two weeks ago but has been lurking the streets ever since.");
            answer.Add("A new noble from an unknown house arrived in the city last month. \r\nAround the same time, several vagrants in the area started to vanish.");
            answer.Add("Someone has hired assassins to eliminate a single member of the party, but who is behind the plot and for what reason?");
            answer.Add("A nomadic barbarian tribe is passing uncomfortably close to town and officials, as well as the citizens, are getting very nervous.");
            answer.Add("A mysterious island suddenly appears off the shore of a stretch of coast or a lake.");
            answer.Add("A mysterious island suddenly appears in the sky over a town or city.");
            answer.Add("A raven flies through an open window and lands on the floor, seemingly dead, with a message attached to its leg. \r\nThe raven then promptly transforms into a bloodied man.");
            answer.Add("A new brothel opens up nearby, but strangely they charge their patrons nothing. \r\nWhat's the catch?");
            answer.Add("A woman storms up to one of the PCs with a member of the town/city watch, points at them, and yells \"That's the one! \r\nThat's the one that killed my husband!\" ");
            answer.Add("While laying in bed one night in an inn, one of the PCs hears a small thump under their bed. \r\nIt seems to be a journal that had somehow been dislodged from its hidden resting place. \r\nIt details an extensive plot to assassinate a prominent leader in a town three days away. \r\nThe last date in the journal is two days ago.");
            answer.Add("The owner of a nearby orchard has been complaining that his trees keep changing positions during the night.");
            answer.Add("A young boy approaches a PC and hands them a heavy, leatherbound tome with a heavy lock on it and whispers \"I'm sorry\" before running off in the other direction.");
            answer.Add("A local baker whose business was failing suddenly manages to turn things around with her new, delicious meat pies. \r\nMeanwhile, unattended children have been vanishing at an alarming rate. ");
            answer.Add("A witch wants you to retrieve a sapling from a nearby dark forest which has many dangerous creatures. After you manage to get the sapling and return to the witch, you soon realize that you must fight off many angry treants that were protecting said sapling.");
            answer.Add("A town has been unresponsive to couriers and anyone who has visited it hasn’t returned and when the players enter it seems like a maze and when they don’t look at the exit it disappears so they have to escape");
            answer.Add("A group of adventurers have recently discovered an ancient giant city, filled with lost artifacts and knowledge. The most important of these artifacts have been brought to the king. But after a while it turns out some of them are haunted by the spirits of long dead giants, that aren't pleased by this turn of events.");
            answer.Add("A young man approaches the you and asks you to find a crystal hidden deep below the surface, in a drow-infested cave in exchange for a great sum of money. If you complete this quest he will ask tyou to retrieve a similar crystal from a hostile colony of elves. Then he asks for one last favour, to retrieve a third crystal from a Lich that stole it long ago. Upon receiving the third crystal he will exclaim: \"Finally, I am free!\". He transforms into a giant of unusual size, and it is revealed that he was transformed into a human as punishment for his crimes against the gods. If not stopped the giant will destroy every depiction of a God he can find.");
            answer.Add("Locals hear chants in the nearby ruins.");
            answer.Add("A powerful bard hires you to retrieve a fabled magical instrument from a dead wizard's coffin. The thing is that the wizard died 100 years ago.");
            answer.Add("Catacombs have opened beneath the city, guarded by ancient undead who let no one pass. The entrance has an iron gate replete with moss and two undead guarding it, when you enter there is no natural or artificial light and the undead managed to evolve to see in the dark without any trouble, the insides are made with old wood, doesn't seem secure.");
            answer.Add("You wake up at the Inn not knowing how you got there, everything you had is with you but something new is there too, you now have another face and you name is Zyonp. It's all a dream, an evil wizard likes to have fun by manipulating the others dreams, the thing is, you can't get out until you wake up and if you die, you won't wake up ever again. The town is full of zombies, giant spiders and a baby dragon sleeping in the middle of the town. The dream lasts for 1d6 + 2 hours.");
            answer.Add("Escaping a storm the player runs to a nearby ruin for shelter and bumps into other people who have all done the same. Walking inside a mud-slide covers the entrance and traps them within, where they have to fight their way towards a second exit where upon they encounter plot hints on the way. The people with you are Flint that is just a farmer doesn't even know how to fight, a shy girl that doesn't want to tell her name but it's heavy armored and has a crossbow and also a battle axe.");
            answer.Add("Somewhere in the town, there's a man who never leaves his house and is always developing something. He has only left his house once and never again, the rest of the town doesn't know how he eats and the guards can't enter because of some magic spell");
            answer.Add("You wake up in the dungeon you designed for fun on paper the night before.");
            answer.Add("While traveling on a mountain road, a traveling goblin bard passes by. He sings about a huge treasure that is hidden high in these mountains.\r\n\r\n(Choose one item from the DMG Magic Itens)");
            answer.Add("After a hard battle, you defeated your enemy and almost knocked him off the cliff. With his last strength he tries to get a hold of the cliff and shouts \r\n\r\n'Without me, you can never defeat him!'");
            answer.Add("While collecting a bounty on pirates, you are attacked by a Kraken and must team up to survive.");
            answer.Add("Reports of livestock deaths lead you to a remote field. The scarecrows turn to watch you pass.");
            answer.Add("A distant figure appears every night when you stop to camp.\r\nEach night it gets closer.");
            answer.Add("A rock-slide roars down just before dawn! The light of morning reveals a scene of carnage as half of the settlement is buried. The stones reek of sorcery, however, and some look...melted. This was no natural phenomenon.");
            answer.Add("Hill giants, over 10 of them, stampede past the party, some close enough that they appear to be charging the group! Perceptive PCs note their panicked expressions, and any weapons in evidence are not readied for battle. They're fleeing from something...something big.");
            answer.Add("Cattle, oxen, and even a few horses are being mutilated. If a PC manages a DC 20 Nature or Medicine check, they identify that no organs or meat was removed, just destroyed.");
            answer.Add("Out-of-season storms cut off the local population for many weeks in the growing season. Famine and disease threaten to swamp these places and the PCs are trapped here.");
            answer.Add("A clan of exiled Dwarves, forsworn by their people, has come into the region looking to make permanent settlement here. They are a cursed population, and bad things happen wherever they wander. The PCs catch sight of them entering their area.");
            answer.Add("A drunken Hill Giant, a known local, has fallen asleep across the King’s Road again, stopping all trade traffic for many days. The PCs have either been asked to assist, or are themselves delayed by the incident.");
            answer.Add("Forest fire!");
            answer.Add("A strange new insect infestation has been causing houses and any wooden structures to collapse, no matter when they were built, or how solidly their foundation. This wood blight affects anything made of wood, and would-be rescuers have found their tools, weapons, furniture, and other goods succumbing to the same fate after touching the tainted ruins. This blight will spread.");
            answer.Add("A clan of Werebears, who have been living mostly peacefully in the region, has come into contact with a Hunter, who seeks to destroy them. There are good reasons for both factions to feel justification in their existence/mission, and there are good reasons for both to be ashamed of their moral failings and crimes in the past. The PCs will become caught in the middle. ");
            answer.Add("A music festival has come to the mountain region and a 3-day schedule with food, drink, and locals camping nearby gives everyone an opportunity to unwind, relax, and get to know their neighbors. One of them has a very juicy secret that the PC discovers.");
            answer.Add("A local hunter/trapper’s body was found without skin/limbs/organs, hanging from a tree near a trade road. This is the 3rd body found.");
            answer.Add("A nearby cave is glowing with unearthly light and faint chanting can be heard on the wind. ");
            answer.Add("A flock of Perytons have each chosen one of the party members and will begin to stalk them, hoping to pick them off one-by-one when they are alone.");
            answer.Add("An abandoned hunter’s cabin offers respite, but an angry Poltergeist calls the structure home.");
            answer.Add("At night, the trees sound like they are singing (or speaking). A stranger in the area has caused this to happen.");
            answer.Add("A stampede of local wildlife rushes through the party’s camp, breaking things, causing damage, and potentially injuring the party. An apex predator is not far behind them.");
            answer.Add("A bear is caught in a hunter’s trap and is bellowing loudly. If “Speak With Animals” is used, the bear pleads for help.");
            answer.Add("A section of forest has been clear-cut, and the remnants of a loggers camp is in the area. All of the lumberjacks are dead, torn to pieces by someone or something.");
            answer.Add("A sudden squall rushes in (rain or snow) and turns the area impassable. Afterwards, the trails are either washed out or buried. ");
            answer.Add("A Roc has built a nest, and cruises the area during the day, snatching up anything human-sized, or larger.");
            answer.Add("A tribe of Goblins have moved into the area and are busy digging out a network of tunnels. They have laid traps all around the large perimeter, and have set watches up in the trees.");
            answer.Add("A Galeb Duhr, angry at recent mining from a nearby Dwarven settlement, is attacking any humanoid that wanders into its territory. It can be calmed, but it will be difficult.");
            answer.Add("A man, of advanced age, has been hand-carving a pass through a remote area, in order to cut the time it takes his people to reach the lower parts of the mountain. He has only days to go before the task is complete, and many have gathered to watch him finish.");
            answer.Add("One of the local rivers and waterfalls has completely dried up and no one knows why.");
            answer.Add("A pack of Dire Wolves have been terrorizing the locals. Their pack leader is a Wolfwere. ");
            answer.Add("A branch of Stirge, high above the treeline, have been evolving separately from the rest of the species. They have grown exponentially large, and are near the size of Rocs.");
            answer.Add("A circle of Druids has entered the area and is systematically burning out large patches of invasive plants and culling the local wildlife (humanoids included), as the entire area is dangerously out of ecological balance. ");
            answer.Add("A Gold Dragon has died, leaving its hoard unguarded. It is only a matter of time before its found.");
            answer.Add("A 3-masted sailing ship is inexplicably found wedged at the bottom of a cliff in a tumble of boulders. There is nothing aboard it, save a hidden cargo in the bowels of the ship. ");
            answer.Add("A Vampiric Mist and a Troll have teamed up to ambush travelers using a moderately-traveled pass. The Troll has a large stash of bodies that it feeds upon and will use all the gathered loot to bribe any serious opposition come to destroy it. ");
            answer.Add("A moderately-powerful Wizard has died during a complicated arcane experiment, and now his 4-story tower is walking around, trying to lure victims inside, where it will consume them to keep its own consciousness “awake”. If it fails to feed for 48 hours, it will revert back to a normal tower. There are many valuable items inside. ");
            answer.Add("A Kelpie has moved into a popular swimming/fishing area, and has been taking 1 victim a month. The locals have noticed the pattern and have attempted multiple times to kill it or drive it off without success. In desperation, they have been digging a canal to drain the lake completely. They are days away from finishing the project, which will wreak havoc on the ecosystem. A nearby Druid has heard of the activity, but will arrive 1 day too late.");
            answer.Add("A grove of Treants have succumbed to a fungal disease and are dying. The plague is spreading to the surrounding, normal trees, and within a year will consume the entire forest.");
            answer.Add("A band of mercantile Gnomes have come to the mountain heights to build a ski resort for the rich. They have completed the buildings and are awaiting the first snow when they are buried by a surprise blizzard. After the storm, the Gnomes have gone missing.");
            answer.Add("A mining settlement has uncovered something long buried. An evil stirs...");
            answer.Add("An abandoned military fort has suddenly come to life when a group of Hobgoblins takes over and begins taking slaves from the surrounding area. Their ruler, an intelligent (16) Ogre, will arrive in a week or two to begin an outright war on the local settlements. ");
            answer.Add("Something is killing the local herds and flocks of animals. Their bones are missing.");
            answer.Add("An earthquake reveals an ancient vault with a cryptic lock. Inside is a treasure beyond imagining and a guardian beyond dangerous. ");
            answer.Add("A local settlement has suddenly grown animal horns on their heads overnight. A cryptic bit of graffito is the only clue to their fate - a curse perhaps, or a powerful illusion. ");
            answer.Add("A herd of Centaurs rides into the area in a panic - claiming that a feral band of Hill Giants, crazed with some sort of demonic possession are on a rampage and driving everything before them in a skirmish line nearly 10 miles long.");
            answer.Add("A Bard, popular for their “downhome” sounds, has been struck mute. The bard is offering a large reward to cure their affliction. The bard’s instrument may be revealed to be cursed.");
            answer.Add("A Storm Giant has arrived in the area and demands a tribute that the locals could not possibly meet.");
            answer.Add("A local dam has burst its banks, flooding a few nearby settlements and devastating the countryside.");
            answer.Add("As you're sitting in the tabern drinking your ale, a dwarf enters, he's face is full of scars and open wounds, he walks directly to the bar and asks for a large cup of ale. He looks at you and sees your armour made with the finest materials, your weapon is all cleaned up.\r\nHe start walking towards you, his face is full of fear, you might not be what he thinks, but he still has to try his luck. He starts talking with you about what has been happening him the mountain where he works, something is killing everybody one by one, no one can see what it is.\r\nHe says he tried to fought with it today but could't kill it, or even scratch it. He was lucky enough to escape.\r\nHe asks for your help in exchange of 50gp.");
            answer.Add("You find a half-buried chest. Inside is the clue to a larger mystery.");
            answer.Add("A group of Crab Folk have come to trade. They have goods unique to the land-dwellers usual offerings.");
            answer.Add("A ghost ship appears off the coast every night for 7 days. If the ship is boarded, it disappears (with the party onboard) and reappears far away in the middle of a violent storm.");
            answer.Add("A lightning storm creates a group of Fulger-Golems - metallic creatures that seek only destruction.");
            answer.Add("Something is killing the local sea-life. Hundreds of dead fish and other sea creatures are washed up on the beach. ");
            answer.Add("A sea cave is discovered and, if explored, leads to an isolated branch of the Underdark that is home to creatures unlike the usual ones normally found.");
            answer.Add("A sea festival is threatened by the appearance of a horde of Drowned Zombies, rising from the ocean waves.");
            answer.Add("The nearby villagers have mistaken the new wizard in town for a necromancer and have formed a mob.");
            answer.Add("A warrior claims he can stop the creature that has been killing traders, because it is her father.");
            answer.Add("The same house is present in every town you visit.\r\nIt seems to be following you.\r\nThe people from the towns, claim that it has always been there.");
            answer.Add("A band of thieves have plagued the king's road for months.\r\nIt's secretly led by the king daughter.\r\nShe claims that it's only to defend the ousiders.");
            answer.Add("A well-known city looms in the distance.\r\nThe closer you get the more it fades until it's gone completly.\r\nPeople call it \"The unseen palace\", and say it is guarded by old gods who were left to die by their owns.");
            answer.Add("You find a corpse sitting behind the counter.\r\nIn his hand is a card with one word: \"Greed\".");


            //End list content

            //random to select answer from list
            Random rnd = new Random();

            int select = rnd.Next(0, answer.Count);

            textBox1.Text = answer[select].ToString();
        }

        private void New_One_Click(object sender, EventArgs e)
        {
            show_m();
        }
    }
}
