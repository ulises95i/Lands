
using Newtonsoft.Json;

namespace lands.Models
{
    public class Language
    {
        [JsonProperty(propertyName: "iso639_1")]
        public string Iso6391 { get; set; }

        [JsonProperty(propertyName: "iso639_2")]
        public string Iso6392 { get; set; }

        [JsonProperty(propertyName: "name")]
        public string Name { get; set; }

        [JsonProperty(propertyName: "nativeName")]
        public string NativeName { get; set; }
    }
}
