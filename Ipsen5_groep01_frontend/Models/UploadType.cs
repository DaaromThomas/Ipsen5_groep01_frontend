namespace Ipsen5_groep01_frontend.Models
{
    public class UploadType{
        private string type;
        public string Type{
            get { return this.type; }
            set { this.type = value; }
        }

        private string documentType;
        public string DocumentType{
            get { return this.documentType; }
            set { this.documentType = value; }
        }
        private bool required;
        public bool Required{
            get { return this.required; }
            set { this.required = value; }
        }

        public UploadType(){

        }

        public UploadType(string type, string documentType, bool required){
            this.type = type;
            this.documentType = documentType;
            this.required = required;
        }
    }
}