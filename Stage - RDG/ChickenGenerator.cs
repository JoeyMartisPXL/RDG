using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Stage___RDG
{
    public class ChickenGenerator
    {
        public static Chicken CreateChicken(long id, string name)
        {
            Random random = new();
            DateTime birthday = DateTime.Now.AddDays(- random.Next(0, 7837));
            string dateOfBirth = birthday.ToString("MM/dd/yyyy");
            string[] gender = { "rooster", "hen", "pullet" };
            string assignedGender = gender[random.Next(0, gender.Length)];
            string[] colors = { "blue", "black", "buff", "lavender", "red", "white"};
            string assignedColor = colors[random.Next(0, colors.Length)];
            long ownerId = random.NextInt64(1, 11);
            string[] sections = { "A73", "B98", "C41" };
            string assignedSection = sections[random.Next(0, sections.Length)];
            string species = "Bird";
            string[] favoriteFoods = { "berries", "seeds", "bugs" };
            string assignedFavoriteFood = favoriteFoods[random.Next(0, favoriteFoods.Length)];
            string[] countryOrigins = { "Germany", "USA", "Italy", "Japan", "Belgium" };
            string assignedCountryOrigin = countryOrigins[random.Next(0, countryOrigins.Length)];
            string[] healthStatus = { "good", "average", "bad", "dead" };
            string assignedHealthStatus = healthStatus[random.Next(0, healthStatus.Length)];
            return new Chicken(id, name,
            assignedGender, dateOfBirth, assignedColor, ownerId, assignedSection,
            species, assignedFavoriteFood, assignedCountryOrigin, assignedHealthStatus);
        }
    }
}
