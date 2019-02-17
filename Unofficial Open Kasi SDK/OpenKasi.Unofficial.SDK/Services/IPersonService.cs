using OpenKasi.Unofficial.SDK.Models.ErrorsRestModels;
using OpenKasi.Unofficial.SDK.Models.PersonsRestModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenKasi.Unofficial.SDK.Services
{
    /// <summary>
    /// Provides endpoints to access users' details
    /// </summary>
    public interface IPersonService
    {
        /// <summary>
        /// Error Details
        /// </summary>
        ErrorsRestModel Error { get; set; }

        /// <summary>
        /// Gets a person by their id
        /// </summary>
        /// <param name="accessToken">Access Token obtained after authentication</param>
        /// <param name="id">Id of Person</param>
        /// <returns>Person's Details</returns>
        Task<PersonRestModel> GetPersonByIdAsync(string accessToken, string id);

        /// <summary>
        /// Add's a person
        /// </summary>
        /// <param name="accessToken">Access Token obtained after authentication</param>
        /// <param name="model">Id of Person</param>
        /// <returns>Person's Details</returns>
        Task<PersonRestModel> AddPersonAysnc(string accessToken, CreatePersonRestModel model);

        /// <summary>
        /// Update a person 
        /// </summary>
        /// <param name="accessToken">Access Token obtained after authentication</param>
        /// <param name="id">Person's Id</param>
        /// <param name="model">Person's Details</param>
        /// <returns>Person's Details</returns>
        Task<PersonRestModel> UpdatePersonAsync(string accessToken, string id, EditPersonRestModel model);
    }
}
