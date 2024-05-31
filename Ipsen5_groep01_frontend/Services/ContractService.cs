using System.Text.Json;
using Ipsen5_groep01_frontend.Models;
using Ipsen5_groep01_frontend.Services;
using Microsoft.AspNetCore.Components;

namespace Ipsen5_groep01_frontend.Services
{
    public class ContractService
    {
        private readonly RequestMakerService _requestMakerService;

        public List<Contract> Contracts { get; private set; }
        private readonly JsonKeyConverter _jsonKeyConverter;
  
        public ContractService(RequestMakerService requestMakerService, JsonKeyConverter jsonKeyConverter)
        {
        _requestMakerService = requestMakerService;
        Contracts = new List<Contract>();
        _jsonKeyConverter = jsonKeyConverter;
        }

     

        public async Task getContractsByCandidateId(string candidateId)
        {
            string endpoint = $"Contract/contractbycandidateid/{candidateId}";
            HttpResponseMessage response = await _requestMakerService.MakeRequest(HttpMethod.Get, endpoint);
            Console.WriteLine(response);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            
            if(string.IsNullOrEmpty(jsonResponse)){
                Console.WriteLine("Je hebt geen jsonResponse ontvangen");
            }

            var options = new JsonSerializerOptions{
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            var responseWrapper = JsonSerializer.Deserialize<ResponseWrapper>(jsonResponse, options);
            if (responseWrapper?.Result?.Contracts != null){
                Contracts = responseWrapper.Result.Contracts;
                if (Contracts.Count == 0){
                    Console.WriteLine("Je hebt geen contracten ontvangen");
                }
                else
                {
                    foreach (var contract in Contracts)
                        {
                            Console.WriteLine(contract);
                        }
                }
            }
            else
            {
                Console.WriteLine("De json response bevat geen geldige content");
            }
        }
    }
}