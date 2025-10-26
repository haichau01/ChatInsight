namespace FakeData.FakeModels
{
    public class ChatMessage
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string MessageType { get; set; } = "message";
        public string Summary { get; set; } = default!;
        public string BodyContent { get; set; } = default!;
        public string BodyContentType { get; set; } = "html";
        public string FromUserId { get; set; } = default!;
        public string FromUserDisplayName { get; set; } = default!;
        public DateTimeOffset CreatedDateTime { get; set; }
        public DateTimeOffset LastModifiedDateTime { get; set; }
        public bool IsDeleted { get; set; }
        public string ChannelId { get; set; } = default!;
        public string TeamId { get; set; } = default!;
        public List<ChatAttachment> Attachments { get; set; } = new();
    }
}
