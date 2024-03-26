using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage___RDG
{
    public class ChickenGenerator
    {
        public static Chicken CreateChicken(long id, string name)
        {
            Random random = new();
            DateTime birthday = DateTime.Now.AddDays(- random.Next(0, 7837));
            string dayOfBirth = birthday.ToString("MM/dd/yyyy");
            string[] gender = ["rooster", "hen", "pullet"];
            string assignedGender = gender[random.Next(0, gender.Length)];
            return new Chicken(id, name, assignedGender, dayOfBirth);
        }
    }
}
