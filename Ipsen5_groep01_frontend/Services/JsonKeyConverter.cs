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

        private static JsonElement ConvertElementToCamelCase(JsonElement element)
        {
            switch (element.ValueKind)
            {
                case JsonValueKind.Object:
                    var dictionary = new Dictionary<string, JsonElement>();
                    foreach (JsonProperty property in element.EnumerateObject())
                    {
                        string camelCaseKey = ToCamelCase(property.Name);
                        dictionary[camelCaseKey] = ConvertElementToCamelCase(property.Value);
                    }
                    return JsonDocument.Parse(JsonSerializer.Serialize(dictionary)).RootElement;

                case JsonValueKind.Array:
                    var list = new List<JsonElement>();
                    foreach (JsonElement item in element.EnumerateArray())
                    {
                        list.Add(ConvertElementToCamelCase(item));
                    }
                    return JsonDocument.Parse(JsonSerializer.Serialize(list)).RootElement;

                default:
                    return element;
            }
        }

        private static string ToCamelCase(string snakeCaseString)
        {
            return Regex.Replace(snakeCaseString, "_[a-z]", match => match.Value[1].ToString().ToUpper());
        }
    }
}