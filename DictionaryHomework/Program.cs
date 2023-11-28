using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace DictionaryHomework 
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            while (true) 
            {
            var NounList = new Dictionary<string, string>();
            NounList.Add("Art", "Beauty or emotional power.");
            NounList.Add("Credential", "Proof of someone's abilities and experience");
            NounList.Add("Beautiful", "Attractive");

            var AdjectiveList = new Dictionary<string, string>();
            AdjectiveList.Add("Solid", "Firm and stable in shape; not liquid or fluid.");
            AdjectiveList.Add("Unfruitful", "Not producing good or helpful results.");

            var VerbList = new Dictionary<string, string>();
            VerbList.Add("Retrieve", "Get or bring (something) back from somewhere.");
            VerbList.Add("Identify", "Establish or indicate who or what");
            VerbList.Add("Run", "Move swiftly");

            var AdverbList = new Dictionary<string, string>();
            AdverbList.Add("Quickly", "At a fast speed; rapidly.");
            AdverbList.Add("Slowly", "At a slow speed; not quickly.");

            static void PrintRandom(Dictionary<string, string> dictionary)
            {
                Random random = new Random();
                var randomOrder = dictionary.OrderBy(x => random.Next()).ToList();

                foreach (var entry in randomOrder)
                {
                    Console.WriteLine($"Word: {entry.Key}, Meaning: {entry.Value}");
                }
            }
            Console.WriteLine("Choose the one of them these four categories: 1-Noun 2-Adjective 3-Verb 4-Adverb");
            Console.WriteLine("If you want to add new word please press 5");
            int choice=Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PrintRandom(NounList);
                    break;

                case 2:
                    PrintRandom(AdjectiveList);
                    break;

                case 3:
                    PrintRandom(VerbList);
                    break;

                case 4:
                    PrintRandom(AdverbList);
                    break;

                case 5:
                    Console.WriteLine("Select the category you want to add= 1-Noun 2-Adjective 3-Verb 4-Adverb");
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (a == 1)
                    {
                        Console.WriteLine("You can write a noun.");
                        string newNoun = Console.ReadLine();
                        Console.WriteLine("You can write their meanings.");
                        string newNounMeaning= Console.ReadLine();
                        NounList.Add(newNoun, newNounMeaning);
                        PrintRandom(NounList);
                    }
                    if(a == 2)
                    {
                        Console.WriteLine("You can write an adjective.");
                        string newAdjective = Console.ReadLine();
                        Console.WriteLine("You can write their meanings.");
                        string newAdjectiveMeaning= Console.ReadLine();
                        AdjectiveList.Add(newAdjective, newAdjectiveMeaning);
                        PrintRandom(AdjectiveList);
                    }
                    else if (a == 3)
                    {
                        Console.WriteLine("You can write a verb");
                        string newVerb = Console.ReadLine();
                        Console.WriteLine("You can write their meanings.");
                        string newVerbMeaning = Console.ReadLine();
                        VerbList.Add(newVerb, newVerbMeaning);
                        PrintRandom(VerbList);
                    }
                    else if(a == 4)
                    {
                        Console.WriteLine("You can write an adverb you want to add and their meanings.");
                        string newAdverb = Console.ReadLine();
                        Console.WriteLine("You can write their meanings.");
                        string newAdverbMeaning = Console.ReadLine();
                        AdverbList.Add(newAdverb, newAdverbMeaning);
                        PrintRandom(AdverbList);
                    }
                    else
                    {
                        Console.WriteLine("You exited the program because you did not press a valid number");
                        return;   
                    }
                    break;
                    default:
                    Console.WriteLine("You exited the program because you did not press a valid number");
                    return;   
                    
                }
            }
        }
        
    }
}





