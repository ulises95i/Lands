
using Newtonsoft.Json;

namespace lands.Models
{
    public class Currency
    {
        //Nomenclaruta C# Inicio de variables con mayusculas ::: 
        //Formateamos las fechas para que no haya problema al cambiar de nombre las propiedes del json
        [JsonProperty(propertyName: "code")]
        public string code { get; set; }

        [JsonProperty(propertyName:"name")]
        public string Name { get; set; }

        [JsonProperty(propertyName: "symbol")]
        public string Symbol { get; set; }
    }
}
