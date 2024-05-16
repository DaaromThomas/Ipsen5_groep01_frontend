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

        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
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
        public bool Required
        {
            get;
            set;
        }

        private string extention;
        public string Extention
        {
            get;
            set;
        } 

        public Document()
        {
            // Default constructor
        }

        public Document(string id, string name, string uploadType, string documentPath, string status, DateTime createdDate, DateTime updatedDate, string createdBy, bool required, string extention)
        {
            this.Id = id;
            this.Name = name;
            this.UploadType = uploadType;
            this.DocumentPath = documentPath;
            this.Status = status;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
            this.CreatedBy = createdBy;
            this.Required = required;
            this.Extention = extention;
        }

    }
}
