using Bogus;
using JpProject.AspNetCore.PasswordHasher.Core;

namespace JpProject.AspNetCore.PasswordHasher.Tests.Fakers
{
    public class ImprovedPasswordHasherOptionsFaker
    {
        public static Faker<ImprovedPasswordHasherOptions> GenerateRandomOptions()
        {
            return new Faker<ImprovedPasswordHasherOptions>()
                .RuleFor(a => a.OpsLimit, f => f.Random.Long(3, 16L))
                .RuleFor(a => a.MemLimit, f => f.Random.Int(1024, 1073741824))
                .RuleFor(a => a.Strenght, f => f.PickRandom<PasswordHasherStrenght>())
                .RuleFor(a => a.WorkFactor, f => f.Random.Int(4, 15))
                .RuleFor(a => a.SaltRevision, f => f.PickRandom<BcryptSaltRevision>());
        }
    }
}
