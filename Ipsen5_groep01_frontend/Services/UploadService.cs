using Ipsen5_groep01_frontend.Models;
using Newtonsoft.Json.Linq;

namespace Ipsen5_groep01_frontend.Services
{
    public class UploadService
    {
        private readonly RequestMakerService _requestMakerService;

        public UploadService(RequestMakerService requestMakerService)
        {
            _requestMakerService = requestMakerService;
        }

        public async Task<List<UploadTypeModel>> GetUploadTypesByCustomerId(Guid customerId)
        {
            var response = await _requestMakerService.MakeGetRequest($"uploadtype/customerid/{customerId}");
            var json = await response.Content.ReadAsStringAsync();

            var outerObject = JObject.Parse(json);
            var uploadTypeArray = outerObject["result"]["uploadTypeDto"];

            return uploadTypeArray.Select(jToken => new UploadTypeModel
            {
                Id = Guid.Parse((string)jToken["id"]),
                Type = (string)jToken["type"],
                Required = (bool)jToken["required"]
            }).ToList();
        }
    }

}
