using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenKasi.Unofficial.SDK.Models.PersonsRestModels
{
    /// <summary>
    /// Rest Model to Create User
    /// </summary>
    public class CreatePersonRestModel
    {
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
        [Required]
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Url of display image
        /// </summary>
        [Required]
        [JsonProperty("display_image_url")]
        public string DisplayImageUrl { get; set; }

        /// <summary>
        /// Url of the cover image
        /// </summary>
        [Required]
        [JsonProperty("cover_image_url")]
        public string CoverImageUrl { get; set; }
    }
}
