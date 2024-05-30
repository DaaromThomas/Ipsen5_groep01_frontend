using Ipsen5_groep01_frontend.Models;
namespace Ipsen5_groep01_frontend.Services{
    public class ContractService{
        private RequestMakerService requestMakerService;
        public async Task getContractsByCandidateId(string candidateId){
            string endpoint = $"contractbycandidateid/{candidateId}";
            HttpResponseMessage response = await this.requestMakerService.MakeRequest(HttpMethod.Get, endpoint);
            Console.WriteLine(response);
        }
    }
}