using System.Collections.Generic;
using Newtonsoft.Json;

namespace OnePermissionsApi.Model
{
    public class UserPermissions
    {
        [JsonProperty(PropertyName = "alias")]
        public string Alias { get; set; }

        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "permissions")]
        public List<Permissions> Permissions { get; set; }
    }
}
