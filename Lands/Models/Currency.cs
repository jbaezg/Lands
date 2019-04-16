using System;
using Newtonsoft.Json;

namespace Lands.Models
{
    public class Currency
    {
        [JsonProperty(PropertyName = "code")]  //para ocupar propiedades con mayuscula en C# ya que en json se ocupan con minusc
        public string Code { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; set; }
    }
}
