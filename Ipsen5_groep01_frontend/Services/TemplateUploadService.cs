namespace Ipsen5_groep01_frontend.Services{
    public class TemplateUploadService{
        private List<BinaryDocument> _documents = [];

        public void ClearDocuments(){
            _documents.Clear();
        }

        public void AddDocument(BinaryDocument document){
            _documents.Add(document);
        }

        public void RemoveDocument(BinaryDocument document){
            _documents.Remove(document);
        }

        public List<BinaryDocument> GetAllDocuments(){
            return _documents;
        }
    }

    public class BinaryDocument{
        private byte[] _bytes;
        private string _fileName;

        public BinaryDocument(byte[] bytes, string name){
            _bytes = bytes;
            _fileName = name;
        }

        public string GetFileName(){
            return _fileName;
        }

        public byte[] GetBytes(){
            return _bytes;
        }

        public void SetFileName(string name){
            _fileName = name;
        }

        public void SetBytes(byte[] bytes){
            _bytes = bytes;
        }
    }

}