using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            // Phase 1
            // The program should...

            // Print the message "Plan Your Heist!".
            Console.WriteLine("Plan Your Heist");

            // Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.

            Dictionary<string, string> teamMembers = new Dictionary<string, string>()
            {

            };

            // Prompt the user to enter a team member's name and save that name.
            Console.WriteLine("Enter a team member's name:");
            string name = Console.ReadLine();
            teamMembers.Add("Name:", $"{name}");
            // Prompt the user to enter a team member's skill level and save that skill level with the name.
            Console.WriteLine("Enter a team member's skill level:");
            string skillLevel = Console.ReadLine();
            teamMembers.Add("Skill Level:", $"{skillLevel}");
            // Prompt the user to enter a team member's courage factor and save that courage factor with the name.
            Console.WriteLine("Enter a team member's courage factor:");
            string courageFactor = Console.ReadLine();
            teamMembers.Add("Courage Factor:", $"{courageFactor}");
            // Display the team member's information.
            foreach (KeyValuePair<string, string> member in teamMembers)
                Console.WriteLine(member);

            //                 Phase 2
            // The program should be updated to...

            // Create a way to store several team members.
            // Collect several team members' information.
            // Stop collecting team members when a blank name is entered.
            // Display a message containing the number of members of the team.
            // Display each team member's information.
        }

    }
}