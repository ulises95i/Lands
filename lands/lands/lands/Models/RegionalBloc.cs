using Newtonsoft.Json;

namespace lands.Models
{
    public class RegionalBloc
    {
        [JsonProperty(propertyName: "acronym")]
        public string Acronym { get; set; }

        [JsonProperty(propertyName:"name")]
        public string Name { get; set; }
    }
}
