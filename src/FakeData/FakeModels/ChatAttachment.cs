namespace FakeData.FakeModels
{
    public class ChatAttachment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ContentType { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string ContentUrl { get; set; } = default!;
    }
}
