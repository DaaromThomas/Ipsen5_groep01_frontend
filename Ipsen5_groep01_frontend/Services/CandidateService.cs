using Ipsen5_groep01_frontend.Models;
using Ipsen5_groep01_frontend.Requests;
using Newtonsoft.Json.Linq;

namespace Ipsen5_groep01_frontend.Services
{
    public class CandidateService
    {
        private readonly RequestMakerService _requestMakerService;
        private readonly List<Candidate> _candidates = [];

        public CandidateService(RequestMakerService requestMakerService)
        {
            _requestMakerService = requestMakerService;
        }


        public async Task<List<Candidate>> GetAllCandidates()
    {
        var response = await _requestMakerService.MakeGetRequest("Candidate/allCandidates");
        var json = await response.Content.ReadAsStringAsync();

        var outerObject = JObject.Parse(json);
        var contractArray = outerObject["result"]["candidateDto"];


        foreach (var jToken in contractArray)
        {
            var candidate = new Candidate();
            candidate.Id = Guid.Parse((string)jToken["id"]);
            candidate.FirstName = (string)jToken["firstName"];
            candidate.LastName = (string)jToken["lastName"];
            candidate.DateOfBirth = (DateTime)jToken["dateOfBirth"];
            candidate.BSN = (string)jToken["bsn"];
            candidate.CreatedDate = (DateTime)jToken["createdDate"];
            candidate.UpdatedDate = (DateTime)jToken["updatedDate"];

            _candidates.Add(candidate);
        }

        return _candidates;
        }

       

        public async Task<Candidate> GetCandidateById(Guid candidateId)
        {
            var response = await _requestMakerService.MakeGetRequest($"Candidate/candidatebyid/{candidateId}");
            var json = await response.Content.ReadAsStringAsync();

            var outerObject = JObject.Parse(json);
            var candidateArray = outerObject["result"]["candidateDto"];

            return ParseCandidate(candidateArray);
        }


        public async Task CreateCandidate(RegisterUserRequest request)
        {
            var response = await _requestMakerService.MakePostRequest("Candidate/Candidate", request);
        }


        public async Task<Boolean>CreateUserCandidate(RegisterUserRequest request)
        {
            bool requestSucceed = false;
            try
            {
                var response = await _requestMakerService.MakePostRequest("user/signup", request);

                requestSucceed = true;
            }
            catch (Exception ex)
            {
                requestSucceed = false;
            }

            return requestSucceed;
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
