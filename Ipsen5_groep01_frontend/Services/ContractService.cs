using Microsoft.AspNetCore.Components;

namespace Ipsen5_groep01_frontend.Services
{
    public class ContractService(RequestMakerService requestMakerService)
    {
        private readonly RequestMakerService _requestMakerService = requestMakerService;

        public async Task getContractsByCandidateId(string candidateId){
            string endpoint = $"contractbycandidateid/{candidateId}";
            HttpResponseMessage response = await _requestMakerService.MakeRequest(HttpMethod.Get, endpoint);
            Console.WriteLine(response);
        }
    }
}