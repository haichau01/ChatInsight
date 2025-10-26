namespace FakeData.FakeModels
{
    public class User
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string DisplayName { get; set; } = default!;
        public string GivenName { get; set; } = default!;
        public string Surname { get; set; } = default!;
        public string Mail { get; set; } = default!;
        public string UserPrincipalName { get; set; } = default!;
        public string MailNickname { get; set; } = default!;
        public string JobTitle { get; set; } = default!;
        public string Department { get; set; } = default!;
        public bool AccountEnabled { get; set; } = true;
        public List<string> BusinessPhones { get; set; } = new();
        public string? MobilePhone { get; set; }
        public string? OfficeLocation { get; set; }
        public string? PreferredLanguage { get; set; }
        public DateTimeOffset CreatedDateTime { get; set; }
        // Normalized / searchable fields for Solr
        public string NormalizedDisplayName => DisplayName?.ToLowerInvariant() ?? "";
        public string SearchText => $"{DisplayName} {GivenName} {Surname} {Mail} {JobTitle} {Department}";
    }
}
