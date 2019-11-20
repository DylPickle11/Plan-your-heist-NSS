using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the message "Plan Your Heist!".
            Console.WriteLine("==============================================");
            Console.WriteLine("//////////////Plan Your Heist/////////////////");
            Console.WriteLine("==============================================");

            // Create a way to store several team members.
            List<Heister> heistTeam = new List<Heister>();
            List<int> success = new List<int>();
            List<int> failure = new List<int>();

            // At the beginning of the program, prompt the user to enter the difficulty level of the bank.
            Console.WriteLine("Enter Bank Difficulty:");
            string bankAnswer = Console.ReadLine();
            int bankDifficulty = int.Parse(bankAnswer);

            // Collect several team members' information.
            bool IsAskAgain = true;
            string name;
            string skill;
            string courage;

            while (IsAskAgain)
            {

                // Prompt the user to enter a team member's name and save that name.
                Console.WriteLine("Enter a team member's name:");
                name = Console.ReadLine();
                if (name == "")
                {
                    //Stop collecting team members when a blank name is entered.
                    break;
                }
                else
                {
                    // Prompt the user to enter a team member's skill level and save that skill level with the name.
                    Console.WriteLine("Enter a team member's skill level:");
                    skill = Console.ReadLine();

                    // Prompt the user to enter a team member's courage factor and save that courage factor with the name.
                    Console.WriteLine("Enter a team member's courage factor:");
                    courage = Console.ReadLine();

                    Heister heister = new Heister(name)
                    {
                        Name = name,
                        SkillLevel = int.Parse(skill),
                        CourageFactor = decimal.Parse(courage)
                    };
                    heistTeam.Add(heister);
                };
            }



            //Display a message containing the number of members of the team.
            Console.WriteLine("==============================================");
            Console.WriteLine($"You have {heistTeam.Count} heisters on your team!");
            Console.WriteLine("==============================================");

            //Display each team member's information.
            // Stop displaying each team member's information.
            bool shouldDisplay = true;
            while (shouldDisplay)
            {
                heistTeam.ForEach(heister =>
                {
                    Console.WriteLine($"{heister.Name} has a skill Level of {heister.SkillLevel} and a courage factor of {heister.CourageFactor}");
                    Console.WriteLine("==============================================");
                });
                if (shouldDisplay)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Slight Malfunction");
                }
            }

            //Prompt user to enter the number of trial runs the program should perform.
            Console.WriteLine("==============================================");
            Console.WriteLine("How many heists or trial runs, would you like to try?");
            string trialRun = Console.ReadLine();
            Console.WriteLine("==============================================");

            // Loop through the difficulty / skill level calculation based on the user-entered number of trial runs. Choose a new luck value each time.
            int counter = int.Parse(trialRun);
            for (int i = 0; i < counter; i++)
            {
                // Store a value for the bank's difficulty level. Set this value to 100.
                //double bankDifficulty = 100;

                // Sum the skill levels of the team. Save that number.
                List<int> skillNum = new List<int>();

                heistTeam.ForEach(heister =>
                {
                    skillNum.Add(heister.SkillLevel);
                });

                int sumOfSkills = skillNum.Sum();

                // Create a random number between -10 and 10 for the heist's luck value.
                Random random = new Random();
                int luckValue = random.Next(-10, 10);

                // Add this number to the bank's difficulty level.
                bankDifficulty += luckValue;

                // Before displaying the success or failure message, display a report
                Console.WriteLine($"Team's combined skill Level:{sumOfSkills} Bank's difficulty Level:{bankDifficulty}");

                //If skill level >= bank's difficulty level. Display a success message, otherwise failure message.
                if (sumOfSkills >= bankDifficulty)
                {
                    Console.WriteLine("Congrats! You pulled off the heist.");
                    success.Add(sumOfSkills);
                }
                else
                {
                    Console.WriteLine("Bummer. Your going to Jail.");
                    failure.Add(sumOfSkills);
                }
            }
            // At the end of the program, display a report showing the number of successful runs and the number of failed runs.
            Console.WriteLine("==============================================");
            Console.WriteLine($"Successful heists: {success.Count} Failed heists: {failure.Count}");
            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("==============================================");




            // try
            // {
            //     int skillLevel = int.Parse(skillLevelString);
            // }
            // catch (Exception ex)
            // {
            //     Console.Write($"{SkillLevelString} is not a valid skill level")
            //     skillLevel = 10;
            // }


        }

    }
}
