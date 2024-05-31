namespace Ipsen5_groep01_frontend.Services{
    public class JsonKeyConverter{

        public override string ConvertJson(string json)
        {
            return ConvertKeysToCamelCase(json);
        }
 
        private static string ConvertKeysToCamelCase(string jsonString)
        {
            using (JsonDocument document = JsonDocument.Parse(jsonString))
            {
                JsonElement root = document.RootElement;
                JsonElement newRoot = ConvertElementToCamelCase(root);
                return JsonSerializer.Serialize(newRoot);
            }
        }
    }
}