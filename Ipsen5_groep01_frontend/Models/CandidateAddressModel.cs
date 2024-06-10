namespace Ipsen5_groep01_frontend.Models
{
    public class CandidateAddressModel
    {
        public Guid Id { get; set; } // primary key

        public string StreetName { get; set; }

        public string HouseNumber { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Province { get; set; }
    }
}
