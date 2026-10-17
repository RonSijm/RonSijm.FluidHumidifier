using Newtonsoft.Json;

namespace FruitVendor.AWS.NimbusFactory.CLI.Models.Events
{
    public class EventPattern
    {
        [JsonProperty("source")]
        public string[] Source { get; set; }

        [JsonProperty("detail-type")]
        public string[] DetailType { get; set; }
    }
}
