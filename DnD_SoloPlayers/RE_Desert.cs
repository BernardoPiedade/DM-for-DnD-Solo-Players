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
    public partial class RE_Desert : Form
    {
        public RE_Desert()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            List<string> answer = new List<string>();

            //Start List Content

            answer.Add("A carved stone pillar is poking out of the sand dunes. The markings on the pillar are not in the local language.");
            answer.Add("A beautiful oasis, with people and green palms surrounding a huge pool of cool water. The tempting scene lacks clear borders, is this real or could this be a mirage? And is there something more sinister behind this idyllic place?");
            answer.Add("The party comes up to a small garden of cacti and succulents being cared for by a dessert Druid. She doesn’t get company often and will have conversations with the plants. She’ll offer the party some cactus juice. Anyone who drinks it and fails a saving throw will trip out for a couple hours.");
            answer.Add("A sandstorm forces the party to take shelter, they hear voices screaming in the wind.");
            answer.Add("A bell chimes. Only those failing a Wisdom saving throw hear it, but they are compelled to seek it out.");
            answer.Add("The side of a huge dune the party are walking along the side of for shade falls down, risking burying the party.");
            answer.Add("The party comes across a group of nomads. They are bandits but offer the party their hospitality for three days, at which point they will decide how best to rob the party.");
            answer.Add("A single purple flower in the desert sands. If checked for magic it radiates a low aura of alteration magic which dissipates if picked.");
            answer.Add("Sand clouds begin to resolve to a wind rigged skiff, then to a group of elves in pursuit.");
            answer.Add("Rain begins to fall, tendrils reach up all around you and flower within seconds, releasing a beautiful scent. Constitution save to remain conscious and start to remove yourself from the flowering field.");
            answer.Add("The party finds a construction made of junk: a small citadel, home to friendly scavengers, who offer to aid the players, and provide some hospitality. Should they accept it, a sandstorm occurs, and the citadel is attacked by crazy raiders on horses. A lovely day.");
            answer.Add("The party comes across a couple rocks, arranged in a circle. In the center, there is a precious gem. If they take it, the rocks start to rise up, and slightly curve inwards as they do, threatening to trap and suffocate whoever doesn’t escape. It takes a CR 25 STR check (aka someone needs to have +5 STR) to break the sandstone.");
            answer.Add("There is an area with several small cracks on the floor. The party must go through it to get to their destination, but every turn they spend in there, 2d6 hostile scorpions emerge from the ground.");
            answer.Add("The party is greeted by camel merchants. The animals are docile and follow simple orders, costing 50 gold each.");
            answer.Add("Each player has to make a CR 17 Perception save. On a fail, they see a large lake, with crystal clear waters, surrounded by a couple meters of vegetation. It’s all a mirage, though, and the lake is actually quicksand.");
            answer.Add("The party crests a dune to see a field of bones stretching for hundreds of yards. A DC 20 perception check reveals thousands of red ants swarming the skeletons.");
            answer.Add("A hungry lioness can be seen peeking over the top of the next sand dune. The rest of her pride is lying further down, in wait, ready to sprint around to encircle the party and cut off points of escape.");
            answer.Add("The party hears a sound somewhere in between slithering, scraping, and the rush of an object through the air. As they crest the next sand dune, they see a gigantic sand worm rushing past, oblivious to their presence.");
            answer.Add("The party hears the sound of war drums, seemingly very close. It’s actually the drum sand that it turns out they were walking on.");
            answer.Add("A rather sad flumph is seen floating about the desert. If it asks for help, it states that it wandered too far away from its cave home, and is now lost. Once the party finds any kind of cave entrance, the flumph will thank them and will return to its subterranean life.");
            answer.Add("A crashed and stripped airship from a battle long ago. A group of scorpions have claimed the remains for the shade.");
            answer.Add("A broken sand skiff abandoned by the native lizardfolk nomads. They left behind 3 glass lenses to start fires, two spears, and half a barrel of water.");
            answer.Add("A pack of hyena can be seen chasing a wounded lioness. She runs to the party in desperation.");
            answer.Add("The dried and sun bleached bones of a dragon are being worshipped by a group of dragonborn. They are willing to trade as long as you are respectful.");
            answer.Add("A bottled djinn is found in the skeletal remains of a human nomad and his pet monkey.");
            answer.Add("The party comes across a caravan of several camels carrying all kinds of goods, food and treasures, but there’s no one leading them. If the camels are stopped or the party tries to touch the goods, a group of humanoids with bodies made out of sand emerges from the dunes.");
            answer.Add("You come upon a cave in a dry lakebed. Ten preserved tritons in caked mud stasis are preserved inside from when this arid land once had water.");
            answer.Add("You meet a two Ogres that refer to themselves as ‘Border Patrol’. They can be easily bribed and the party can easily sneak by later.");
            answer.Add("You meet a group of 30 refugees lost and thirsty in the desert. The law of the nearby city forbids you from giving them water.");
            answer.Add("A mad gnome is farming peppers and cactus out in the desert. She sells pepper bombs that do 1d4 damage and has a 50% chance to blind. The pickled pepper jam is also delicious.");
            answer.Add("You come across a series of large tents with a bonfire in the middle. Large, camel-drawn cages and guards adorn the area. You’ve come across a slave auction.");
            answer.Add("The party comes across an old abandoned Legionnaire fort with scratch marks all around it. Pushing open the door reveals hundreds of dried out human corpses and bones. The well still has clean water miraculously enough.");
            answer.Add("A lizardfolk jumps out of the sand drawing his blade. ‘Leave your possessions if you don’t want to taste my blade! My knife is coated in deadly poison.’ he taunts as he draws his forked tongue over the blade to intimidate you. One dumb moment later, his eyes widen as he realizes his mistake.");
            answer.Add("On there journey through the desert, the party encounters a group of raiders traveling back from the their last raid at a nearby Temple.");
            answer.Add("The party discoveries a strange tree in the desert surrounded by a small pond.");
            answer.Add("The party encounters a small group of followers from a near by village that follows the rays of the sun god.");
            answer.Add("In the middle of the desert the party finds a colossal tower that has been built into the rock bed beneath the sand. Once the party explores the tower, they find an updated map of the desert as well as a uncommon magical item.");
            answer.Add("A scorpion that communicates telepathically. You learn that it was once a halfling warlock who betrayed his patron for a gallon of water and was transformed. He asks you to help him break the curse.");
            answer.Add("A solar eclipse reveals a nearby temple that is invisible in sunlight. If players are inside the temple when the eclipse ends they will be unable to leave the same way they came in.");
            answer.Add("The group discovers the petrified roots of an ancient tree spanning 1/2 mi2 at the surface. Well cut slices of the roots are highly prized and incredibly valuable. Chunks and chips are worth next to nothing. Making these slices requires specialized equipment or magic.");
            answer.Add("You discover a small oasis. Drinking the water will cause all the hair on the characters body to fall off.");
            answer.Add("A good old-fashioned sandstorm. Lasts 2d4 hours. Party must make a CR 10 WIS save each hour or become hopelessly lost.");
            answer.Add("A circle of vultures feast on a dead baby elephant. It appears to have died of natural causes.");
            answer.Add("Fire spouts shoot out of the sand randomly dealing 1d4 fire damage to the party.");
            answer.Add("You see a beautiful woman dancing across the sand. She’s singing to herself and motions for the party to come dance with her. As soon as she’s touched she collapses into sand and a slight giggle is heard on the wind.");
            answer.Add("The party encounters two barrels of water. One is a mimic.");
            answer.Add("A sand covered rock formation is actually a slumbering Earth Elemental. Be quiet.");
            answer.Add("Ribs of an ancient boat. Nomads use it for shelter, and casks of old water are hidden half buried in the sand.");
            answer.Add("You find a large male human barbarian named ‘The Scorpion King.’ He has four pet scorpions.");
            answer.Add("Four sand dwarves pop out of the sand in ambush. They thought you were raiders. They have dried, spiced meat to trade.");
            answer.Add("The party comes across a sand filled Warforged. Cleaning it out results in it coming to life and becoming your body guard.");
            answer.Add("You come across a wet patch of sand that smells like cinnamon. Harvesting the spicy smelling sand nets you 50 gp per pound at the next populated area.");
            answer.Add("A buzzard Aarakocra begins to follow the party. Yelling ‘Hurry up!I’m starving over here!’");
            answer.Add("Three nomad chariots surround the party. Just when things look grim one of them calls off the attack. As they ride off into the dunes he yells, ‘Now we’re even!’ The party has no idea what they did to deserve it.");
            answer.Add("The party sees in the distance a strange looking large boulder. When/if they approach, the can appreciate a huge sculpted hand, either made out of stone or jade or any other material. It may have enemies nesting on it, or traps around it. ");
            answer.Add("Sinking sand that requires a perception check to spot, dex and strength saving throw to get out of.");
            answer.Add("An oasis rigged with magical traps. There are flowers and plants that investigating with nature checks seem to be good picks for herbalism or eating. They might be, but picking them triggers a fire ball or poison gas trap from the base of the stalk.");
            answer.Add("A sudden pit of sand, cone shaped, that takes a dex check to avoid falling into, or repeated dex checks to get out of. As they struggle to the top, the giant wolf spider at the bottom throws sand, at players, giving them disadvantage on all dex checks.");
            answer.Add("A pack of 3d4 scavenging gnolls rummages about some old metal.");
            answer.Add("A mummy has awakened beneath the ground. Dead plants and desiccated animal corpses litter the area. Odd whispers float on the wind. Anyone sleeping here will be disturbed by vague and dark dreams of something calling…");
            answer.Add("A trio of commoners standing on large rocks beckon you over frantically. In the area lurks an injured bulette, waiting for them to come down.");
            answer.Add("You walk upon a battle, as a force of 4d4 ostrich-riding kobolds harries a smaller amount of goblins.");
            answer.Add("A massive tortoise, 30ft tall, walks the land, with what looks like scaffolding upon it’s shell. Atop, a small camp with notes and food, welcoming visitors and encouraging them to leave something for the next ones.");
            answer.Add("A small hut lies in the distance, next to a large cavern in the ground, chambers and tunnels connecting them. A pair of burnt skeletons lie at the entrance.");
            answer.Add("At a grove of reddish sand, odd trees and a white flag, a nestle of tentacles wave in the earth. If approached, a xorn rises and offers to trade meat and water for gems and metal.");
            answer.Add("A tavern sits in a conspicuously unappealing location. The inhabitants are terrified and confused, because hours before they and the building were both in the center of Silverydeep. There’s food enough, but they talk of finding safety.");
            answer.Add("A couple of black pools besmirch a valley. Rolling 1d4, the pools are made of tar, oil, onyx or black puddings.");
            answer.Add("A small delegation approaches you, informing you that intrude upon lands owned a local lord, and to leave, be arrested or brought forth to appeal. The lord in question is a black half-dragon, quite cruel and offering work for leniency.");
            answer.Add("A male fire Genasi and two winged female Tieflings are seen attacking two giant tarantulas. They won’t survive the battle without your intervention. In thanks they give you an amulet of fire resistance before they collect the tarantula’s venom and disappear through a portal back to Hell.");
            answer.Add("A caravan of silk traders run into you and offer to hire you to supplement their guards. You’re headed in that direction anyway");
            answer.Add("The party stumbles into the 40 foot funnel of a giant ant lion larvae. It grapples the first PC that comes into its grasp. Dealing 30 damage forces it back into a tunnel to hide. Treasure can be found near the surface where it spit out the inedible pieces.");
            answer.Add("The party finds an old abandoned caravan that was once attacked by raiders. Arrows, silks, weapons, armor, and preserved spices can be salvaged.");
            answer.Add("You find a zombie bound by chains, wards, and radiant magics in an ominous cave. The gem in his chest is a prison for a powerful demon. He offers you empty promises to free him. Four scrolls and a spell book can be found by looking around.");
            answer.Add("A beggar and a princess can be seen on a flying carpet off in the distance.");
            answer.Add("A lightning strike near the party facilitates blue crystals shooting out of the sand. They do 1d4 piercing damage if growing through a living thing. The shards constantly glow and make good light sources at night.");

            //End list content

            //random to select answer from list
            Random rnd = new Random();

            int select = rnd.Next(0, answer.Count);

            textBox1.Text = (answer[select].ToString());
        }
    }
}
