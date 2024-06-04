using Ipsen5_groep01_frontend.Models;
using Newtonsoft.Json.Linq;

namespace Ipsen5_groep01_frontend.Services
{
    public class CandidateService
    {
        private readonly RequestMakerService _requestMakerService;

        public CandidateService(RequestMakerService requestMakerService)
        {
            _requestMakerService = requestMakerService;
        }


        public async Task<Candidate> GetCandidateById(Guid candidateId)
        {
            var response = await _requestMakerService.MakeGetRequest($"Candidate/candidatebyid/{candidateId}");
            var json = await response.Content.ReadAsStringAsync();

            var outerObject = JObject.Parse(json);
            var candidateArray = outerObject["result"]["candidateDto"];

            return ParseCandidate(candidateArray);
        }

        private Candidate ParseCandidate(JToken jToken)
        {
            var candidate = new Candidate
            {
                Id = Guid.Parse((string)jToken["id"]),
                FirstName = (string)jToken["firstName"],
                LastName = (string)jToken["lastName"],
                BSN = (string)jToken["bsn"],
                
            };

            return candidate;
        }
    }
}
