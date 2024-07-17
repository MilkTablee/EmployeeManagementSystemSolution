
using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class Relationshp
    {
        // Relationship: One to Many
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }
    }
}
