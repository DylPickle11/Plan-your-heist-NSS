using System;
namespace PlanYourHeist
{
    class Heister
    {
        public Heister(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public decimal CourageFactor { get; set; }

        // public string Description
        // {
        //     get
        //     {
        //         return $"{Name} {SkillLevel} {CourageFactor}";
        //     }
        // }
    }
}