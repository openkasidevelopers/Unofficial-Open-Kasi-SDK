using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using OpenKasi.Unofficial.SDK.Constants;
using OpenKasi.Unofficial.SDK.Extensions;
using OpenKasi.Unofficial.SDK.Models.ErrorsRestModels;
using OpenKasi.Unofficial.SDK.Models.PersonsRestModels;

namespace OpenKasi.Unofficial.SDK.Services.Implementations
{
    public class PersonService : IPersonService
    {
        private readonly string _personsEndpoint;

        public ErrorsRestModel Error { get; set; }

        public PersonService()
        {
            _personsEndpoint = $"{Constant.BaseUri}/api/Persons";
        }

        public async Task<PersonRestModel> AddPersonAysnc(string accessToken, CreatePersonRestModel model)
        {
            using (var client = new HttpClient())
            {
                client.SetBearerToken(accessToken);
                client.DefaultRequestHeaders.Add("x-api-version", "1.0");
                var content = await client.PostAsJsonAsync(_personsEndpoint, model);
                if (content.IsSuccessStatusCode)
                    return JObject.Parse(await content.Content.ReadAsStringAsync()).ToObject<PersonRestModel>();
                Error = JObject.Parse(await content.Content.ReadAsStringAsync()).ToObject<ErrorsRestModel>();
                return null;
            }
        }

        public async Task<PersonRestModel> GetPersonByIdAsync(string accessToken, string id)
        {
            using (var client = new HttpClient())
            {
                client.SetBearerToken(accessToken);
                client.DefaultRequestHeaders.Add("x-api-version", "1.0");
                var content = await client.GetAsync($"{_personsEndpoint}/{id}");
                if (content.IsSuccessStatusCode)
                {
                    return JObject.Parse(await content.Content.ReadAsStringAsync()).ToObject<PersonRestModel>();
                }
                Error = JObject.Parse(await content.Content.ReadAsStringAsync()).ToObject<ErrorsRestModel>();
                return null;
            }
        }

        public async Task<PersonRestModel> UpdatePersonAsync(string accessToken, string id, EditPersonRestModel model)
        {
            using (var client = new HttpClient())
            {
                client.SetBearerToken(accessToken);
                client.DefaultRequestHeaders.Add("x-api-version", "1.0");
                var content = await client.PutAsJsonAsync($"{_personsEndpoint}/{id}", model);
                if (content.IsSuccessStatusCode)
                    return JObject.Parse(await content.Content.ReadAsStringAsync()).ToObject<PersonRestModel>();
                Error = JObject.Parse(await content.Content.ReadAsStringAsync()).ToObject<ErrorsRestModel>();
                return null;
            }
        }
    }
}
