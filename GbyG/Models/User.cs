using Newtonsoft.Json;

namespace GbyG.Models
{
    public class User
    {
        [JsonProperty(PropertyName = "userid")]
        public int UserId { get; set; }

        [JsonProperty(PropertyName = "firstname")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "lastname")]
        public string LastName { get; set; }
    }
}