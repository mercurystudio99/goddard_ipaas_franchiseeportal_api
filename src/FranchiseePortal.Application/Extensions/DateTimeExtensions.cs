using System;

namespace FranchiseePortal.Extensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Returns a <see cref="DateTime"/> object that will be compatible with API <see cref="DateOnly"/>
        /// types
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        /// <remarks>
        /// This method will return a <see cref="DateTime"/> instance for UTC start of day with <see cref="DateTimeKind.Unspecified"/>.  
        /// <para>
        /// If the local machine has Local timezone with an offset of -4 and the instance is DateTimeKind.Local with date and time 2000-12-31T23:00:00,
        /// this will return a date and time of 2001-01-01T00:00:00
        /// </para>
        /// </remarks>
        public static DateTime ToApiDateOnlyCompatibleDateTime(this DateTime dateTime)
        {
            if(dateTime.Kind == DateTimeKind.Unspecified)
            {
                // DateTime kind is unspecified, assuming it is a UTC date
                return dateTime.Date;
            }

            var result = dateTime.ToUniversalTime().Date;
            // 2. API date-only parameters might be DateOnly and will fail if offset/timezone is specified
            // so need to make sure DateTimeKind.Unspecified to avoid that
            result = DateTime.SpecifyKind(result, DateTimeKind.Unspecified);
            return result;
        }
    }
}
