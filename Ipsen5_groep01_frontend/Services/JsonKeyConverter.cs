using System.Text.Json;
using System.Text.RegularExpressions;

namespace Ipsen5_groep01_frontend.Services{
    public class JsonKeyConverter{

        public string ConvertJson(string json)
        {
            return ConvertKeysToPascalCase(json);
        }
 
        public static string ConvertKeysToPascalCase(string jsonString)
        {
            using (JsonDocument document = JsonDocument.Parse(jsonString))
            {
                JsonElement root = document.RootElement;
                JsonElement newRoot = ConvertElementToPascalCase(root);
                return JsonSerializer.Serialize(newRoot);
            }
        }

        private static JsonElement ConvertElementToPascalCase(JsonElement element)
        {
            switch (element.ValueKind)
            {
                case JsonValueKind.Object:
                    var dictionary = new Dictionary<string, JsonElement>();
                    foreach (JsonProperty property in element.EnumerateObject())
                    {
                        string pascalCaseKey = ToPascalCase(property.Name);
                        dictionary[pascalCaseKey] = ConvertElementToPascalCase(property.Value);
                    }
                    return JsonDocument.Parse(JsonSerializer.Serialize(dictionary)).RootElement;

                case JsonValueKind.Array:
                    var list = new List<JsonElement>();
                    foreach (JsonElement item in element.EnumerateArray())
                    {
                        list.Add(ConvertElementToPascalCase(item));
                    }
                    return JsonDocument.Parse(JsonSerializer.Serialize(list)).RootElement;

                default:
                    return element;
            }
        }

        private static string ToPascalCase(string snakeCaseString)
        {
            return Regex.Replace(snakeCaseString, "(?:^|_)(.)", match => match.Groups[1].Value.ToUpper());
        }
    }
}