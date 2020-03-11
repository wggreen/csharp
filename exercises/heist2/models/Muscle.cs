using System;

namespace heist2
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public double PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            Console.WriteLine($"{Name} is subdueing the security guards. Decreased security by {SkillLevel} points.");
            bank.SecurityGuardScore -= SkillLevel;
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has subdued the security guards!");
            }
        }
    }
}