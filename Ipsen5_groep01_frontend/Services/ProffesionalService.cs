using Ipsen5_groep01_frontend.Models;
using Newtonsoft.Json.Linq;

namespace Ipsen5_groep01_frontend.Services
{
    public class ProffesionalService
    {
        private readonly RequestMakerService _requestMakerService;

        public ProffesionalService(RequestMakerService requestMakerService)
        {
            _requestMakerService = requestMakerService;
        }

        public async Task<List<Candidate>> GetAllCandidatesAsync(string searchString)
        {
            var response = await _requestMakerService.MakeGetRequest($"Candidate/allcandidates?search={searchString}");
            var json = await response.Content.ReadAsStringAsync();

            var outerObject = JObject.Parse(json);
            var contractArray = outerObject["result"]["candidateDto"];

            
            var candidatesList = new List<Candidate>();
            foreach (var jToken in contractArray)
            {
                var candidate = new Candidate
                {
                    Id = Guid.Parse((string)jToken["id"]),
                    FirstName = (string)jToken["firstName"],
                    LastName = (string)jToken["lastName"],
                    DateOfBirth = (DateTime)jToken["dateOfBirth"],
                    BSN = (string)jToken["bsn"],
                    CreatedDate = (DateTime)jToken["createdDate"],
                    UpdatedDate = (DateTime)jToken["updatedDate"]
                };

                candidatesList.Add(candidate);
            }
            return candidatesList;
        }
    }
}
