using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineFreightManager.Airport
{
    // Flight implementation
    public class Airport : IAirport
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        public Airport(string code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
