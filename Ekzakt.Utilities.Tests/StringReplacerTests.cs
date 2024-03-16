using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ekzakt.Utilities.Tests
{
    [TestClass()]
    public class StringReplacerTests
    {
        [TestMethod()]
        public void StringReplacerTest_NoReplacementsShouldReturnInput()
        {
            StringReplacer stringReplacer = new StringReplacer( new Dictionary<string, string>
            {
                { "Replacement", "ValueThatHasBeenReplaced" }
            });

            var input = "Text {{Replacement}} text.";
            var output = "Text ValueThatHasBeenReplaced text.";

            var result = stringReplacer.Replace(input);

            Assert.IsTrue(result == output);
        }
    }
}