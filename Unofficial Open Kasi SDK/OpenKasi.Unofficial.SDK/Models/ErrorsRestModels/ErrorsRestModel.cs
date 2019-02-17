using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenKasi.Unofficial.SDK.Models.ErrorsRestModels
{
    /// <summary>
    /// Rest Model : Errors
    /// </summary>
    public class ErrorsRestModel
    {
        /// <summary>
        /// Reason for errors
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Errors of request
        /// </summary>
        [JsonProperty("errors")]
        public IList<string> Errors { get; set; }
    }
}
