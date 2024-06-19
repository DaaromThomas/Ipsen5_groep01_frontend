using System.Text.Json;
using Ipsen5_groep01_frontend.Models;
using Ipsen5_groep01_frontend.Services;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json.Linq;

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
            Console.WriteLine(jsonResponse);
            
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
                foreach (var contract in Contracts)
                        {
                            if(contract.CandidateDocumentsDto == null){
                                contract.CandidateDocumentsDto = new List<CandidateDocumentModel>();
                                foreach(var candidateDocument in contract.CandidateDocumentsDto){
                                    var CandidateDocumentModel = new CandidateDocumentModel{
                                        Id = candidateDocument.Id,
                                        UploadTypeId = candidateDocument.UploadTypeId,
                                        ContractId = candidateDocument.ContractId,
                                        DocumentBlob = candidateDocument.DocumentBlob,
                                        Status = candidateDocument.Status,
                                        CreatedDate = candidateDocument.CreatedDate,
                                        UpdatedDate = candidateDocument.UpdatedDate,
                                        CreatedBy = candidateDocument.CreatedBy,
                                        UpdatedBy = candidateDocument.UpdatedBy
                                    };
                                    contract.CandidateDocumentsDto.Add(CandidateDocumentModel);
                                }
                            }
                        }

                        if (Contracts.Count == 0){
                            Console.WriteLine("Je hebt geen contracten ontvangen");
                        }
                        else
                        {
                            foreach(var contract in Contracts){
                                Console.WriteLine($"Contract id: {contract.Id}");
                                if (contract.CandidateDocumentsDto != null){
                                    foreach(var candidateDocument in contract.CandidateDocumentsDto){
                                        Console.WriteLine($"    Candidate Document Id: {candidateDocument.Id}");
                                        Console.WriteLine($"    Upload Type Id: {candidateDocument.UploadTypeId}");
                                        Console.WriteLine($"    Status: {candidateDocument.Status}");
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("De json response bevat geen geldige content");
                    }
        }

        public async Task<List<Contract>> GetAllContracts(string searchString){
            var response = await _requestMakerService.MakeGetRequest($"Contract/allContracts?search={searchString}");
            var json = await response.Content.ReadAsStringAsync();

            var outerObject = JObject.Parse(json);
            var contractArray = outerObject["result"]["contractDto"];
            Contracts = [];
            return contractArray.Select(jToken => ParseContract(jToken)).ToList();
        }
        
        private Contract ParseContract(JToken jToken)
        {
            var contract = new Contract
            {
                Id = Guid.Parse((string)jToken["id"]),
                CandidateId = Guid.Parse((string)jToken["candidateId"]),
                CustomerId = Guid.Parse((string)jToken["customerId"]),
                CandidateName = (string)jToken["candidateName"],
                CustomerName = (string)jToken["customerName"],
                Status = (string)jToken["status"],
                StartDate = (DateTime)jToken["startDate"],
                EndDate = (DateTime)jToken["endDate"],
                PurchaseRate = (double)jToken["purchaseRate"],
                SellingRate = (double)jToken["sellingRate"],
                PaymentTerm = (string)jToken["paymentTerm"],
                FeeParty = (string)jToken["feeParty"],
                JobDescription = (string)jToken["jobDescription"],
                Note = (string)jToken["note"],
                Template = (bool)jToken["template"],
            };
            Contracts.Add(contract);
            return contract;
        }
    }
} 
  