
namespace Stage___RDG
{
    public class Chicken
    {
        private long _id;
        private string _name;
        private string _assignedGender;
        private string _dateOfBirth;
        private string _color;
        private long _owner_id;
        private long _location_id;
        private string _section;
        private string _species;
        private string _favorite_food;
        private string _country_origin;
        private string _health_status;


        public Chicken(long id, string name, 
            string assignedGender, string dateOfBirth, string color, long owner_id, string section, 
            string species, string favorite_food, string country_origin, string health_status)
        {
            _id = id;
            _name = name;
            _assignedGender = assignedGender;
            _dateOfBirth = dateOfBirth;
            _color = color;
            _owner_id = owner_id;
            _section = section;
            _species = species;
            _favorite_food = favorite_food;
            _country_origin = country_origin;
            _health_status = health_status;
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

        public string GetColor()
        {
            return _color;
        }

        public long GetOwnerId()
        {
            return _owner_id;
        }

        public long GetLocationId()
        {
            return _location_id;
        }

        public string GetSection()
        {
            return _section;
        }
        public string GetSpecies()
        {
            return _species;
        }

        public string GetFavoriteFood()
        {
            return _favorite_food;
        }

        public string GetCountryOrigin()
        {
            return _country_origin;
        }

        public string GetHealthStatus()
        {
            return _health_status;
        }


        public override string ToString()
        {
            return $"{_id}, {_name}, {_assignedGender}, {_dateOfBirth}, {_color}, {_owner_id}, {_location_id}, {_section}, {_species}, {_favorite_food}, {_country_origin}, {_health_status}";
        }

    }
}