using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenKasi.Unofficial.SDK.Models.PersonsRestModels
{
    /// <summary>
    /// Rest Model : Person
    /// </summary>
    public class PersonRestModel
    {
        /// <summary>
        /// Id of Entity
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Id of Entity
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// First Name of Entity
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name of Entity
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Display Name of Entity
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Email of Entity
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Url of display image
        /// </summary>
        [JsonProperty("display_image_url")]
        public string DisplayImageUrl { get; set; }

        /// <summary>
        /// Url of the cover image
        /// </summary>
        [JsonProperty("cover_image_url")]
        public string CoverImageUrl { get; set; }
    }
}
