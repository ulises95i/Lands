
namespace lands.Models
{
    using Newtonsoft.Json;
    public class Translations
    {
        [JsonProperty(propertyName: "de")]
        public string Germany { get; set; }

        [JsonProperty(propertyName: "es")]
        public string Spanish { get; set; }

        [JsonProperty(propertyName: "fr")]
        public string French { get; set; }

        [JsonProperty(propertyName: "ja")]
        public string Japanese { get; set; }

        [JsonProperty(propertyName: "it")]
        public string Italian { get; set; }

        [JsonProperty(propertyName: "br")]
        public string Brazilian { get; set; }

        [JsonProperty(propertyName: "pt")]
        public string Portuges { get; set; }

        [JsonProperty(propertyName: "nl")]
        public string Dutch { get; set; }

        [JsonProperty(propertyName: "hr")]
        public string Croatian { get; set; }

        [JsonProperty(propertyName: "fa")]
        public string Persian { get; set; }
    }
}
