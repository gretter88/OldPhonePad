using NUnit.Framework;

namespace OldPhonePadApp.Tests
{
    public class OldPhonePadTests
    {
        [TestCase("33#", ExpectedResult = "E")]
        [TestCase("227*#", ExpectedResult = "B")]
        [TestCase("4433555 555666#", ExpectedResult = "HELLO")]
        [TestCase("8 88777444666*664#", ExpectedResult = "TOO")]
        [TestCase("222 2 22#", ExpectedResult = "CAB")]
        [TestCase("777777#", ExpectedResult = "S")]
        [TestCase("*#", ExpectedResult = "")]
        [TestCase("4*4*4*#", ExpectedResult = "")]
        public string ShouldConvertOldPhoneInputCorrectly(string input)
        {
            return OldPhonePad.Convert(input);
        }
    }
}