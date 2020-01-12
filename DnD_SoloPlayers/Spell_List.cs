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
    public partial class Spell_List : Form
    {
        static List<SpellList_Class> listSpells = new List<SpellList_Class>();

        public Spell_List()
        {
            InitializeComponent();

            // level, name, school, Time, Range, Components, Duration, Classes, Description

            //level 0
            listSpells.Add(new SpellList_Class(0,"Acid Splash","Conjuration","1 action","60 feet","V,S","Instantaneous","Artificer, Sorcerer, Wizard, Fighter(Eldritch Knight), Rogue (Arcane Trickster)","You hurl a bubble of acid. Choose one creature you can see within range, or choose two creatures you can see within range that are within 5 feet of each other.\nA target must succeed on Dexterity saving throw or take 1d6 acid damage.\nThis spells damage increases by 1d6 when you reach 5th level (2d6), 11th level (3d6) and 17th level (4d6)."));
            listSpells.Add(new SpellList_Class(0,"Blade Wards","Abjuration","1 action","Self","V,S","1 round","Bard, Sorcerer, Warlock,Wizard,Fighter(Eldritch Knight) Rogue(Arcane Trickster)","You extend your hand and trace a sigil of warding in the air. Until the end of your next turn, you have resistance against bludgeoning, piercing, and slashing damage dealt by weapon attacks"));
            listSpells.Add(new SpellList_Class(0,"Chill Touch","Necromancy","1 action","120 feet","V,S","1 round","Sorcerer, Warlock, Wizard, Fighter(Eldritch Knight), Rogue(Acrane Trickster), Druid(Spores)","You create a ghostly, skeletal hand in the space of a creature within range. Make a ranged apell attack against the creature to assail it with the chill of the grave. On a hit, the target takes 1d8 necrotic damage, and it can't regain hit points until the start of your next turn. Until then, the hand clings to the target, it also has disadvantage on attack rolls against you until the end of your next turn.\nThis spell's damage increases by 1d8 when you reach 5th level (2d8), 11th level(3d8), and 17th level(4d8)"));
            listSpells.Add(new SpellList_Class(0,"Dancing Lights","Evocation","1 action","120 feet","V,S,M","Concentrarion, up to 1 minute","Artificer, Barder, Sorcer, Wizard, Fighter(Eldritch Knight), Rogue(Arcane Trickster)","You create up to four torch-sized lights within range, making them appear as torches, lanterns, or glowing orbs that hover in the air for the duration. You can also combine the four lights into one glowing vaguely humanoid form of Medium size. Whichever form you choose, each light sheds dim light in a 10-foot radius.\nAs a bonus action on your turn, you can move the lights up to 60 feet to a new spot within range. A light must be within 20 feet of another light created by this spell, and a light winks out if it exceeds the spell's range."));
            listSpells.Add(new SpellList_Class(0,"Druidcraft","Transmutation","1 action","30 feet","V,S","Instantaneous","Druid","Whispering to the spirits of nature, you create one of the following effects within range.\nYou create a tiny, harmless sensory effect that predicts what the weather will be at your location for the next 24 hours. The effect might manifest as a golden orb for clear skies, a cloud for rain, falling snowflakes for snow, and so on. This effect persists for 1 round.\nYou instantly make a flower blossom, a seed pod open, or a leaf bud bloom.\nYou create an instantaneous, harmless sensory effect, such as falling leaves, a puff of wind, the sound of a small animal, or the faint odor of skunk. The effect must fit in a 5-foot cube.\n You instantly light or snuff out a candle, a torch, or a small campfire."));
            listSpells.Add(new SpellList_Class(0,"Eldritch Blast","Evocation","1 action","120 feet","V,S","Instantaneous","Warlock","A beam of crackling energy streaks towards a creature within range. Make a ranged spell attack against the target. On a hit, the target takes 1d10 force damage.\nThe spell creates more than one beam when you reach higher levels - two beams at 5th level, three beams at 11th level, and four beams at 17th level. You can direct the beams at the same target or at different ones. Make a separate attack roll for each beam."));
            listSpells.Add(new SpellList_Class(0,"Fire Bolt","Evocation","1 action","120 feet","V,S","Instantaneous","Artificer, Sorcerer, Wizard, Fighter(Eldritch Knight), Rogue(Arcane Trickster)","You hurl a mote of fire at a creature or object within range. Make a ranged spell attack against the target. On a hit, the target takes 1d10 fire damage. A flammable object hit by this spell ignites if it isn't being worn or carried.\nThis spell's damage increases by 1d10 when you reach 5th level (2d10), and 17th level (4d10)."));
            listSpells.Add(new SpellList_Class(0,"Friends","Enchantment","1 action","Self","S,M","Concentration, up to 1 minute","Bard, Sorcerer, Warlock, Wizard, Fighter(Eldritch Knight), Rogue(Arcane Trickster)","For the duration, you have advantage on all Charisma checks directed at one creature of your choice that isn't hostil toward you. When the spell ends, the creature realizes that you used magic to influence its mood and becomes hostile toward you. A creature prone to violence might attack you. Another creature might seek retribution in other ways (at the DM's discretion), depending on the nature of your interaction with it."));
            listSpells.Add(new SpellList_Class(0,"Guidance","Divination","1 action","Touch","V,S","Concentration, up to 1 minute","Artificer, Cleric, Druid","You touch one willing creature. Once before the spell ends, the target can roll a d4 and add the number rolled to one ability check of its choice. It can roll the die before or after making the ability check. The spell then ends"));
            listSpells.Add(new SpellList_Class(0,"Light","Evocation","1 action","Touch","V,M(a firefly or phosphorescent moss)","1 hour","Artificer, Bard, Cleric, Sorcerer, Wizard, Fighter(Eldritch Knight), Rogue(Arcane Trickster), Warlock(Celestial)", "You touch one object that is no larger than 10 feet in any dimension. Until the spell ends, the object sheds bright light in a 20-foot radious and dim light for an addition 20 feet. The light can be colored as you like. Completely covering the object with someting opaque blocks the light. The spell ends if you cast it again or dismiss it as an action.\nIf you target an object held or worn by a hostile craeture, that creature must succeed on a Dexterity saving throw to avoid the spell."));
            listSpells.Add(new SpellList_Class(0,"Mage Hand","Conjuration","1 action","30 feet","V,S","1 minute","Artificer, Bard, Sorcerer, Warlock, Wizard, Fighter (Eldritch Knight), Rogue (Arcane Trickster)","A spectral, floating hand appears at a point you choose within range. The hand lasts for the duration or until you dismiss it as an action. The hand vanishes if it is ever more than 30 feet away from you or if you cast this spell again.\nYou can use your action to control the hand. You can use the hand to manipulate an object, open an unlocked door or container, stow or retrieve an item from an open container, or pour the contents out of a vial. You can move the ahnd up to 30 feet each time you use it.\nThe hand can't attack, activate magical items, or carry more than 10 pounds."));
            

            //level 1


            //level 2


            //level 3


            //level 4


            //level 5


            //level 6


            //level 7


            //level 8


            //level 9
        }
    }
}
