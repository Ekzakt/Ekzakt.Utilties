using Ekzakt.Utilities.Extentions;
using Ekzakt.Utilities.Validation.Regex;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Ekzakt.Utilities.Tests.Validation.Regex;


[TestClass()]
public class InternetTests
{
    [TestMethod()]
    public void EmailAddress_Valid()
    {
        var value = "mail@johndoe.com";

        var result = System.Text.RegularExpressions.Regex.IsMatch(value, Internet.EMAIL_ADDRESS);

        Assert.IsTrue(result == true);
    }


    [TestMethod()]
    public void EmailAddress_InvalidNoAtCharater()
    {
        var value = "mailjohndoe.com";

        var result = System.Text.RegularExpressions.Regex.IsMatch(value, Internet.EMAIL_ADDRESS);

        Assert.IsTrue(result == false);
    }


    [TestMethod()]
    public void EmailAddress_InvalidNoDotCharacter()
    {
        var value = "mail@johndoecom";

        var result = System.Text.RegularExpressions.Regex.IsMatch(value, Internet.EMAIL_ADDRESS);

        Assert.IsTrue(result == false);
    }
}