namespace Ipsen5_groep01_frontend.Models
{
    public class CandidateDocumentModel
    {
        public Guid Id { get; set; } // primary key

        public Guid UploadTypeId { get; set; } // foreign key to UploadType

        public Guid ContractId { get; set; } // foreign key to UploadType

        public byte[] DocumentBlob { get; set; }

        public string Status { get; set; } // new/approved/rejected

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }

    }
}
