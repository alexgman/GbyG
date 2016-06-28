using Newtonsoft.Json;
using System;

namespace GbyG.Models
{
    public class Sample
    {
        public int SampleId { get; set; }

        public string Barcode { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CreatedBy { get; set; }

        public int StatusId { get; set; }
    }
}