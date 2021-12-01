using System;
using System.Collections.Generic;
using System.Text;

namespace IX_Projects
{
    class Animals
    {
        public string brain { get; set;}

        public string bloodType { get; set; }

    }

    class Mammal : Animals
    { 
        public string specie { get; set; }

    }
    class Civilised : Animals 
    {
        public bool isCivilised { get; set; }
    }
    class NonCivilised : Animals
    {
        public string subSpecie { get; set; }
        public string livingHabitat { get; set; }


    }

    class Wild : NonCivilised
    { 
        public bool isHerbivores { get; set; }
        public bool isDangerous { get; set; }

    }

    class Domestic : NonCivilised
    {
        public bool isEdible { get; set; }
        public bool isPet { get; set; }
        public bool isHerbivores { get; set; }
        public bool isDangerous { get; set; }
    }



    class Birds : Animals 
    { 
        public string name { get; set; }
    }

    class Fliable : Birds
    { 
        public int flyHeight { get; set; }
    }
    class NonFliable : Birds {
        public bool isRun { get; set; }
        public bool isSwim { get; set; }
    }

    class Reptiles : Animals
    {
        public string name { get; set; }
    }

    class LayEgg : Reptiles
    { 
        public string subSpecie { get; set; }
        public bool isDangerous { get; set; }

    }

    class BirthLivingYoung : Reptiles
    {
        public string subSpecie { get; set; }
        public bool isDangerous { get; set; }
    }
}
