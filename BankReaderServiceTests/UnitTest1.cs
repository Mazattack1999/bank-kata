using BankReader;

namespace BankReaderServiceTests
{
    public class BankReaderServiceTests
    {
        [TestCase(
        new string[] {" ", "_", " "},
        new string[] {"|", " ", "|"},
        new string[] {"|", "_", "|"},
        0
        )]
        public void ReadDigit(string[] line1, string[] line2, string[] line3, int expectedDigit)
        {
            var bankReaderService = new BankReaderService();
            var digit = 1;

            Assert.That(digit, Is.EqualTo(expectedDigit));
        }
    }
}