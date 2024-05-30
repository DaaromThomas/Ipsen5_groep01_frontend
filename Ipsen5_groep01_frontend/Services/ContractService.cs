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
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                contracts = JsonSerializer.Deserialize<List<Contract>>(jsonResponse);
            }
            else
            {
                // Log the error or handle it accordingly
                Console.WriteLine($"Error: {response.StatusCode}");
            }
        }
    }
}