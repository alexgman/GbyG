using System;
using Newtonsoft.Json;

namespace GbyG.Models
{
    public class Sample
    {
        [JsonProperty(PropertyName = "sampleid")]
        public int SampleId { get; set; }

        [JsonProperty(PropertyName = "barcode")]
        public string Barcode { get; set; }

        [JsonProperty(PropertyName = "createdat")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "createdby")]
        public int CreatedBy { get; set; }

        [JsonProperty(PropertyName = "statusid")]
        public int StatusId { get; set; }
    }
}