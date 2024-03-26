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
            //string pathSmall = @"c:\Users\JoeyM\Desktop\StageSteria\CSV\testfile.csv";
            string path = @"D:\CSV\testfile.csv";
            RealNameGenerator generator = new();
            //Total old amount of chickens needed to reach 200 GB.
            //long oldAmount = 5970845481;
            long amount = 2700000000;

            using StreamWriter outputFile = File.AppendText(path);
            try
            {
                outputFile.WriteLine($"id, name, gender, date_of_birth, color, owner_id, location_id, section, species, favorite_food, country_origin, health_status");
                for (long id = 0; id < amount; id++)
                {
                    Chicken chicken = ChickenGenerator.CreateChicken(id+1, generator.Generate().Split(' ')[0]);
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
