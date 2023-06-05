using CSharpFunctionalExtensions;
using Shoolese.Organisation.DayPlan.Domain.DataModels.Entities;

namespace Shoolese.Organisation.DayPlan.Domain.DataModels.EntityValueObjects
{
    public class HighLevelTaskVO : ValueObject
    {
        protected HighLevelTaskVO()
        {
            
        }

        public static Result<HighLevelTaskVO> Create()
        {

        }

        public HighLevelTaskEntity ToEntity() 
            => new HighLevelTaskEntity()
            {

            };

        protected override IEnumerable<IComparable> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
