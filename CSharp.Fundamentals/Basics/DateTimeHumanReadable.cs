using System;

namespace CSharp.Fundamentals.Basics
{
    /// <summary>
    /// Pretty Dates
    /// </summary>
    class DateTimeHumanReadable
    {
        static void Main()
        {
            Console.WriteLine(FormatDateFunction(DateTime.UtcNow.AddDays(-5), DateTime.UtcNow)); // 5 days ago
        }

        static string FormatDateFunction(DateTime requestedDate, DateTime currentDate)
        {
            TimeSpan timeSpanDate = currentDate.Subtract(requestedDate);

            int dayDiff = (int)timeSpanDate.TotalDays;

            int secDiff = (int)timeSpanDate.TotalSeconds;

            if (dayDiff < 0 || dayDiff >= 31)
                return null;

            if (dayDiff == 0)
            {
                if (secDiff < 60)
                    return "just now";
              
                if (secDiff < 120)
                    return "1 minute ago";
                
                if (secDiff < 3600)
                    return string.Format("{0} minutes ago", Math.Floor((double)secDiff / 60));
               
                if (secDiff < 7200)
                    return "1 hour ago";
                
                if (secDiff < 86400)
                    return string.Format("{0} hours ago", Math.Floor((double)secDiff / 3600));
            }
           
            if (dayDiff == 1)
                return "yesterday";

            if (dayDiff < 7)
                return string.Format("{0} days ago",dayDiff);

            if (dayDiff < 31)
                return string.Format("{0} weeks ago", Math.Ceiling((double)dayDiff / 7));

            return null;
        }

        // Will improve it later using Pattern-Matching
        //static string DaysGenerator(int dayDiff, int secDiff) => (dayDiff, secDiff) switch
        //{
        //};
    }
}
