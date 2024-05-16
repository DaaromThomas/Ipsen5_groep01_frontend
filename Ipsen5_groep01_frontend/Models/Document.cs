namespace Ipsen5_groep01_frontend.Models
{
    public class Document
    {
        private string id;
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        } 

        private string uploadType;
        public string UploadType
        {
            get { return this.uploadType; }
            set { this.uploadType = value; }
        }  

        private string documentPath; 
        // KAN NOG AANGEPAST WORDEN
        public string DocumentPath
        {
            get { return this.documentPath; }
            set { this.documentPath = value; }
        }  

        private string status;
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }  

        private DateTime createdDate;
        public DateTime CreatedDate
        {
            get { return this.createdDate; }
            set { this.createdDate = value; }
        }  

        private DateTime updatedDate;
        public DateTime UpdatedDate
        {
            get { return this.updatedDate; }
            set { this.updatedDate = value; }
        }  

        private string createdBy;
        public string CreatedBy
        {
            get { return this.createdBy; }
            set { this.createdBy = value; }
        }  

        private bool required;
        public bool Required{
            get { return this.required; }
            set { this.required = value; }
        }

        private string documentType;
        public string DocumentType{
            get { return this.documentType; }
            set { this.documentType = value; }
        }

        public Document()
        {
            // Default constructor
        }

        public Document(string id, string uploadType, string documentPath, string status, DateTime createdDate, DateTime updatedDate, string createdBy)
        {
            this.Id = id;
            this.UploadType = uploadType;
            this.DocumentPath = documentPath;
            this.Status = status;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
            this.CreatedBy = createdBy;

        }

    }
}
