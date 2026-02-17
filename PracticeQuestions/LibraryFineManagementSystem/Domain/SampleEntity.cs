using Exceptions;

namespace Domain
{
    public class SampleEntity : BaseEntity
    {
        public string Name { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Id))
                throw new ScenarioException("Id cannot be empty");

            if (string.IsNullOrWhiteSpace(Name))
                throw new ScenarioException("Name cannot be empty");
        }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
