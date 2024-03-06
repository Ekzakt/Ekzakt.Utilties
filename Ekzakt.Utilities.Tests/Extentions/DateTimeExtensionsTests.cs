using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ekzakt.Utilities.Extentions.Tests;

[TestClass()]
public class DateTimeExtensionsTests
{
    [TestMethod()]
    public void TimeAgoTest_ShouldReturn_Now()
    {
        var result = DateTime.Now.AddSeconds(-9).TimeAgo(true);

        Assert.IsTrue(result == "Now");
    }

    [TestMethod()]
    public void TimeAgoTest_ShouldReturn_SecondsAgo_11()
    {
        var result = DateTime.Now.AddSeconds(-11).TimeAgo(true);

        Assert.IsTrue(result == "11 seconds ago");
    }


    [TestMethod()]
    public void TimeAgoTest_ShouldReturn_SecondsAgo_35()
    {
        var result = DateTime.Now.AddSeconds(-35).TimeAgo(true);

        Assert.IsTrue(result == "35 seconds ago");
    }


    [TestMethod()]
    public void TimeAgoTest_ShouldReturn_MinuteAgo_01()
    {
        var result = DateTime.Now.AddMinutes(-1).TimeAgo(true);

        Assert.IsTrue(result == "1 minute ago");
    }

    [TestMethod()]
    public void TimeAgoTest_ShouldReturn_MinutesAgo_05()
    {
        var result = DateTime.Now.AddMinutes(-5).TimeAgo(true);

        Assert.IsTrue(result == "5 minutes ago");
    }

    [TestMethod()]
    public void TimeAgoTest_ShouldReturn_HourAgo_01()
    {
        var result = DateTime.Now.AddHours(-1).TimeAgo(true);

        Assert.IsTrue(result == "1 hour ago");
    }


    [TestMethod()]
    public void TimeAgoTest_ShouldReturn_HoursAgo_06()
    {
        var result = DateTime.Now.AddHours(-6).TimeAgo(true);

        Assert.IsTrue(result == "6 hours ago");
    }


    [TestMethod()]
    public void TimeAgoTest_ShouldReturn_HoursAgo_23()
    {
        var result = DateTime.Now.AddHours(-23).TimeAgo(true);

        Assert.IsTrue(result == "23 hours ago");
    }


    [TestMethod()]
    public void TimeAgoTest_ShouldReturn_DayAgo_01()
    {
        var result = DateTime.Now.AddDays(-1).TimeAgo(true);

        Assert.IsTrue(result == "1 day ago");
    }


    [TestMethod()]
    public void TimeAgoTest_ShouldReturn_DaysAgo_05()
    {
        var result = DateTime.Now.AddDays(-5).TimeAgo(true);

        Assert.IsTrue(result == "5 days ago");
    }


    [TestMethod()]
    public void TimeAgoTest_ShouldReturn_MonthsAgo_01_SubstractingDays_30()
    {
        var result = DateTime.Now.AddDays(-30).TimeAgo(true);

        Assert.IsTrue(result == "1 month ago");
    }


    [TestMethod()]
    public void TimeAgoTest_ShouldReturn_MonthsAgo_01_SubstractingDays_44()
    {
        var result = DateTime.Now.AddDays(-44).TimeAgo(true);

        Assert.IsTrue(result == "1 month ago");
    }


    [TestMethod()]
    public void TimeAgoTest_ShouldReturn_MonthsAgo_02()
    {
        var result = DateTime.Now.AddDays(-45).TimeAgo(true);

        Assert.IsTrue(result == "2 months ago");
    }


    [TestMethod()]
    public void TimeAgoTest_ShouldReturn_YearAgo_01()
    {
        var result = DateTime.Now.AddDays(-547).TimeAgo(true);

        Assert.IsTrue(result == "1 year ago");
    }


    [TestMethod()]
    public void TimeAgoTest_ShouldReturn_YearsAgo_02()
    {
        var result = DateTime.Now.AddDays(-550).TimeAgo(true);

        Assert.IsTrue(result == "2 years ago");
    }
}