using System;

namespace heist2
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public double PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            Console.WriteLine($"{Name} is picking the vault's lock. Decreased security skill by {SkillLevel} points.");
            bank.VaultScore -= SkillLevel;
            if (bank.VaultScore <= 0)
            {
                Console.WriteLine($"{Name} has picked the vault's lock! We're in!");
            }
        }
    }
}