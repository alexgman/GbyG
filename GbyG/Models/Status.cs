using Newtonsoft.Json;

namespace GbyG.Models
{
    public class Status
    {
        [JsonProperty(PropertyName = "statusid")]
        public int StatusId { get; set; }

        [JsonProperty(PropertyName = "statustype")]
        public string StatusType { get; set; }
    }
}