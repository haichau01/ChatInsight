using System.Text.Json;

namespace FakeData.FakeChat
{
    public class ExportToJson
    {
        public static async Task ExportFakeMessageToJsonFile()
        {
            var messages = ChatMessageSeeder.Generate(500);
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            var fileName = $@"E:\xCode\PersonalProject\FakeData\chatMessages_{DateTime.UtcNow:yyyyMMdd_HHmmss}.json";
            var json = JsonSerializer.Serialize(messages, options);
            await File.WriteAllTextAsync(fileName, json);

        }

        public static async Task ExportFakeUserToJsonFile()
        {
            var messages = UserSeeder.Generate(500);
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            var fileName = $@"E:\xCode\PersonalProject\FakeData\users_{DateTime.UtcNow:yyyyMMdd_HHmmss}.json";
            var json = JsonSerializer.Serialize(messages, options);
            await File.WriteAllTextAsync(fileName, json);

        }
    }
}
