using Newtonsoft.Json;

namespace OnePermissionsApi.Model
{
    public class Permissions
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        [JsonProperty(PropertyName = "contact")]
        public string Contact { get; set; }
    }
}
