using Ipsen5_groep01_frontend.Models;
using Ipsen5_groep01_frontend.Requests;
using Newtonsoft.Json.Linq;

namespace Ipsen5_groep01_frontend.Services
{
    public class CustomerService
    {
        private readonly RequestMakerService _requestMakerService;

        public CustomerService(RequestMakerService requestMakerService)
        {
            _requestMakerService = requestMakerService;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            var response = await _requestMakerService.MakeGetRequest("customer/allcustomers");
            var json = await response.Content.ReadAsStringAsync();

            var outerObject = JObject.Parse(json);
            var customerArray = outerObject["result"]["customerDto"];

            return customerArray.Select(jToken => ParseCustomer(jToken)).ToList();
        }

        public async Task<Customer> GetCustomerById(Guid customerId)
        {
            var response = await _requestMakerService.MakeGetRequest($"customer/customerbyid/{customerId}");
            var json = await response.Content.ReadAsStringAsync();

            var outerObject = JObject.Parse(json);
            var customerArray = outerObject["result"]["customerDto"];

            return ParseCustomer(customerArray);
        }

        private Customer ParseCustomer(JToken jToken)
        {
            var customer = new Customer
            {
                Id = Guid.Parse((string)jToken["id"]),
                Name = (string)jToken["name"],
                FirstName = (string)jToken["firstName"],
                LastName = (string)jToken["lastName"],
                PhoneNumber = (string)jToken["phoneNumber"],
                KVK = (string)jToken["kvk"],
                VAT = (string)jToken["vat"],
                BankAccountNumber = (string)jToken["bankAccountNumber"],
                Email = (string)jToken["email"],
                Disabled = (bool)jToken["disabled"],
                CustomerAddressDto = new CustomerAddress
                {
                    StreetName = (string)jToken["customerAddressDto"]["streetName"],
                    HouseNumber = (string)jToken["customerAddressDto"]["houseNumber"],
                    PostalCode = (string)jToken["customerAddressDto"]["postalCode"],
                    City = (string)jToken["customerAddressDto"]["city"],
                    Country = (string)jToken["customerAddressDto"]["country"],
                    Province = (string)jToken["customerAddressDto"]["province"]
                }
            };

            return customer;
        }

        public async Task UpdateCustomer(Customer customer)
        {
            var customerRequest = new CustomerRequest
            {
                CustomerDto = customer
            };

            await _requestMakerService.MakePatchRequest("customer/updatecustomer", customerRequest);
        }
    }

}
