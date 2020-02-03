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
    public partial class I_BlackMarket : Form
    {
        public I_BlackMarket()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            show_m();
        }

        public void show_m()
        {
            List<string> answer = new List<string>();

            //List content

            answer.Add("A book full of strange markings said to have been taken from the dead head of a cult. In reality, it was a book scribbled in by a toddler.");
            answer.Add("The Left Hand of Maaug – A large gauntlet covered in blades. It weighs a good 25 lbs., and as such is all but impossible to wear.");
            answer.Add("The Bell of Beloved Fortune- Said to bring true love- to your best friends- when rung. Does not actually provide any romantic benefit to the owner.");
            answer.Add("Seventeen Key Ring- Each key has a 5% chance of opening a lock you find. Once a key has opened something, it will not fit any other lock.");
            answer.Add("The Loud Coin- This grimy copper coin, when thrown on the ground, loudly comments on everything within 60 feet of it in Common, giving an accurate (if unflattering) description of the room and all its occupants.");
            answer.Add("Periapt of Porcine Attraction – This amulet makes the wearer adorable to pigs, boars, and similar beasts. The animals will not harm the wearer, nor are they romantically interested; instead, they simply cuddle up to the wearer and stare at them lovingly.");
            answer.Add("Clod the Unburning – A large, roughly hewn table with “CLOD WUZ HERE” carved into one corner. The table is absolutely and utterly fireproof; even on the elemental plane of fire, it feels cool and firm. It’s also a heavy table.");
            answer.Add("A six-pack of potions tied together. A note on one of the potions reads “This One Isn’t Poisoned!” The note magically moves between bottles when unexamined. The potions refill every evening at dusk.");
            answer.Add("A wand that can give a wish at who ever is targeted but it got mixed up with 20 other wands some possibly deadly.");
            answer.Add("Illegal alcoholic beverages spiked with Illithid blood. It is said to have a strong hallucinogen effect when consumed. ");
            answer.Add("Poisons derived from Beholder eyes, claimed to have the effects of the eyes they were brewed with.");
            answer.Add("An unstable weapon, crafted from fusing multiple enchanted items together. The weapon is a powerful item, but has a 1d8 chance of shattering with a random spell effect cast upon the wielder (AOE spells affect wielder and all friendly/hostiles in range)");
            answer.Add("Pocket (dimension) sand – a small bag of sand that is enchanted to open a doorway to a pocket dimension. To use, scatter the sand on a surface of your choosing, and utter the command word (shashasha!). A doorway equal to the space the sand covers (no greater than 10×10 feet) opens for 1d6 minutes. The sand falls into the pocket dimension on use and is consumed. There is enough sand to cover a 10×10 foot space, or 4 separate 5×5 foot spaces. If used multiple times, each doorway leads to the same pocket dimension.");
            answer.Add("8 stones in a small leather pouch. Red, orange, yellow, green, blue, indigo, violet, black. Each casts a spell at its base level. The stones have qualities which show the amount of times they can be used, ‘perfect’ =3 uses, ‘crazed’ =2 uses, ‘cracked’ =1 use. Once the final use is expended the stone shatters into fine dust. To use a stone, throw it at the target. (Red (crazed), fireball; Orange (perfect), cone of truth; Yellow (perfect), daylight; Green (perfect), plant growth; Blue (perfect), create/destroy water; Indigo (crazed), command; Violet (cracked), animate dead; Black (cracked), power word annihilate)");
            answer.Add("A dwarven heart on ice. Great for health potions!");
            answer.Add("Griffin Eggs for high class dining. They’ll leave you full all day.");
            answer.Add("Ancient Forgotten Currency – valuable collectible coins thought to be lost to the ages for a millennia. On sale today only!");
            answer.Add("A trained Quasit or Imp in a small cage.");
            answer.Add("A vial of brass dragon’s blood – Blood, still warm, taken and preserved the moment it was slain. Those who consume are said to be able to detect lies Cast Zone of Truth once. The user is marked by the magic effects, and gains a mark on their skin.");
            answer.Add("Diamond Blade (+1) – A blade made of diamonds. The tang of the blade is silver, its pommel diamond as well. It reflects and refracts light and magic mysteriously. If on an attack if you were to add acid, cold, fire, lightning, poison, thunder, necrotic or radiant damage to your weapon damage dice, roll a 1d8, that added weapon damage dice type is changed to (1- Acid, 2- Cold, 3- Fire, 4- Lightning, 5- Poison, 6- Thunder, 7 – necrotic, 8- radiant).");
            answer.Add("Sphere of Great Divination – A black obsidian crystal sphere filled with a dark inky fluid. Inside the sphere is a small white dodecahedron with black text on each of its faces. The sphere gives off a faint divination aura. As an Action, it may be shaken and the resulting text on the dodecahedron may be read as it floats to the top of the sphere. Treat as the spell “Augury”, but may only be used once per day, and has a 1d4 chance on use to give a random result or one the DM chooses.");
            answer.Add("An advanced innovation in the new field of gunsmithing- the Apache Revolver. Treat as a revolver (if you’re using 5e, the rules are on page 268 of the Dungeon Master’s Guide) with a built-in knife and brass knuckles. Probably not called the ‘Apache’ revolver unless that’s a place in your setting. And yes, it’s not a very practical weapon, but it seems to be selling fast.");
            answer.Add("An unremarkable-looking prayer candle. A precise wax-shaping technique has been used to hide magic sigils inside the body of the candle, such that when the wick is burnt it generates a field from which no sound can escape in a 12-ft radius. The candle burns out faster than normal, though, usually in about 10 minutes. It’ll simply look like you and whoever else you’re meeting with are praying silently, provided you aren’t gesticulating at each other.");
            answer.Add("A phial of aboleth mucus.");
            answer.Add("A small ivory replica of a king’s crown. Its owner is able to participate in fractal chess, a version of the popular board game with no set number of players and an incomprehensibly large playing board. Players can communicate with each other, regardless of physical or planar distance, but can only do so when they make a turn, so messages by way of fractal chess are slow. There is only a single game going on, which started with its invention. There hasn’t been a winner for thousands of years, but there are plenty of losers.");
            answer.Add("A petrified toad. When held in the cusp of one’s palm for a minute, the toad’s body warms up and comes back to life. Whoever did so can command it to go to a location and stay there for up to 12 hours. Afterwards, it attempts to travel back to its user. The user cups the toad again for a minute until it petrifies, and they gain access to the toad’s recent memories.");
            answer.Add("A portable peephole fashioned like a circle of steel, about half as large as a human fist. The corrugated end is placed to the surface of a solid object, then rotated clockwise, causing it to sink into the surface. This creates a purely visual hole (it’s a visual illusion, rather than an actual aperture) all the way through to the other end of the object. To remove, one would grasp the blunted tines on the outward-facing end and rotate counter-clockwise.");
            answer.Add("The services of a band of mercenary orcs.");
            answer.Add("Prankster’s gold, a liquid that turns into 100gp in recently minted gold coins for 24 hours after being poured out of the vial, before turning into an odorless gas. The vials are sold both individually and in bulk, and in different sizes. Understandably no one in this marketplace accepts gold coins as a form of tender.");
            answer.Add("A mirror or lens that can be used to see invisible things but has horrible glare when exposed to most light sources.");
            answer.Add("Counterfeits of prestigious wines, spirits, cheeses, and the like. Well, surely they’re counterfeits- otherwise there wouldn’t be so much, sold at such discount prices.");
            answer.Add("A ‘Calinic breed’ cat. Striped purplish, it can sense poison, and prefers to eat poisoned food, even if it is full. Luckily the cat seems to be immune to poisons, toxins, acids, and venoms. It will also eat oozes and slimes. Unfortunately, it otherwise behaves like a normal cat; there are very few people who want to take care of a cat and simultaneously find a Calinic’s abilities useful at this market, so the seller is probably offering the cat at a lowered price.");
            answer.Add("The deed to a tavern, hostel, or other innocuous city building; it has a large, clean basement with hidden side rooms, perfect for a secret laboratory, meeting room, vault, torture chamber, or what-have-you.");
            answer.Add("A scroll containing the secrets to finding and operating a magically hidden cavern base in the mountains.");
            answer.Add("Maps of secret passageways in the underbelly of old cities or castles, sold next to maps of recorded passageways between the Underdark and the surface world. They have some warning symbols on them, but they probably don’t account for every danger. The maps are unreadable to those who haven’t purchased them.");
            answer.Add("A writ granting one favor, within reason, from a criminal syndicate. Your payment helps keep them in business. The write can be magically tracked by them.");
            answer.Add("A magical vellum parchment that can be wrapped around a limb to make it look like a wooden prosthetic, or around a weapon to make it look like an innocuous object of similar size and proportions.");
            answer.Add("Binary poisons. Each is sold as a pair of dropper jars. Anyone who consumes an effective dosage of the first and second jars’ contents within 36 hours of each other suffers the effects of the full, original poison or drug. There are multiple different poisons and drugs being sold in this fashion.");
            answer.Add("Dossiers of blackmail on city officials that magically update as more blackmail becomes known to the criminal underworld. The organizations that sell these magic envelopes censor information on the bribes they perform.");
            answer.Add("A trained mimic.");
            answer.Add("The Talking Fungi – a fungus that when eaten let’s you speak and understand all languages for 1 Hour. When the effects ends you forget how to speak for 1 day.");
            answer.Add("A compass that points to the person who has the most money on them in a room. Doesn’t work outside.");
            answer.Add("A dagger that always misses the target. Excellent for screwing over that special someone.");
            answer.Add("The Tainted-Love Necklace – A silver necklace with a purple gem on it. Put one drop of your blood on the gem. Anyone who wears this necklace will be permanently charmed by you until they take it off. Wearing the necklace long-term causes the wearer to become greatly addicted to being charmed (to the giver specifically but also to charm spells in general). VERY illegal; punishment is life in jail in Neverwinter.");
            answer.Add("A fake-lactery (aka – A Fool’s Phylactery). If you have the item on you (which is the size of your fist) and drop to 0 hp, your soul goes into the device and stays there for one long rest. Then you return into your body with 1 hp and 2 levels of exhaustion. The item breaks after.");
            answer.Add("Back-water Love potions – Very effective (DC 15 wisdom save) and lasts for 1 week. The drinker falls head-over-heels (or heels-over-head if you’d prefer) in love with whoever gave them the drink. But there’s 10% chance of the drinker becomes obsessive, stalker-ish, even violent towards other potential suitors. If this occurs, the drinker will stay this way for a month instead of a week.");
            answer.Add("A mirror that, when hung in a room, let’s you see through door and walls in the reflection.");
            answer.Add("A kobold skull that grants you luck (1 re-roll of a d20 once per day). Being around kobolds will cause them to attack you en mass and with great rage.");
            answer.Add("A small orb you keep in your pocket. It gently buzzes when someone talks about you with hatred or malicious intent (provided you’re within 250 feet of them).");
            answer.Add("Torture Wine – Tastes like delicious fine wine. After a long rest, the user becomes overwhelmed with pain is unable to move or take any actions for 24 hours. During this time, they must make a wisdom save (DC 15) or they will be emotionally scarred from the horrible experience (-1 to charisma permanently)");
            answer.Add("Doses of “Juiblex,” – Phials of a viscous black liquid that causes catatonic euphoria and is extremely hazardous to one’s health.");
            answer.Add("Skeletal Longbow - A tall bow formed of hollowed out bones and bound together with strong cord, constructed by an outlaw ranger who turned necromancer.\r\nWhenthe bowstring is pulled back, a spectral arrow forms from a chilling mist, negating the need for seperate ammunition.\r\n\r\nDeals 1d8 cold damage, and critical hits with the skeletal longbow inflict the frightened condition on the target.");

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
