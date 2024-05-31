using System.Text.Json;
using Ipsen5_groep01_frontend.Models;
using Ipsen5_groep01_frontend.Services
using Microsoft.AspNetCore.Components;

namespace Ipsen5_groep01_frontend.Services
{
    public class ContractService
    {
        private readonly RequestMakerService _requestMakerService;
        private readonly JsonKeyConverter _jsonKeyConverter;
  
        public ContractService(RequestMakerService requestMakerService, JsonKeyConvertor jsonKeyConvertor)
        {
        _requestMakerService = requestMakerService;
        _jsonKeyConverter = jsonKeyConvertor;
        }

        public List<Contract> contracts = [];

        public async Task getContractsByCandidateId(string candidateId)
        {
            string endpoint = $"Contract/contractbycandidateid/{candidateId}";
            HttpResponseMessage response = await _requestMakerService.MakeRequest(HttpMethod.Get, endpoint);
            Console.WriteLine(response);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            
            if(string.IsNullOrEmpty(jsonResponse)){
                Console.WriteLine("Je hebt geen jsonResponse ontvangen");
            }
            jsonResponse = _jsonKeyConverter.ConvertJson(jsonResponse);
            contracts = JsonSerializer.Deserialize<List<Contract>>(jsonResponse) ?? [];
            if(contracts.Count == 0){
                Console.WriteLine("Je hebt geen contracten ontvangen");
            }
        }
    }
}