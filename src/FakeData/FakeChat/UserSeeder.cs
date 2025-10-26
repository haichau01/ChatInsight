using Bogus;
using FakeData.FakeModels;

namespace FakeData.FakeChat
{
    public class UserSeeder
    {
        public static IEnumerable<User> Generate(int count, string emailDomain = "example.com", int seed = 0)
        {
            if (seed != 0) Randomizer.Seed = new Random(seed);

            var phoneFaker = new Faker().Phone.PhoneNumber;

            var userFaker = new Faker<User>()
                .RuleFor(u => u.Id, f => Guid.NewGuid().ToString())
                .RuleFor(u => u.GivenName, f => f.Name.FirstName())
                .RuleFor(u => u.Surname, f => f.Name.LastName())
                .RuleFor(u => u.DisplayName, (f, u) => $"{u.GivenName} {u.Surname}")
                .RuleFor(u => u.MailNickname, (f, u) => (u.GivenName + u.Surname).ToLowerInvariant())
                .RuleFor(u => u.Mail, (f, u) => $"{u.MailNickname}@{emailDomain}")
                .RuleFor(u => u.UserPrincipalName, (f, u) => $"{u.MailNickname}@{emailDomain}")
                .RuleFor(u => u.JobTitle, f => f.Name.JobTitle())
                .RuleFor(u => u.Department, f => f.Commerce.Department())
                .RuleFor(u => u.AccountEnabled, f => f.Random.Bool(0.98f))
                .RuleFor(u => u.BusinessPhones, f => new List<string> { phoneFaker("+# (###) ###-####") })
                .RuleFor(u => u.MobilePhone, f => phoneFaker("+# (###) ###-####"))
                .RuleFor(u => u.OfficeLocation, f => f.Address.City())
                .RuleFor(u => u.PreferredLanguage, f => f.PickRandom(new[] { "en-US", "vi-VN", "fr-FR", "es-ES" }))
                .RuleFor(u => u.CreatedDateTime, f => f.Date.PastOffset(5));

            return userFaker.Generate(count);
        }
    }
}
