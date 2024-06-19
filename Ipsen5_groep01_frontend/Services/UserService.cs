using System.Text.Json;
using Ipsen5_groep01_frontend.Models;
using Ipsen5_groep01_frontend.Services;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json.Linq;

namespace Ipsen5_groep01_frontend.Services
{
    public class UserService
    {
        private readonly RequestMakerService _requestMakerService;
        public List<Contract> Contracts { get; private set; }
  
        public UserService(RequestMakerService requestMakerService)
        {
        _requestMakerService = requestMakerService;
        Contracts = new List<Contract>();
        }
        
        public async Task<List<User>> GetAllUsers(string searchString){
            var response = await _requestMakerService.MakeGetRequest($"user/getallusers?search={searchString}");
            var json = await response.Content.ReadAsStringAsync();

            var outerObject = JObject.Parse(json);
            var userArray = outerObject?["result"]?["userDto"];

            if(userArray == null){
                return [];
            }

            return userArray.Select(jToken => ParseUser(jToken)).ToList();
        }

        public async Task<List<User>> GetAllAdmins(string searchString){
            var response = await _requestMakerService.MakeGetRequest($"user/getalladmins?search={searchString}");
            var json = await response.Content.ReadAsStringAsync();

            var outerObject = JObject.Parse(json);
            var userArray = outerObject?["result"]?["userDto"];

            if(userArray == null){
                return [];
            }

            return userArray.Select(jToken => ParseUser(jToken)).ToList();
        }
        
        
        private User ParseUser(JToken jToken)
        {
            var user = new User
            {
                Id = Guid.Parse((string)jToken["id"]),
                FirstName = (string)jToken["firstName"],
                LastName = (string)jToken["lastName"],
                Email = (string)jToken["email"],
                IsActive = (bool)jToken["isActive"],
            };

            return user;
        }
    }
} 
  