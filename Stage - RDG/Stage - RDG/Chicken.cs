
namespace Stage___RDG
{
    public class Chicken(long id, string name, string assignedGender, string dateOfBirth)
    {
        public long Id { get; private set; } = id;
        public string Name { get; private set; } = name;
        public string AssignedGender { get; private set; } = assignedGender;
        public string DateOfBirth { get; private set; } = dateOfBirth;
    }
}