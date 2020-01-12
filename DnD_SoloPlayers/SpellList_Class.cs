using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_SoloPlayers
{
    class SpellList_Class
    {
        int level;
        string name, school, time, range, components, duration, classes, description;

        public SpellList_Class()
        {
            level = 0;
            name = "";
            school = "";
            time = "";
            range = "";
            components = "";
            duration = "";
            classes = "";
            description = "";
        }

        public SpellList_Class(SpellList_Class s)
        {
            level = s.level;
            name = s.name;
            school = s.school;
            time = s.time;
            range = s.range;
            components = s.components;
            duration = s.duration;
            classes = s.classes;
            description = s.description;
        }

        public SpellList_Class(int level, string name, string school, string time, string range, string components, string duration, string classes, string description)
        {
            this.level = level;
            this.name = name;
            this.school = school;
            this.time = time;
            this.range = range;
            this.components = components;
            this.duration = duration;
            this.classes = classes;
            this.description = description;
        }

        public int Level { get => level; set => level = value; }
        public string Name { get => name; set => name = value; }
        public string School { get => school; set => school = value; }
        public string Time { get => time; set => time = value; }
        public string Range { get => range; set => range = value; }
        public string Components { get => components; set => components = value; }
        public string Duration { get => duration; set => duration = value; }
        public string Classes { get => classes; set => classes = value; }
        public string Description { get => description; set => description = value; }

        public override bool Equals(object obj)
        {
            return obj is SpellList_Class @class &&
                   level == @class.level &&
                   name == @class.name &&
                   school == @class.school &&
                   time == @class.time &&
                   range == @class.range &&
                   components == @class.components &&
                   duration == @class.duration &&
                   classes == @class.classes &&
                   description == @class.description;
        }

        public override string ToString()
        {
            return "Name: "+name+"\nLevel: "+level+"\nSchool: "+school+"\nTime: "+time+"\nRange: "+range+"\nComponents: "+components+"\nDuration: "+duration+"\nClasses: "+classes+"\nDescription: "+description;
        }
    }
}
