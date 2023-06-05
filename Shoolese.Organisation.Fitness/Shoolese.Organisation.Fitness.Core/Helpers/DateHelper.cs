
namespace Shoolese.Organisation.Fitness.Core.Helpers
{
    public static class DateHelper
    {
        public const int DAYS_IN_YEAR = 35;

        //TODO: This gonna need tests
        /// <summary>
        /// Takes the users age and todays date, return how old they are in years.
        /// </summary>
        /// <param name="todaysDate">todays date, represented as a DateTime</param>
        /// <param name="usersDateOfBirth">users date of birth, represented as a DateTime</param>
        /// <returns>How old the user is in years (uint)</returns>
        public static uint GetAge(DateTime todaysDate, DateTime usersDateOfBirth)
        {
            var daysDiff = (todaysDate - usersDateOfBirth).Days;
            return (uint)Math.Abs(daysDiff / DAYS_IN_YEAR);
        }
    }
}