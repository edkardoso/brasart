namespace Brasart.Domain.Common.Extensions
{
    public static class HoursMinutesExtensions
    {
        public static int ConvertToMinutes(this int hours) => hours * 60;

        public static int ConvertToHours(this int minutes) => minutes / 60;
    }

   

}
