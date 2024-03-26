using NameGenerator.Generators;
using System.IO;

namespace Stage___RDG
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Start generating data...");
            string pathSmall = @"c:\Users\JoeyM\Desktop\StageSteria\CSV\testfile.csv";
            RealNameGenerator generator = new();
            long amount = 1000000;
            using StreamWriter outputFile = File.AppendText(pathSmall);
            try
            {
                outputFile.WriteLine($"id, name, gender, date_of_birth");
                for (long id = 0; id < amount; id++)
                {
                    Chicken chicken = ChickenGenerator.CreateChicken(id, generator.Generate().Split(' ')[0]);
                    outputFile.WriteLine($"{chicken.Id}, {chicken.Name}, {chicken.AssignedGender}, {chicken.DateOfBirth}");
                    Console.WriteLine("Still need to do: " + (amount - id) + " chickens.");
                }
                
            }
            catch
            {

                Console.WriteLine("Something went wrong.");
            }


        }
    }
}
