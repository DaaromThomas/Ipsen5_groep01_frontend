using Microsoft.AspNetCore.Components;

namespace Ipsen5_groep01_frontend.Services
{
  public class ContractService
{
    private readonly RequestMakerService _requestMakerService;

    public ContractService(RequestMakerService requestMakerService)
    {
        _requestMakerService = requestMakerService;
    }

    public async Task GetContractsByCandidateId(string candidateId)
    {
        string endpoint = $"Contract/contractbycandidateid/{candidateId}";
        HttpResponseMessage response = await _requestMakerService.MakeRequest(HttpMethod.Get, endpoint);
        Console.WriteLine(response);
    }
}
}