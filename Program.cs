using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the message "Plan Your Heist!".
            Console.WriteLine("==============================================");
            Console.WriteLine("/////////// Plan Your Heist///////////////////");
            Console.WriteLine("==============================================");

            // Create a way to store several team members.
            List<Heister> heistTeam = new List<Heister>();


            // Collect several team members' information.
            bool IsAskAgain = true;

            while (IsAskAgain)
            {

                // Prompt the user to enter a team member's name and save that name.
                Console.WriteLine("Enter a team member's name:");
                string name = Console.ReadLine();
                if (name == "")
                {
                    //Stop collecting team members when a blank name is entered.
                    break;
                }
                else
                {
                    // Prompt the user to enter a team member's skill level and save that skill level with the name.
                    Console.WriteLine("Enter a team member's skill level:");
                    string skill = Console.ReadLine();

                    // Prompt the user to enter a team member's courage factor and save that courage factor with the name.
                    Console.WriteLine("Enter a team member's courage factor:");
                    string courage = Console.ReadLine();

                    Heister heister = new Heister(name)
                    {
                        Name = name,
                        SkillLevel = int.Parse(skill),
                        CourageFactor = decimal.Parse(courage)
                    };
                    heistTeam.Add(heister);
                }

            };

            //Display a message containing the number of members of the team.
            Console.WriteLine($"You have {heistTeam.Count} heisters on your team!");

            //Display each team member's information.
            heistTeam.ForEach(heister =>
            {
                Console.WriteLine($"{heister.Name} has a skill Level of {heister.SkillLevel} and a courage factor of {heister.CourageFactor}");
            });



            // try
            // {
            //     int skillLevel = int.Parse(skillLevelString);
            // }
            // catch (Exception ex)
            // {
            //     Console.Write($"{SkillLevelString} is not a valid skill level")
            //     skillLevel = 10;
            // }

            // Console.WriteLine("Enter a team member's courage factor:");
            // int courageLevel = Console.ReadLine();

        }

    }
}