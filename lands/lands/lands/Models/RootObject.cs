namespace lands.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    public class RootObject
    {

        [JsonProperty(propertyName: "name")]
        public string Name { get; set; }

        [JsonProperty(propertyName: "topLevelDomain")]
        public List<string> TopLevelDomain { get; set; }

        [JsonProperty(propertyName: "alpha2Code")]
        public string Alpha2Code { get; set; }

        [JsonProperty(propertyName: "alpha3Code")]
        public string Alpha3Code { get; set; }

        [JsonProperty(propertyName: "callingCodes")]
        public List<string> CallingCodes { get; set; }

        [JsonProperty(propertyName: "capital")]
        public string Capital { get; set; }

        [JsonProperty(propertyName: "altSpellings")]
        public List<string> AltSpellings { get; set; }

        [JsonProperty(propertyName: "region")]
        public string Region { get; set; }

        [JsonProperty(propertyName: "subregion")]
        public string Subregion { get; set; }

        [JsonProperty(propertyName: "population")]
        public int Population { get; set; }

        [JsonProperty(propertyName: "latlng")]
        public List<double> Latlng { get; set; }

        [JsonProperty(propertyName: "demonym")]
        public string Demonym { get; set; }

        [JsonProperty(propertyName: "area")]
        public double? Area { get; set; }

        [JsonProperty(propertyName: "gini")]
        public double? Gini { get; set; }

        [JsonProperty(propertyName: "timezones")]
        public List<string> Timezones { get; set; }

        [JsonProperty(propertyName: "borders")]
        public List<string> Borders { get; set; }

        [JsonProperty(propertyName: "nativeName")]
        public string NativeName { get; set; }

        [JsonProperty(propertyName: "numericCode")]
        public string NumericCode { get; set; }

        [JsonProperty(propertyName: "currencies")]
        public List<Currency> Currencies { get; set; }

        [JsonProperty(propertyName: "languages")]
        public List<Language> Languages { get; set; }

        [JsonProperty(propertyName: "translations")]
        public Translations Translations { get; set; }

        [JsonProperty(propertyName: "flag")]
        public string Flag { get; set; }

        [JsonProperty(propertyName: "regionalBlocs")]
        public List<RegionalBloc> RegionalBlocs { get; set; }

        [JsonProperty(propertyName: "cioc")]
        public string Cioc { get; set; }
    }
}
