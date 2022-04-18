using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace ListDemo.Models
{
    public partial class Shop
    {
        [JsonProperty("ShopName")]
        public string ShopName { get; set; }

        [JsonProperty("District")]
        public string District { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Latitude")]
        public string Latitude { get; set; }

        [JsonProperty("Longitude")]
        public string Longitude { get; set; }
    }

    public partial class Shop
    {
        public static Shop FromJson(string json) => JsonConvert.DeserializeObject<Shop>(json, ListDemo.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Shop self) => JsonConvert.SerializeObject(self, ListDemo.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
