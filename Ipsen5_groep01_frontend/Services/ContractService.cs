using System.Text.Json;
using Ipsen5_groep01_frontend.Models;
using Microsoft.AspNetCore.Components;

namespace Ipsen5_groep01_frontend.Services
{
    public class ContractService
    {
        private readonly RequestMakerService _requestMakerService;

        public List<Contract> contracts = [];

        public async Task getContractsByCandidateId(string candidateId)
        {
            string endpoint = $"Contract/contractbycandidateid/{candidateId}";
            HttpResponseMessage response = await _requestMakerService.MakeRequest(HttpMethod.Get, endpoint);
            string jsonResponse = await response.Content.ReadAsStringAsync();
                if(string.IsNullOrEmpty(jsonResponse)){
                    Console.WriteLine("Je hebt geen jsonResponse ontvangen");
                }
                contracts = JsonSerializer.Deserialize<List<Contract>>(jsonResponse) ?? [];
                if(contracts.Count == 0){
                    Console.WriteLine("Je hebt geen contracten ontvangen");
                }
        }
    }
}