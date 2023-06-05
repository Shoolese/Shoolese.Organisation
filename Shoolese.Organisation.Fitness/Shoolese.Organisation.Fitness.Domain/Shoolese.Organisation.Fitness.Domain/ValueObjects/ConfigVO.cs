using CSharpFunctionalExtensions;

namespace Shoolese.Organisation.Fitness.Domain.ValueObjects
{
    public class ConfigVO : ValueObject
    {
        public DateTime DateOfBirth { get; private set;}

        protected ConfigVO(){ }

        public Result<ConfigVO> Create(DateTime dateOfBirth)
        {
            //TODO: Implement
            //TODO: This is whjere the verification should live 
            //TODO: Remember, everything you add here should have tests
            //TODO: Gonna need lots of verification across the whole Shoolese.Organisation suite:Maybe have a "shared_utils" folder
            //TODO: Come to think of it, some of the functionality will need to be shared across all of the tings: Maybe have some kind of shared domain
        }

        protected override IEnumerable<IComparable> GetEqualityComponents()
        {
            yield return DateOfBirth;
        }
    }
}
