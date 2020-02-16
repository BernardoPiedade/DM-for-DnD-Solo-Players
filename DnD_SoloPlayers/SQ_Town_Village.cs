using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace DnD_SoloPlayers
{
    public partial class SQ_Town_Village : Form
    {
        static string quest = "";

        public SQ_Town_Village()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            show_m();
        }

        public void show_m()
        {
            List<string> answer = new List<string>();

            //List content

            answer.Add("A farmer approaches the party and needs help. One of his chickens turns a strange neon green when placed in moonlight, and he needs help figuring out why.");
            answer.Add("Your party finds a list of 10 names including someone they are close to. The first 4 names are crossed out.");
            answer.Add("A courier catches up to the party. They have been left a run down mansion in the will of someone they have never met. The only condition? It be lived in for 5 days. It is of course… Haunted!");
            answer.Add("A well known constellation disappears from sight. The village is divided between people who remember it, and those who don’t. The debates begin to spark an escalating series of feuds and fights.");
            answer.Add("A large river begins to inexplicably stop for 1 hour before sunset.");
            answer.Add("You enter a clearing where 2 duelists lash out at one another. The clearing is in a time loop, repeating the duel over and over again.");
            answer.Add("Rumor reaches your ears of a traveling merchant peddling sets of cursed sewing needles.");
            answer.Add("Old Jeb the farmer claims his sheepdog had puppies, but they all have split tails and he doesn’t know their sire.");
            answer.Add("The sawmill catches fire. The bucket brigade keeps it contained, but it refuses to extinguish after 2 days.");
            answer.Add("For exactly 1 round a day, everyone in town falls sway under the HOLD PERSON spell. Life continues, but everyone is on edge. “Protection” totems begin surfacing in every market shop.");
            answer.Add("Strange, mud-coated animate skeletons have risen in a nearby swamp. They won’t attack unless attacked first and try to speak with anyone nearby, but the coating of mud makes their speech indecipherable.");
            answer.Add("Snowberry bushes only bloom before a blizzard. Collect five snowberry blooms for an alchemist before the storm hits.");
            answer.Add("A suit of enchanted armor with dozens of arms has been razing nearby villages. Watch out, each arm holds a hand crossbow, and each one can attack every turn.");
            answer.Add("A goblin comes running towards you and yells “he’s coming!” and dies.");
            answer.Add("A small pack of wererats have taken up residence in the city sewers, and keep causing trouble for the locals.");
            answer.Add("A farmer says he’s heard strange singing in the night in his corn field, but whenever he goes out to look, he doesn’t find anyone. If that wasn’t strange enough, one morning he found his scarecrows had been moved into a circle.");
            answer.Add("The party is told of a local merchant who specializes in Magical items. The merchant’s name is Foezek and is described as an intelligent, compassionate Shedu. But, when the PCs seek out the shop, they find another being claiming to be Foezek and is more interested in them leaving the shop than dealing with them. In truth, this bandit killed Foezek and is dealing his magical items to an adversary of the DM’s choosing. Foezek’s body can be found in the shop (basement, or behind the counter, etc.).");
            answer.Add("The party is walking through a town when they meet an blind old man who is crawling on the ground looking for his ring. A guard watched him drop it and took it for himself.");
            answer.Add("The party finds a dagger on the body of an enemy that is much heavier than a dagger should be.");
            answer.Add("A small chest from the spell Leomund’s Secret Chest falls from the sky. When the party finds a wizard to open the chest is filled with their own equipment, along with a note book keeping track of their actions.");
            answer.Add("The party continues to wake up in the same inn, but different rooms each morning.");
            answer.Add("One of the party members is suddenly extremely allergic to cats, the rest of the party members clothes are suddenly made of cat fur. The change in clothing isn’t immediately noticable.");
            answer.Add("The party is summoned by a king to be his friends for a day.");
            answer.Add("There is a bounty out on the dish breaking bandit.");
            answer.Add("Weird noises have been heard at night coming from an older resident’s home in town. When investigated, you discover a worried old man attempting to disguise his worry at your interest in the noise and his business. If convinced that your aid is genuine, or if more discreet measures of observations are taken, you discover his wife is afflicted with lycanthropy despite having no bite marks.");
            answer.Add("The local towns people are complaining about a goblin tribe that has set up camp near by. They are acting strange and have begun constructing statues of a goblin with a pointy hat all over the area.");
            answer.Add("As the party is walking through a road they come across a beggar. He is crippled and asks for some money to help him buy food. As the party continues to walk down the road they find another beggar who looks exactly like the one they just met! When asked he says that he doesn’t have a twin brother or anything of the sort. He doesn’t know what the party is taking about and just wants some coin to buy food. As the party continues to walk they find the same man yet again. He to knows nothing. Upon further investigation they discoverer that the man was once an assistant to a local wizard. And the wizard is an expert in human cloning.");
            answer.Add("The daughter of a local politician/Noble person keeps getting kidnapped by local goblins. The party is hired to solve it once and for all.");
            answer.Add("A horse with no rider, but fully equipped is walking in the opposite direction of the party. There is a note pinned to it’s saddlebags, “send help!”");
            answer.Add("The party takes a shortcut through a friendly looking forest not shown on their map. It seems oddly silent, and soon notice all the wildlife is deep asleep – including insects and even flowers. As their eyes get heavier and heavier a wild man bursts out of the bushes, eyes propped open.");
            answer.Add("Traveling through the forest the party is stopped by the sound of a booming voice nearby “Your Wish has been granted!”. Shortly after they come apon a clearing filled red mist and a goblin holding a brass lamp laughing maniacally. The party now has to deal with what stuipd thing he has wished for.");
            answer.Add("You are confronted by a party of identical adventurers, who seem more surprised than you. They have been tracking you down for a long time, following rumours of a party of adventurers giving them a bad name. Worst of all they seem to have been adventuring longer than you…");
            answer.Add("Construction of a new museum has been halted when its found that all the workers continue to forget what they’re building, could the new exhibit be to blame?");
            answer.Add("You’ve gotten word about a logging village up north that has put up a massive reward for any adventurers willing to travel to the village, investigate the rash of disappearances and locate any of the missing persons: dead or alive.");
            answer.Add("A cranky old man in town complains that his pocket watchers stolen, and he has his suspicions on who the thief is. The townsfolk say that he’s a senile old man who probably lost it.");
            answer.Add("As your party steps through town, you suddenly start to feel the ground shake as a group of Monsterous Centipede’s erupt from the dirt, attacking the party. As they are defeated, it becomes apparent that they were summoned creatures.");
            answer.Add("One of the party’s magical or valued items has been stolen and is now held in a high security bank in a bustling city. The party must now break into the bank to retrieve their items.");
            answer.Add("A farmer asks for help. His crops are constantly getting trashed. He wants the group/player to keep watch over the night. It ends up being that the poor farmers’ trusty scarecrow has been brought to life by dark magic. It is optional to buy or make a new scarecrow.");
            answer.Add("A PC gets bit by a werewolf. There is a cure for it, however they must convince the mad wizard to give it to you.");
            answer.Add("A passing man swears to you that he is a genie who will most definitely grant you three wishes if you return his stolen lamp to him.");
            answer.Add("Every town or settlement the party goes to has an outline of a fish stenciled on a main building. The first one is really big and noticeable; the rest are subtle enough that the party won’t see them unless they announce that they’re examining the place. The town where the quest will happen has the WORD “fish” stenciled on a building.");
            answer.Add("You come across a trail of blood (unicorn) leading to a spooky forest.");
            answer.Add("The party is followed by an owl, hooting softly, eyes glowing the gentle yellow that might be magic or might be simple reflection. Over the next several days more owls join, until when the group sets down to sleep at night all they can see are hundreds of owl eyes staring down at them. Then, one of the owls scratches a message into the dirt, before flying off into the night- FOLLOW.");
            answer.Add("An unknown NPC mage has dimension doored into the middle of a fight, after all healing spells have been used by the team. He/She is on death’s door and carrying a note with his/hers killers name. He says a few words before dying.");
            answer.Add("A scrap of paper floats on the wind. It glides on the breeze. Eventually in a gust the paper catches on one of the adventures faces. Tearing it off their face, and looking at the parchment they see it is…");
            answer.Add("A paladin with the insignia of a lion’s head on her shield asks you to solve the local pest problem. Turns out the “pests” are full sized orcs.");
            answer.Add("A house outside of town is being circled by hundreds of birds. Upon approaching, the party sees that their beaks are lined with teeth, and the birds are twitching as though trying to escape possession. From the sounds inside, someone is clambering to hide within the building.");
            answer.Add("Kobolds have been attacking the town. All wearing similar regalia and a matching symbol. a raving man claims to have escaped from the kobolds’ lair. He describes a terrible dragon as the source of worship for the kobolds. The dragon is really a pseudodragon with delusions of grandeur, trained in illusion magic and has duped the kobolds into gathering a hoard for him.");
            answer.Add("In a large city, urchins are a regular problem. This trio of kidlets, however, has been luring travelers in to abandoned alleyways, where the deranged doppelganger among them eats the human and the other two children keep what was it his/her pockets.");
            answer.Add("A dryad clad in wooden armor leans against a tree his side torn wide open. He hands the party a pouch full of tiny leaves. Taking a pinch and blowing them into the air will lead the party to an ancient temple entrance almost over grown with vines. When close the pouch of leaves crumbles to dust along with the vines covering then entrance of the temple.");
            answer.Add("You find a small silver coin in the middle of a street and upon picking it up, in your mind you see a small hut deep in the forest. When you come back to reality, only you can see it but a small fae pixie glowing bright blue will show you the way.");
            answer.Add("The party encounters a man running out from the wood-line, coming towards then. He appears to be in shock over what he has seen, and tells the party that he was attacked while hunting. The man directs the party to the spot were he encounter the creature.");
            answer.Add("A local temple has reported strange events in the surrounding area: beasts attacking villagers, bandit lords more closer to the village, and mysterious lights and sounds that can only be observed from within the village.");
            answer.Add("A seemingly exorbitant amount of gold is offered on the message board to get rid of a ‘house spider’. It turns out that it’s about a spider-like mimic in the shape of a house.");
            answer.Add("A Myconid approaches you. He introduces himself as Fun-Guy and says he really needs help finding his horse. He says he ate some mushrooms and now can't remember where he left it. He offers his special fungi to you saying that maybe if you get in the same headspace as him then you can figure out where his horse was left.");
            answer.Add("A nearby ghost town begs you to help get rid of a human that won't stop haunting the ghostly residents.");
            answer.Add("A play about you and your journey has been written and performed by a local theater group, they have invited you to coma and watch.");
            answer.Add("An evil dragon is making sky travel very hard, the owner of a fleet of flying ships is offering a free 4 person ship to anyone who can kill it.");
            answer.Add("The old farm got raided by orcs and the prized cow got out!\r\nHelp the farmer find it and he will reward you handsomely.");
            answer.Add("The legendary sword, that was prophesized to bring down the evil Moniarch, has chosen the wizard instead of the fighter to be it's bearer.\r\nThe prophecy states that they shall fight to the death in melee combat.");
            answer.Add("The bard college is willing to train anyone to be proficient in intimidation, persuasion or deception.\r\nThat is, if you have the coin.");
            answer.Add("A plague is going around causing boils to form on people's skin, eventually the boils burst releasing fire beetles.\r\nFind what is spreading this monsters.");
            answer.Add("The election is coming up.\r\nOne of the groups is accusing the others of meddling with the public and purposefully spreading lies.\r\nA neutral party wants you to investigate both sides.");
            answer.Add("The guards are having a hard time dealing with goblin hoards.\r\nThey are paying 5 gp for every goblin slain.\r\nBring back the middle toe as proof.");
            answer.Add("Something is picking off dwarven miners from the mountain top.\r\nSome believe it to be a ghost, but some of the more crazy dwarfs believe it to be the yeti!");
            answer.Add("There has been a string of robberies and pick pocketing happening at the bazaar.\r\nThe watch are spread thin so they are taking any help they can to stop these crimes.");
            answer.Add("Collect the four elemental weapons so the dwarfs can use them to forge the ultimate god Slayer.");
            answer.Add("The home Maker's guild needs as much help as possible making houses for the huge amount of refugees coming in from the war.");
            answer.Add("When the mad king died with no heirs, he had a wizard seal off the treasury of the kingdom.\r\nOutside of the doors of the treasury is a fon filled with holy water. It will only open if someone related to the king willingly drops his or her blood into the water.");
            answer.Add("The weather has become unstable and it seems as if the season changes every week causing chaos.\r\nFind the weath crystals and use them to align the planet back into it's proper orbit.");
            answer.Add("The is a mole in a strong political standing that is leaking information to the rebellion. We need an outside party to find out who it is.");
            answer.Add("A member of the city watch has met up with you in secret. She has been a witness to crimes of members of the city watch.\r\nShe needs an escort to the citadel. She fears for her life and needs to report directly with higher-ups because she doesn't know how deep the corruption goes.");
            answer.Add("Hunters keep going missing. They are either getting lost in the vast ever changing forest or they are being attacked by large predators. In the past the hunters would be guided through hunting ground by Aaracokra. They can no longer help due to their war with the opposing Minotaur tribe.");
            answer.Add("A strange calamity has made it so people don't heal fully from their wounds over night!\r\nFind the source of this curse and get rid of it.");
            answer.Add("A beholder has reached out to you. He is willing to pay a large sum of money to anyone who will kill a rival beholder.");
            answer.Add("The potion of cure desease that you took was intended to cure the BBEG's son. \r\nNow you have a price on your head and you're being accused o killing the \"prince\".");
            answer.Add("The kingdom has an elaborate system of intelligence where they use familiars and birds to communicate across vast lands. Someone or something has been targething these creatures, stealing information, and crippling the land.\r\nHelp find the source of these issues.");
            answer.Add("The local tavern has a ghost who is their best server. The ghost has gone missing, and the tavern owner is looking for answers.\r\nWe thinks the rival tavern did something to him.");
            answer.Add("The group has found a puzzle made by the great wizard Rubim. It is said that whoever can solve this cube gains a permanent boost to their intelligence. \r\n\r\n(You can try to solve the cube two times a day, do an INT check, if it is 18+ you're able to solve the puzzle, and gain a permanent +2 to your INT)");
            answer.Add("The mayor has asked you to travel to the nearby towns handing out flyers for the upcoming festival. The idea is to promote a positive community and clear the air of the negative history that is held onto by the nearby people.");
            answer.Add("A trend of bloodletting on the local village is causing people to die and spread disease. The people are being convinced by the church leader that they are baing punished for their sins and must continue bloodletting more agressively than before");
            answer.Add("You got a letter asking you to investigate a crime in a nearby friendly grung village. While investigating the crime, you are accused of comminting the crime itself and are taken to grung court.");
            answer.Add("After a strange flash throughout the entire realm, all orts of events in the past have changed. The villan is back, the shopkeeper is someone else, the sun is red. The only one who remembers how it used to be, is you.");
            answer.Add("You found a dire wolf pup, but where is its the mother?\r\n\r\n(The mother is using it as a bait)");
            answer.Add("A frigid cold is coming from the north, making it winter in the middle of the summer. Even the tropical areas of the world have been iced over. Farmers are worried about their yeild.");
            answer.Add("Students fromthe public wizarding school have been attacked randomly by masked spell casters. It is believed they are being attacked by students drom the rival private wizarding school as some form of gambit.");

            //End list content

            //random to select answer from list
            Random rnd = new Random();

            int select = rnd.Next(0, answer.Count);

            quest = answer[select].ToString();
            textBox1.Text = (answer[select].ToString());
        }

        private void New_One_Click(object sender, EventArgs e)
        {
            show_m();
        }

        private void Accept_Quest_Click(object sender, EventArgs e)
        {
            string path = "xml\\my_quests.xml";
            if (!File.Exists(path))
            {
                using (XmlWriter questsxml = XmlWriter.Create(path))
                {
                    questsxml.WriteStartElement("quests");
                    questsxml.WriteElementString("quest", quest);
                    questsxml.WriteEndElement();
                    questsxml.Flush();
                }
            }
            else
            {

                //create new instance of XmlDocument
                XmlDocument doc = new XmlDocument();

                //load from file
                doc.Load(path);

                //create node and add value
                XmlNode node = doc.CreateNode(XmlNodeType.Element, "quest", null);
                node.InnerText = quest;

                //add to elements collection
                doc.DocumentElement.AppendChild(node);

                //save back
                doc.Save(path);
            }
        }
    }
}
