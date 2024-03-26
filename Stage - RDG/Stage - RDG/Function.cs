using NameGenerator.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Stage___RDG
{
    public class Function
    {
        internal static void Start()
        {
            string pathSmall = @"c:\Users\JoeyM\Desktop\StageSteria\CSV\testfile.csv";
            RealNameGenerator generator = new();
            //Total amount of chickens needed to reach 200 GB with 4 params.
            long amount = 5970845481;
            
            using StreamWriter outputFile = File.AppendText(pathSmall);
            try
            {
                outputFile.WriteLine($"id, name, gender, date_of_birth");
                for (long id = 0; id < amount; id++)
                {
                    Chicken chicken = ChickenGenerator.CreateChicken(id, generator.Generate().Split(' ')[0]);
                    outputFile.WriteLine(chicken.ToString());
                }
            }
            catch
            {
                Console.WriteLine("Something went wrong.");
            }
        }
    }
}
