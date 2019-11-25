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
    public partial class RE_Beach : Form
    {
        public RE_Beach()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            List<string> answer = new List<string>();

            //List content

            answer.Add("A bearded and rag-draped man scrabbles in the sand. He’s looking for something he lost there. His mind, he says. It would be very bad for the world if he ever found it.");
            answer.Add("Some inhuman sailors and their half-living vessel, washed into this world by aberrant winds. Will barter for supplies with esoteric navigational instruments and the locations of magical anomalies they’ve found here while searching for their route home.");
            answer.Add("A furrow has been dragged into the sand, leading down the mouth of a cave eroded into a low cliff. The furrow’s sides are stained with blood.");
            answer.Add("A derelict ship picked clean by scavengers human and otherwise. Might still be good for firewood, or shelter lurking vermin.");
            answer.Add("Two tiny armies form ranks in the sand and march into battle: one of red crabs climbing from the sea, another of white crabs from the dunegrass up inland. Even a few crabs are no threat to a human, but enough of them might be. If you ignore them they’ll go about their violent business and eventually one side will emerge victorious. If you aid one side against the other, the victors will reward you with cached spoils. Mostly tide-washed junk, but a handful of lost treasures as well. If you attack both sides they’ll band together to fight you.");
            answer.Add("Mud slurries obscenely here. A water elemental and an earth elemental in a forbidden tryst. They’ll offer a modest bribe to get you to forget what you’ve seen, but plot sudden, stalking violence if you try to haggle or refuse. Don’t trust sand or saltwater after you’ve provoked them.");
            answer.Add("A black-clad widow kneels in the surf and weeps for the love she lost at sea. She’ll pay dearly for word that they may yet live, or a smaller but still respectable amount for gossip and alcohol.");
            answer.Add("A gang of urchins pick at the driftwood for anything that could be sold. They’ll work for a pittance and rob you blind in a blink if the opportunity arrives.");
            answer.Add("Some patches of sand here are sunken and pitted with bubbles. Giant, carnivorous clams lurk beneath these. Watch your step, or you might lose a foot to their clamping shells.");
            answer.Add("A whale, wide-eyed with terror, beaches itself before you. It won’t be long now til it dies. The whale’s pursuer waits in the shallows offshore, waves beating at its fins and spines. If the whale is not returned to the water, it will drag its glistening bulk ashore to retrieve it.");
            answer.Add("A mass of imperishable plastic waste from a gone and forgotten civilization. Maybe worth something to a collector of curiousities or an alchemist.");
            answer.Add("A patch of reeds. The sand around it seems recently disturbed. Underneath, a squad of blue-skinned goblins waits for a chance ambush. Their rattling breaths can be heard from the reeds just over the sound of the breeze.");
            answer.Add("A galley and its crew, resting ashore. They’re looking for slaves to replace the ones who died at sea. They’ll pay for prisoners, as well as tips about vulnerable populations, but may try to capture you if you give an impression of weakness. If released the slaves on the galley will split evenly between those who flee and those who try to kill the crew.");
            answer.Add("A marooned man with salt-cracked lips, escaped from exile on a ramshackle raft. He’s near death and deserved worse than marooning for what he did, but he also knows secrets you’ll want.");
            answer.Add("An explorer from a distant land. She’s curious about the region and will report anything you tell her as truth back to her emperor, and in some months time when the full expeditionary fleet arrives they’ll act off that information.");
            answer.Add("The severed tentacle of a sea monster, still grasping on the dying reactions of its ganglionic brain. It will flop after the closest thing generating vibrations (besides the waves), such as by stepping on the sand, and try to crush it. Hard to take on in a straight fight, easy to trick.");
            answer.Add("Someone’s made an elaborate mandala in the sand. If you can step within it without disturbing its lines, you’ll be blessed with peace of mind and rapid healing while they stay there. The mandala will be wiped away when the tide comes in.");
            answer.Add("Off in the distance you can see an approaching black cloud, a buzzing noise rising as it nears. A swarm of sandflies in ravenous frenzy. Too many to fight. Flee, find shelter, or suffer a death of a million little bites.");
            answer.Add("A flock of sirens competing in a singing contest. Passers-by will be pressed into judging the winner. Losers will be furious.");
            answer.Add("You spot something shiny ahead: the handle of a sword jutting up from the sand. There’s not much left beneath that hasn’t rusted to powder. Inscribed on the blade is part of a poem in a language only scholars still speak, florid in its dedication of the sword to a young prince by their father, the king. The sword’s enchantment is as broken as its blade. Where once its cut carried golden light that ate away at wounds, it now inflicts a contagious, blistering radiance.");
            answer.Add("Assorted fish, bloated with eggs, pulled onto land by the parasites which have now grown larger than the fish’s mouths which once held them. The parasites are here to nest, and will protect their broods with maternal ferocity.");
            answer.Add("Some grumpy merfolk lounge a ways offshore. When they spot you they’ll throw insults and rocks, but will disperse if the situation is escalated beyond that or if you can dish out a better insult than theirs’.");
            answer.Add("Several serrated teeth scattered near a bleached, broken jaw. If thrown on the ground these teeth will sprout into fully-grown humanoid remora warriors loyal to whoever threw the teeth. They’ll quickly suffocate on land.");
            answer.Add("A woman overturns rocks in a panic. In the distance angry shouts can be heard. She’s a selkie fleeing a wealthy merchant husband who forbid her from returning to the ocean, unable to find her skin. The husband has roused a mob to drag her back to their house and children. Not much time’s left before the mob arrives.");
            answer.Add("The sand here is a riot of many hues, stained by wild magic. Magic cast while standing on this sand works chaotically. Sleeping on it brings prophetic nightmares. Eating it is mutagenic. All of these properties are preserved even if the sand’s removed from the beach.");
            answer.Add("A boot sunk in to its ankle. It’s within a wide patch of hard-to-distinguish quicksand blocking the path. The boot is of high quality, but otherwise unremarkable.");
            answer.Add("A lighthouse, the light of which is an uncanny green. Its keeper is more than a little mad, and spends all day gathering fireflies and their grubs. At dusk the keeper places his daily catch in a fine-mesh cage at the lighthouse’s top. Each night the fireflies feed on each other, becoming larger, brighter, and crueler. This will not end happily.");
            answer.Add("A Mexican stand-off between three pirates, a recently-unburied chest full of booty in the middle of them.");
            answer.Add("A worn-away wisp of a dryad, clinging to the driftwood which was once her tree. Will try to commit suicide-by-adventurer by convincing them she’s more dangerous than she is to end her agony. If her bluff is called and she’s shuffled gently off this mortal coil, the dryad’s driftwood splits open to reveal a magic seed.");
            answer.Add("A smuggler in a heavy cloak and a rowboat that seems too rotten to float. Direct light will reveal the smuggler’s true, skeletal face. She discovered a treacherous route out of the underworld then decided to continue the profession she followed in life. The dead smuggler offers goods not found among the living, and attempts to rope you into her schemes.");
            answer.Add("The sand in this section of beach is greyish-red, iron-like, magnetically anomalous. Carrying ferrous metal through it can kick up obscuring clouds and rasping sandstorms.");
            answer.Add("A man in a suit of armour sitting on a stone. Not really a man at all, but a knight-crab (like a hermit crab, but bigger, more dangerous, and uses armour instead of shells to house its vulnerable parts) grown a bit too large for its current home and looking to upgrade. Will mimic human behaviour as well as a clever animal can to lure prey closer before it attacks.");
            answer.Add("An idol of verdigrised bronze half-buried in the sand. Time and water have worn away its features to the point that you can’t tell whether it was supposed to look angelic or demonic.");
            answer.Add("Goblins racing wheels and wagons down the slope of the waterline. They won’t let you pass unless you beat them at their own race. Materials for a vehicle will be provided, including: old planks, nails, an inflated pig skin, and very hard melons. Sabotage of other racers is not only allowed, it’s encouraged.");
            answer.Add("A sea-hag crouches in the water, combing tangles from her hair. She’s self-serving, always hungry, and morbidly humourous, but willing to barter fresh flesh and magical objects for her services and charms. The hag will die if her hair ever dries out.");
            answer.Add("A worn leather case containing a smeared and mildewed scroll bobs in the waves. The scroll contains a random spell, but the damage to the scroll will mess with its activation. Maybe it’ll fizzle out, or affect a different target, or even become more powerful.");
            answer.Add("A rusted machine. Its gears turn so slowly that the movement is nearly imperceptible, its ticking seeming perhaps to be your imagination. It will finally wind down in a matter of hours, and when it does it will explode. With tools (or fingers you don’t mind getting pinched off) the gears can be manually re- or unwound. Immersing the machine in water will delay its detonation indefinitely.");
            answer.Add("A shark-man brute leaps from the water, positioning itself so that dazzling, blinding light shines off the surface at its back and into your face. Tries to intimidate its way to a toll of wealth and rations, fights reluctantly.");
            answer.Add("An unhinged wizard rants and raves against the ocean. He seeks allies against it, and will attack anyone who seems to be in league with it (e.g. by sailing upon it, eating its fish, etc.).");
            answer.Add("Hungry beachworms tunnelling below, bulging the sand above their passage. They can’t dig through solid rock, but are fast enough to overtake a running person. The sand above softens any blows against them except for when they lunge or watch periscope-like for prey.");
            answer.Add("Galumphing kelp-freits wielding enormous shell-and-bone scissors. They work to separate the abominable in-betweens of land and sea: amphibians, sailors, seagulls, and so on, with the edge of their scissors if necessary (it’s most often necessary). The kelp-freits try to set up flanks between themselves, so they can combine their scissors to gruesome amputative effect.");
            answer.Add("A drunken giant building an equally giant sandcastle. It’s dangerously oblivious in its scooping and molding, and if pestered will demand you act out its imaginings of what life in a castle is like with the frightened prisoners the giant’s already captured.");
            answer.Add("A big, stoic sandstone face carved into the side of a hill. It will open its mouth to the treasure stashed within only for the person it was carved to resemble. The enchantment on it is rather crude, so a mask painted to look like it, its reflection in a mirror, and the like would all be sufficient to fool the face into opening. Dynamite will also open the face, but risks damaging the treasure within.");
            answer.Add("A discarded coffer full of cursed silver coins. If carried they’ll tarnish any other precious metals you touch, and will return to your possession the night after you spend them. They’ll appear in your mouth if you’ve got no bags or pockets for them.");
            answer.Add("A group of young nobles play polo as their bodyguards watch on. They’re growing bored with their game and eager for new amusements. They nobles unfamiliar with the possibility of their actions having negative consequences. Together their horses and jewelry are worth a small fortune to a discreet buyer who wouldn’t sell you out to the nobles’ parents.");
            answer.Add("A decrepit yacht drifting down the shore. Its undead passengers believe themselves to still be alive and at an upscale party, dancing and drinking from dusty glasses. They’ll get violent if anything disturbs this illusion, and start off assuming any unfamiliar faces are servants. Some durable valuables are still onboard.");
            answer.Add("A storm tears through the area, coming and going in maelstromous moments. Soon after the storm passes, a party of fairies riding albatrosses swoop down and ask which direction their quarry went. If told honestly you’ll wake up some days later with a bottle of lightning by your head. If they’re lied to you’ll find yourself caught in a deluge every time you try to sleep outside for the next month.");
            answer.Add("A spattering of holes and the goblins digging them. They’ve got a waterlogged treasure map, the ink too smudged to read clearly, and are digging all over the approximate area of where “X” marked the spot.");
            answer.Add("A collection of jars, some shattered, some whole, all caught in some muck. Within them is some goo. Drinking the goo inflicts a piscine mutation: gills, bulging eyes, legs fused into fins, skin turned to scales, and so on. Each jar’s goo inflicts a single mutation.");
            answer.Add("An estuary where crocodiles lurk.");
            answer.Add("A basket bobbing in the sea foam. Within is a wailing baby, several items of golden jewelry, and a note. The note explains that the baby is the youngest son of a king, sent downriver to escape the murderous attention of the crown prince. It further implores its reader to raise the baby well, take the jewelry as payment (though leaving one piece as a keepsake), and some day tell them of their royal heritage and duty to overthrow their tyrannous sibling.");
            answer.Add("An impromptu bazaar halfway in the water. Merchants from land and sea have gathered here to trade goods only found in their respective environs.");
            answer.Add("A holy oil spill shimmering on top of the water. It’ll still be potent if bottled. In the center of the spill a ghoul shivers atop a raft and cries for help.");
            answer.Add("A crate of wax-sealed amphora full of wine that’s soured to vinegar. One of the amphora, painted with sharks instead of dolphins, is packed with cocaine or something similar.");
            answer.Add("The way down the beach here is craggy, with rough waters slamming rougher rocks hemming in one side and a sheer cliff the other. The crags ahead are home to giant barnacles, glued in place but able to lash out at intruders with their tremendous penises.");
            answer.Add("Some fishermen gambling around a barbecue pit.");
            answer.Add("The sand here is full of sharp shards of rock and glass, cutting feet like caltrops if walked on. Goblins on stilts with bows and pikes are patrolling the area.");
            answer.Add("Coral mounds dot this place and strange fish swim through the air. This is the ghost of an ancient reef now on land by the long movement of geology, lost in the memory of life. The ghostly animals behave as they would while alive, including attacking when hungry or provoked.");
            answer.Add("Someone’s drowning, caught in a riptide. If rescued they’ll be grateful, but don’t have much to offer besides their service.");
            answer.Add("A friendly horse trots up the beach to you. It’s a kelpie in disguise. If touched you’ll stick to it and it’ll gallop into the water.");
            answer.Add("A floating dock that trails out to a prime fishing spot.");
            answer.Add("A fresh shipwreck. There’s a three-way argument between some human scavengers, goblins, and fish-men as to how to split the spoils. They haven’t come to blows yet, but they’re close.");
            answer.Add("A desiccated ocean chimera (eel for a tail, heads from a turtle, a pufferfish, and a seahorse, body like all four mashed together, breathes gouts of inky venom) placed above the high tide line. Contact with water will restore it instantly to lively hostility.");
            answer.Add("A dire cormorant snacking on a splatter of dead fish washed ashore by a swell. Protective of its food but otherwise placid. Tameable.");
            answer.Add("A party of adventurers like yourself, all naked and quite deranged from sun exposure and drinking seawater. If kept calm will tell confusing fragments of how they arrived at their current state.");
            answer.Add("Colourful, frilly seaslug-men crowd around you and probe with soft appendages, babbling all the while. They’re tourists from the undersea realms. Curious about you, but unable to speak your language, and assume their gesticulations are more comprehensible than they are. At the first sign of violence they’ll vomit their guts out and crawl over each other to get back in the ocean.");
            answer.Add("A sea stack engraved with abstract images. On moonless nights a coven of witches convenes to dance atop it with an octopoid demon, the master they’re sworn to.");
            answer.Add("A salt evaporation pond. People from a nearby village sing work songs as they dredge the salt.");
            answer.Add("An abandoned, algae-encrusted net. Entangled in it is a fish-bitten revenant on a quest to avenge its own murder, stymied by the fact that its hands and tongue have been eaten off.");
            answer.Add("Gems ground to dust have been mixed into the sand here, glittering in ruby and sapphire hues. It’d be valuable but time consuming to sift it out here, but this risks attracting the attention of wandering monsters. The mixed sand could be packed up to be sifted elsewhere, but the ratio of sand-to-gem-dust could make it prohibitively heavy.");
            answer.Add("A lifelike, gently smiling statue carved from salt, up to its knees in the sand. Those within the statue’s field of view (if its eyes could see) receive a penalty to their ability to resist outside influences on their mind.");
           
            //End list content

            //random to select answer from list
            Random rnd = new Random();

            int select = rnd.Next(0, answer.Count);

            textBox1.Text = (answer[select].ToString());
        }
    }
}
