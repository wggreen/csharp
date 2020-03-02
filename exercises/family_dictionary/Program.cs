using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Krista"},
                {"age", "42"}
            });
            myFamily.Add("brother", new Dictionary<string, string>(){
                {"name", "Bob"},
                {"age", "40"}
            });
            myFamily.Add("mom", new Dictionary<string, string>(){
                {"name", "Jane"},
                {"age", "68"}
            });
            myFamily.Add("dad", new Dictionary<string, string>(){
                {"name", "Bob"},
                {"age", "72"}
            });

            foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {
                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and she is {familyMember.Value["age"]} years old");
            }
        }
    }
}
