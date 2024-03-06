namespace Ekzakt.Utilities.Extentions;

public static class DateTimeExtensions
{
    /// <summary>
    /// Returns a string representing the time elapsed since the specified DateTime object.
    /// </summary>
    /// <param name="dateTime">The DateTime object to calculate the time elapsed from.</param>
    /// <returns>A string representing the time elapsed since the specified DateTime object.</returns>
    public static string TimeAgo(this DateTime dateTime, bool doNotUserUtc = false)
    {
        TimeSpan timeSince = DateTime.UtcNow.Subtract(dateTime);

        if (doNotUserUtc)
        {
            timeSince = DateTime.Now.Subtract(dateTime);
        }

        if (timeSince.TotalSeconds < 10)
        {
            return "Now";
        }
        else if (timeSince.TotalSeconds < 60)
        {
            int seconds = (int)timeSince.TotalSeconds;
            return $"{seconds} {(seconds == 1 ? "second" : "seconds")} ago";
        }
        else if (timeSince.TotalMinutes < 60)
        {
            int minutes = (int)timeSince.TotalMinutes;
            return $"{minutes} {(minutes == 1 ? "minute" : "minutes")} ago";
        }
        else if (timeSince.TotalHours < 24)
        {
            int hours = (int)timeSince.TotalHours;
            return $"{hours} {(hours == 1 ? "hour" : "hours")} ago";
        }
        else if (timeSince.TotalDays < DateTime.DaysInMonth(dateTime.Year, dateTime.Month))
        {
            int days = (int)timeSince.TotalDays;
            return $"{days} day{(days == 1 ? "" : "s")} ago";
        }
        else if (timeSince.TotalDays < 365)
        {
            var months = Math.Round((double)(timeSince.TotalDays / 30));
            return $"{months} {(months == 1 ? "month" : "months")} ago";
        }
        else
        {
            var years = Math.Round((double)(timeSince.TotalDays / 365.25)); // Considering leap years
            return $"{years} year{(years == 1 ? "" : "s")} ago";
        }
    }
}
