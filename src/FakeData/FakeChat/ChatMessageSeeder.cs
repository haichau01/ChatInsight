using Bogus;
using FakeData.FakeModels;
namespace FakeData.FakeChat
{
    public static class ChatMessageSeeder
    {
        public static List<ChatMessage> Generate(int count = 500)
        {
            var attachmentFaker = new Faker<ChatAttachment>()
                .RuleFor(a => a.ContentType, f => f.PickRandom("image/png", "application/pdf", "text/plain"))
                .RuleFor(a => a.Name, f => f.System.FileName())
                .RuleFor(a => a.ContentUrl, f => f.Internet.Url());

            var messageFaker = new Faker<ChatMessage>()
                .RuleFor(m => m.Summary, f => f.Lorem.Sentence(6))
                .RuleFor(m => m.BodyContent, f => f.Lorem.Paragraphs(1, 3))
                .RuleFor(m => m.FromUserId, f => f.Random.Guid().ToString())
                .RuleFor(m => m.FromUserDisplayName, f => f.Name.FullName())
                .RuleFor(m => m.ChannelId, f => f.Random.Guid().ToString())
                .RuleFor(m => m.TeamId, f => f.Random.Guid().ToString())
                .RuleFor(m => m.CreatedDateTime, f => f.Date.PastOffset(1))
                .RuleFor(m => m.LastModifiedDateTime, (f, m) => m.CreatedDateTime.AddMinutes(f.Random.Int(1, 60)))
                .RuleFor(m => m.IsDeleted, f => f.Random.Bool(0.05f))
                .RuleFor(m => m.Attachments, f => attachmentFaker.Generate(f.Random.Int(0, 2)));

            return messageFaker.Generate(count);
        }
    }
}
