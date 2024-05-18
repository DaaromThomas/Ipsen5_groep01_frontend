﻿namespace Ipsen5_groep01_frontend.Models
{
    public class Contract
    {
        public Guid Id { get; set; } // primary key

        public Guid CandidateId { get; set; } // foreign key to Candidate

        public Guid CustomerId { get; set; }

        public string Status { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double PurchaseRate { get; set; }

        public double SellingRate { get; set; }

        public string PaymentTerm { get; set; }

        public string FeeParty { get; set; }

        public string JobDescription { get; set; }

        public string Note { get; set; }

        public bool Template { get; set; }

    }
}
