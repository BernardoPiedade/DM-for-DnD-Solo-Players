using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_SoloPlayers
{
    public static class CharNameList
    {
        static List<string> CharName = new List<string>();
        static List<string> CharClass = new List<string>();
        static List<string> CharRace = new List<string>();

        static public string SelectCharNameList()
        {
            CharName.Add("Fin Stonehammer");
            CharName.Add("Sar Hunk");
            CharName.Add("Lino Vermon");
            CharName.Add("Quirn Forn Hunj");
            CharName.Add("Fhyt Knore");

            Random rnd = new Random();

            int select = rnd.Next(1, CharName.Count());

            return CharName[select].ToString();
        }

        static public string SelectCharClassList()
        {
            CharClass.Add("Barbarian");
            CharClass.Add("Bard");
            CharClass.Add("Cleric");
            CharClass.Add("Druid");
            CharClass.Add("Fighter");
            CharClass.Add("Monk");
            CharClass.Add("Paladin");
            CharClass.Add("Ranger");
            CharClass.Add("Rogue");
            CharClass.Add("Sorcerer");
            CharClass.Add("Warlock");
            CharClass.Add("Wizard");

            Random rnd = new Random();

            int select = rnd.Next(1, CharClass.Count());

            return CharClass[select].ToString();
        }

        static public string SelectCharRaceList()
        {
            CharRace.Add("Dragonborn");
            CharRace.Add("Dwarf");
            CharRace.Add("Elf");
            CharRace.Add("Gnome");
            CharRace.Add("Half-Elf");
            CharRace.Add("Halfling");
            CharRace.Add("Half-Orc");
            CharRace.Add("Human");
            CharRace.Add("Tiefling");

            Random rnd = new Random();

            int select = rnd.Next(1, CharRace.Count());

            return CharRace[select].ToString();
        }
    }
}
