using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OpenKasi.Unofficial.SDK.Models.PersonsRestModels
{
    /// <summary>
    /// Rest Model : Edit Preson
    /// </summary>
    public class EditPersonRestModel
    {
        /// <summary>
        /// First Name of Entity
        /// </summary>
        [Required]
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name of Entity
        /// </summary>
        [Required]
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Display Name of Entity
        /// </summary>
        [Required]
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }
}
