using System;
using System.Collections.Generic;
using System.Linq;

namespace heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRobber> rolodex = new List<IRobber>();

            var MrPink = new Hacker()
            {
                Name = "Mr. Pink",
                SkillLevel = 50,
                PercentageCut = 33
            };
            var MrBlue = new Hacker()
            {
                Name = "Mr. Blue",
                SkillLevel = 40,
                PercentageCut = 20
            };
            var MrWhite = new LockSpecialist()
            {
                Name = "Mr. White",
                SkillLevel = 55,
                PercentageCut = 40
            };
            var MrRed = new LockSpecialist()
            {
                Name = "Mr. Red",
                SkillLevel = 75,
                PercentageCut = 10
            };
            var MrGreen = new Muscle()
            {
                Name = "Mr. Green",
                SkillLevel = 33,
                PercentageCut = 10
            };
            var MrYellow = new Muscle()
            {
                Name = "Mr. Brownlee",
                SkillLevel = 100,
                PercentageCut = 99
            };
            rolodex.Add(MrBlue);
            rolodex.Add(MrGreen);
            rolodex.Add(MrPink);
            rolodex.Add(MrWhite);
            rolodex.Add(MrYellow);
            rolodex.Add(MrRed);

            Console.WriteLine($"\nThere are {rolodex.Count} robbers in your rolodex");
            Console.WriteLine("It's time to add robbers to the rolodex.");

            bool teamNameBlank = false;

            while (teamNameBlank == false)
            {
                Console.WriteLine("\nPlease enter the new robber's name:");
                string robberName = Console.ReadLine();
                if (string.IsNullOrEmpty(robberName))
                {
                    teamNameBlank = true;
                    break;
                }
                string robberSpeciality = "";
                while ((robberSpeciality != "Hacker") && (robberSpeciality != "Muscle") && (robberSpeciality != "Lock Specialist"))
                {
                    Console.WriteLine("\nPlease enter the new robber's speciality:");
                    Console.WriteLine("Hacker (Disables alarms)");
                    Console.WriteLine("Muscle (Disarms guards)");
                    Console.WriteLine("Lock Specialist (cracks vault)");
                    robberSpeciality = Console.ReadLine();
                    if (robberSpeciality != "Hacker" && robberSpeciality != "Muscle" && robberSpeciality != "Lock Specialist")
                    {
                        Console.WriteLine("\nYou've entered an invalid answer. Please select a valid speciality('Hacker', 'Muscle', 'Lock Specialist').\n");
                    }
                }
                int robberSkillLevel = 0;
                while (robberSkillLevel >= 0 && robberSkillLevel <= 100)
                {
                    Console.WriteLine("\nPlease enter the new robber's skill level as a number between 0 and 100:");
                    string skillLevelEntry = Console.ReadLine();
                    try
                    {
                        int skillLevelParsed = int.Parse(skillLevelEntry);
                        if (skillLevelParsed <= 0 || skillLevelParsed >= 100)
                        {
                            Console.WriteLine("\nThe robber's skill level must be between 0 and 100.\n");
                        }
                        else
                        {
                            robberSkillLevel = skillLevelParsed;
                            break;
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("\nYou have entered an invalid skill level. Please enter an integer between 0 and 100.\n");
                    }
                }
                int robberPercentageCut = 0;
                while (robberPercentageCut <= 0 || robberPercentageCut >= 100)
                {
                    Console.WriteLine("\nPlease enter the new robber's cut of the take as a number between 0 and 100:");
                    var percentageCutEntry = Console.ReadLine();
                    try
                    {
                        int percentageCutParsed = int.Parse(percentageCutEntry);
                        Console.WriteLine("The try for skill level executed");
                        if (percentageCutParsed <= 0 && percentageCutParsed >= 100)
                        {
                            Console.WriteLine("The robber's cut must be between 0 and 100.\n");
                        }
                        else
                        {
                            robberPercentageCut = percentageCutParsed;
                            Console.WriteLine($"robberPercentageCut = {robberPercentageCut}");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("You have entered an invalid percentage cut. Please enter an integer between 0 and 100.\n");
                    }
                }
                if (robberSpeciality == "Hacker")
                {
                    var hacker = new Hacker()
                    {
                        Name = robberName,
                        SkillLevel = robberSkillLevel,
                        PercentageCut = robberPercentageCut
                    };
                    rolodex.Add(hacker);
                }
                else if (robberSpeciality == "Muscle")
                {
                    var muscle = new Muscle()
                    {
                        Name = robberName,
                        SkillLevel = robberSkillLevel,
                        PercentageCut = robberPercentageCut
                    };
                    rolodex.Add(muscle);
                }
                else if (robberSpeciality == "Lock Specialist")
                {
                    var lockpick = new LockSpecialist()
                    {
                        Name = robberName,
                        SkillLevel = robberSkillLevel,
                        PercentageCut = robberPercentageCut
                    };
                    rolodex.Add(lockpick);
                }
                Console.WriteLine($"\n\nThere are {rolodex.Count} robbers in your rolodex\n");
            }

            Random rand = new Random();
            int alarmScore = rand.Next(0, 101);
            int vaultScore = rand.Next(0, 101);
            int securityGuardScore = rand.Next(0, 101);
            int cashOnHand = rand.Next(50000, 1000001);

            Dictionary<string, int> systems = new Dictionary<string, int>();
            systems.Add("Alarm", alarmScore);
            systems.Add("Vault", vaultScore);
            systems.Add("Security Guards", securityGuardScore);


            var sortedSystems = systems.OrderBy(kvp => kvp.Value);

            var leastSecure = sortedSystems.First();
            var mostSecure = sortedSystems.Last();

            Console.WriteLine("Recon Report");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Most Secure: {mostSecure.Key} {mostSecure.Value}");
            Console.WriteLine($"Least Secure: {leastSecure.Key} {leastSecure.Value}");
            var bank = new Bank()
            {
                AlarmScore = alarmScore,
                VaultScore = vaultScore,
                SecurityGuardScore = securityGuardScore,
                CashOnHand = cashOnHand
            };
            Console.WriteLine("Bank's alarm score: " + bank.AlarmScore);
            Console.WriteLine("Bank's vault score: " + bank.VaultScore);
            Console.WriteLine("Bank's security guard score: " + bank.SecurityGuardScore);
            Console.WriteLine("Bank's cash on hand: $" + bank.CashOnHand + "\n");

            List<IRobber> crew = new List<IRobber>();

            bool crewIndexBlank = false;

            Console.WriteLine("\nIt's time to build your crew!");

            double percentageTotal = 100;

            while (crewIndexBlank == false)
            {
                Console.WriteLine("Here are the robbers you can add to your crew:");
                Console.WriteLine("----------------------------------------------");
                foreach (var robber in rolodex)
                {
                    double robberCut = robber.PercentageCut;
                    double percentageRemainder = percentageTotal - robberCut;
                    if (!crew.Contains(robber))
                    {
                        if (percentageRemainder > 0)
                        {
                            Console.Write($"{robber.Name}");
                            Console.Write($" - [{rolodex.IndexOf(robber)}]");
                            if (robber.GetType() == typeof(Hacker))
                            {
                                Console.WriteLine("\n*Hacker");
                            }
                            else if (robber.GetType() == typeof(Muscle))
                            {
                                Console.WriteLine("\n*Muscle");
                            }
                            else if (robber.GetType() == typeof(LockSpecialist))
                            {
                                Console.WriteLine("\n*Lock Specialist");
                            }
                            Console.WriteLine($"*Skill level: {robber.SkillLevel}");
                            Console.WriteLine($"*Percentage cut: {robber.PercentageCut}\n");
                        }
                    }
                }
                Console.WriteLine($"\nCut remaining: {percentageTotal}");
                Console.WriteLine("Add a robber to your crew by entering their number:");
                string enteredIndex = Console.ReadLine();
                if (enteredIndex.Length > 0)
                {
                    try
                    {
                        int robberIndex = int.Parse(enteredIndex);

                        if (robberIndex >= 0 && robberIndex <= rolodex.Count)
                        {
                            var chosenRobber = rolodex[robberIndex];
                            double chosenRobberCut = chosenRobber.PercentageCut;
                            if ((percentageTotal - chosenRobberCut) < 0)
                            {
                                Console.WriteLine("\nTheir cut is too high. Pick someone else.\n");
                            }
                            else
                            {
                                if (!crew.Contains(chosenRobber))
                                {
                                    crew.Add(chosenRobber);
                                    percentageTotal -= chosenRobber.PercentageCut;
                                }
                                else
                                {
                                    Console.WriteLine("That robber is already on your crew.\n");
                                }
                            }
                        }
                        else if (robberIndex < 0 || robberIndex > 100)
                        {
                            Console.WriteLine("Please enter a valid index.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input. Please enter a valid index in the rolodex.\n");
                    }
                }
                else
                {
                    if (crew.Count <= 0)
                    {
                        Console.WriteLine("Your crew is empty! Add robbers to it\n");
                    }
                    else
                    {
                        break;
                    }

                }

            }

            foreach (var member in crew)
            {
                member.PerformSkill(bank);
            }

            if (bank.IsSecure)
            {
                Console.WriteLine("Your crew blew it! Enjoy the slammer!");
            }
            else
            {
                double teamTake = 0;
                foreach (var member in crew)
                {
                    double memberTake = (member.PercentageCut / 100) * bank.CashOnHand;
                    Console.WriteLine($"{member.Name}'s cut: " + String.Format("{0:00.0}", memberTake));
                    teamTake += memberTake;
                }
                double yourTake = bank.CashOnHand - teamTake;
                Console.WriteLine($"Your final take: " + String.Format("{0:00.0}", yourTake));
            }

        }
    }
}
