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
    public partial class I_Magical : Form
    {
        public I_Magical()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            show_m();
        }

        public void show_m()
        {
            List<string> answer = new List<string>();

            //List content

            answer.Add("A frying pan and lid that materializes one fully cooked breakfast platter for one once per day when exposed to flame. Someone’s mother had it enchanted as a gift for their child who was leaving home so that they could always have a home cooked breakfast.");
            answer.Add("A pair of green rimmed spectacles that translates elvish text into common while wearing them. An elf made them so that he and his adopted daughter could read some elvish adventure tomes that he brought home together.");
            answer.Add("A levitating quill that writes out whatever the last person who touched it wants, given that it has enough ink and parchment. Someone’s son had it commissioned after his novelist father lost feeling in both of his hands after a wall collapsed on him.");
            answer.Add("A hooded cloak made of various patches of leather that has a belt fasten to the front. It generates heat on the wearer if blown upon by wind. It was made as gift for a lover so that they could travel the mountain ranges without worry of freezing.");
            answer.Add("A pair of small blank scrolls with matching handles. Whatever you write/draw on one scroll (in ink) appears on the other within 3 minutes. 24 hours after ink touches the blank page, everything written on it melts away permanently. Made by two young Divination apprentices who wanted to keep in touch with each other.");
            answer.Add("A small leather vest enchanted to magically float when exposed to water. Commissioned by a noble after his daughter almost drowned in the estate fish pond.");
            answer.Add("Two rings with a small ruby set in each. When pressed, the emerald makes the other ring warm up slightly. Crafted by a travelling jeweler so she could communicate to her lover when she was thinking of him.");
            answer.Add("A leather collar with a small metal emblem of a star on it. A matched bracelet with the same emblem. A person wearing the bracelet can make a small light hover 50 feet above the collar. A wife commissioned this collar after her husband, a retired soldier with significant PTSD, lost the dog that he had bonded with.");
            answer.Add("A soft, well made blanket that can, once per long rest, emit a soft glow, maintained by concentration. The blanket was crafted by an enchanter after his young son confided he was afraid of the dark to help his son get to sleep.");
            answer.Add("A hand knitted hat that will keep the wearer cool when it’s hot and warm when it’s cold. Commissioned for a man who had no hair by his sister.");
            answer.Add("A music box pendant, that, when wound and played, emits a somber, soothing song, like one sung by a long-dead but much-loved parent to their child. While the song plays, other sound around the wearer is muffled, and the user cannot be frightened.");
            answer.Add("A small brass claw, meant to be set on a desk and have a gemstone inserted into its top. It gives a small, hologram-like view of an elemental plane, changing which plane is displayed by changing the gemstone. It seems to have been a gift from a noble to his child, as such craftsmanship would be quite expensive.");
            answer.Add("A medallion that, when focused on, always displays a faint blue line, curving around trees or arching over rocks. It will always show the fastest way home, but not the easiest, a flawed enchantment made by a well-meaning wife for her husband, so that he could always find his way back to her.");
            answer.Add("An enchanted censer that was made by a daughter for her father, who was suffering from PTSD following the battle that robbed him of his arm. No matter what incense is burned in the censer, it gives advantage on wisdom saving throws.");
            answer.Add("A set of bracelets that when one is broken the other immediately breaks as well. When one is mended, the other mends itself. Created by a brother who was going off to war, for his younger brother staying home. This was so the older brother would know if things got bad at home. If the bracelet snapped, he promised to come home no matter what.");
            answer.Add("A simple wooden cup that warms and cools liquids to make them taste better. Water is pleasantly cool, ale is near freezing, coffee and tea are heated to the user’s preference. Created by a travelling wizard for a young woman in a small village who he had fallen for, when he overheard her mention her disappointment that her tea had gotten cold.");
            answer.Add("A small wood carving knife that loses it’s edge as long as the blade touches the wielder’s skin. Does not need to be sharpened. Made for a craftsman’s son who had a tendency to nick himself while whitiling.");
            answer.Add("A pair of overalls that have a mild levitation charm imbued into them, will float off like a balloon if left unabated. Made for a retired soldier by his superior officer to alleviate pain to his knees whenever he put weight on them.");
            answer.Add("A bedroll that creates a mild water repellent barrier around it as long as someone is laying on it. A gift made for a traveling merchant so that he wouldn’t worry about sleeping in the rain.");
            answer.Add("A copper horn that allows the user have advantage to perception rolls based on hearing when used. Made for an aging grandmother so that she could hear her grand kids better.");
            answer.Add("An ornamental birdcage containing an exceptionally realistic stuffed bird. While uncovered, the “bird” softly twitters beautiful melodies. Created by a bird-loving artificer for a family of wealthy aristocrats. Though the birdcage has been in the family for over a generation, none of the family members have noticed that the bird itself is fake.");
            answer.Add("A brass spoon that neutralizes any harmful toxin within a liquid one spoonful at a time. Made for a Duke’s son after he received a death threat via mail.");
            answer.Add("A pair of gloves that softly hums different notes based on the type of metal they touch (mostly used for coins). Made for a merchant that went blind so that he wouldn’t be swindled.");
            answer.Add("A brass gauntlet that glows a different color depending on what time of day it is (Blue for night, yellow for day, Green for dawn, Purple for dusk). Made for a coal miner by his boss so that he would when he could go home.");
            answer.Add("A red scarf sewn with silver beads into the fabric, magically filters air that is sucked through it when worn as a face wrap. Made as a gift for an obsidian miner to avoid complications with volcano fumes.");
            answer.Add("A small hammer that will drive in any nail strait in. Commissioned for a carpenter by his children when his hands started shaking in old age.");
            answer.Add("A small rubber ball that would roll to the nearest dog or wolf within 50ft of it. Made for a man whose dog went blind and wanted to continue to play with it.");
            answer.Add("A fishing pole with a bobber that looks like a human eye. When using the pole one can look through the bobber and watch the hook and bait to see when the fish bites. Given to an old soldier as a retirement gift.");
            answer.Add("A fashionable and large hat that cloaks the user in shadow. Made as a wedding gift to a drow bride moving to the surface.");
            answer.Add("A feathered cap whose feather is a quill that can write 5 pages of notes. The feather disappears after an hour and a new feather grows from the cap. Made by a wizard for his forgetful apprentice who would always lose or forget his pen.");
            answer.Add("A comb that when combed through hair braids it into an fashionable design. Commissioned for a dwarf who wanted his beard to look stylish.");
            answer.Add("A small silver cat bell that, once night falls, causes the death of 2d6 vermin in the house the bell is kept in. Manifested itself after the well loved cat of a farm died. Every now and then, the bell will softly chime and manifest a haunt such as; the feeling of fur rubbing on your leg, a cat’s tongue licking your fingers, the sound of contented purring filling everyone’s ears and the occasional decoration knocked off it’s shelf.");
            answer.Add("Sun-filled mirror-catch box, it has enough sunlight to fill a room with bright light. Built by a retired adventuring dwarf and filled by passing adventurers. Not every denizen of the underdark has the means or bravery to leave the underground but they still hold curiosity over the sun and it’s light, some come from miles underground to view this dwarf’s curio.");
            answer.Add("A large conch shell that, when put to the ear, makes the wielder hear the sounds of the ocean. If you close your eyes while doing so, you’ll see visions of infinite horizons and calming ocean waves. A gift from a pirate lord to his estranged, landlocked son to give him at least a glance as to why he left.");
            answer.Add("A small mobile showing a scene of sheep hopping over a fence that, when hung, all around it will find it easier to enter restful sleep and ignore less dangerous interruptions. The first successful craft by an apprentice Artificer for his insomniac mentor.");
            answer.Add("A leather Tabard made of orc skin that allows those who wear it to be able to use rage once per day. Legends tell of the friendship between an elf ranger and an orc barbarian, whose tribe had strange funerary rites. When the orc was struck down, with his final words, he requested that he’d be turned into a tabard so he could protect his friend once more.");
            answer.Add("3 shot glasses with markings on the side, when all the glasses are empty, any alcohol poured into one glass fills the other two as well. The markings on the glass move to indicator the level of the other two glasses. A creation of an artificer dwarf for his two brothers as the sought out life beyond the mines. Funny enough, doesn’t work when [insert hated alcohol] is poured in it.");
            answer.Add("A pair of ornate chessboards with pieces made of ivory. The pieces are enchanted to move via vocal commands and any move on one board is mirrored on the other. The possession of a prince and princess of two opposite, warring states.");
            answer.Add("A frilly parasol that emits a small cone of magical darkness when opened. The gift of a nobleman for his vampire wife.");
            answer.Add("A yarn doll that has an embedded communication spell. Made by a wizard father for his daughter so that he could talk to her while he traveled. The companion object is a locket with a cut of hair and a portrait in it.");
            answer.Add("A finely crafted handheld mirror made out of ivory, glass, and silver. Small runes are inscribed into the back, and words in a forgotten tongue glow softly around the handle. Whoever looks into the mirror will see themselves reflected, but in the background will be what the individual knows in his/her/its mind as home. In the presence of the mirror, all illusions fade, and all invisible creatures are revealed by glowing outlines. It was originally made by a wanderer who had recently returned home from a long journey to a strange land.");
            answer.Add("A leather lined steel helmet with a pair of matching elvish insignia on either side of it. When someone puts both hands on the insignias and speak into the helm, it will magically record what was said and play it back for whoever is wearing it when they touch one of the insignia. Given to a soldier who tended to forget his orders on long trips.");
            answer.Add("A fishing net that will repair itself of any tears 12 hours after they happen. Commissioned as a retirement gift for a small town politician.");
            answer.Add("A custom made sand paper block that has a dial on the back that adjusts the grain size of the paper without having to physically change it out. Commissioned by a wood worker as a gift to his son and his up and coming buisness.");
            answer.Add("Tall leather boots that are highly resistant to piercing damage. Made for a hunter who tended to forget where he laid his bear traps.");
            answer.Add("A knife and fork set made from Mithril with small runes embed in the handles. When the fork is inserted into food (non-living material) it allows the knife to cut through it with little to no resistance. Made as a gift from a wife to her husband so that he wouldn’t waste time sawing through her cooking like a log.");
            answer.Add("A sand timer that takes vocal commands and can makes various chime noises. Made for a weapons smith to better keep track of how long something is in the kiln.");
            answer.Add("A wooden top that will keep spinning as long as someone is looking at it. Made to teach concentration to a young boy who had problems focusing on one thing at a time.");
            answer.Add("A stein that removes the alcoholic content of any drink poured into it without affecting the taste. Made by a cleric to help drunkards quit the drink.");
            answer.Add("A wide leather belt that can project the illusion that the wearer is much fatter than they actually are. Commissioned by a couple of draft dodging neer-do-wells who thought they could avoid the service by looking as unhealthy as possible.");
            answer.Add("An earring that telepathically describes whatever is visible in front of the wearer. Made by a child prodigy for their blind mother who worked tirelessly in order to pay for their magical education.");
            answer.Add("Philip's Sword - This wooden sword was carved from an ancient treant as a birthday gift for a young prince. It acts as a +1 shortsword with 3 daily charges that can be used to cast the entangle spell.");
            answer.Add("Infinite Chiken - A chicken that can be decapitaded and cooked to feed 5 medium size creatures. A new body regenerates from the chicken head, which remains alive after decapitation, within 1d10 hours.");
            answer.Add("A wooden shield encased in iron bands. Speaking the shield's command word causes it to magically transform into a shield guardian for 1 minute. The shield can be used in this way once per day.");
            answer.Add("An animated wooden horse that can be broken down and reassembled into a hand-drawn cart. While in horse form, up to 5 packs and 1 small chest can be stored in the construct's chest cavity.");
            answer.Add("Ghost costume - A simple white silk sheet with eye holes cut into it, which is somehow able to fool people into believing they've encountered a ghostly apparition.\r\nAn adventurer that equips the ghost costume is granted 3 charges of the ability 'BOO!', which resets each dawn. As an action, the so-called ghost makes a performance check contested against a single target wisdom check.\r\nIf the result is equal to or greater than the target's roll, they take 1d6 phychic damage and become frightened.");
            answer.Add("Eldritch Blaster:\r\n\r\n- One handed ranged weapon\r\n\r\n- 120ft range\r\n\r\n- Deals 1d10 force damage\r\n\r\n- Whispers weird stuff to ou while you sleep");

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
