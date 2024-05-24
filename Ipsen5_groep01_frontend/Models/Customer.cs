namespace Ipsen5_groep01_frontend.Models
{
    public class Customer
    {
        public Guid Id { get; set; } 

        public string Name { get; set; }

        public string PONumber { get; set; }

        public CustomerAddress CustomerAddressDto { get; set; }

        public Customer()
        {
            CustomerAddressDto = new CustomerAddress();
        }
    }
}
