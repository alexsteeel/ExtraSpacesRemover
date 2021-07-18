using NUnit.Framework;

namespace ExtraSpacesRemover.UnitTests
{
    public class StringExtensionsTests
    {
        [TestCase("", ExpectedResult = "")]
        [TestCase("_", ExpectedResult = "")]
        [TestCase("___", ExpectedResult = "")]
        [TestCase("1_2", ExpectedResult = "1_2")]
        [TestCase("111_222", ExpectedResult = "111_222")]
        [TestCase("1__2", ExpectedResult = "1_2")]
        [TestCase("_1__2_", ExpectedResult = "1_2")]
        [TestCase("_____1____2____", ExpectedResult = "1_2")]
        [TestCase("_On__my___home_world", ExpectedResult = "On_my_home_world")]
        public string RemoveExtraSpaces_ReturnCorrectResult(string input)
        {
            return input.RemoveExtraSpaces();
        }
    }
}