using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsFramework.Api.ResponseModels
{
    public class ProductRequest
    {
        [JsonProperty("front-type")]
        public string front_type { get; set; }

        public string country { get; set; }
        public string lang { get; set; }
        public string goodsId { get; set; }
    }
}
