
namespace Stage___RDG
{
    public class Chicken
    {
        private long _id;
        private string _name;
        private string _assignedGender;
        private string _dateOfBirth;

        public Chicken(long id, string name, string assignedGender, string dateOfBirth)
        {
            _id = id;
            _name = name;
            _assignedGender = assignedGender;
            _dateOfBirth = dateOfBirth;
        }

        public long GetId()
        {
            return _id;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetAssignedGender()
        { 
            return _assignedGender;
        }
        public string GetDateOfBirth()
        {
            return _dateOfBirth;
        }

        public override string ToString()
        {
            return $"{_id}, {_name}, {_assignedGender}, {_dateOfBirth}";
        }

    }
}