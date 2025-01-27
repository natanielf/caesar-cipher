namespace CaesarCipher.Tests;
using CaesarCipher;

public class UnitTest1
{
    [Theory]
    [InlineData("hi", 1, "ij")]
    [InlineData("well hello", 4, "aipp lipps")]
    public void TestEncode(string messageToEncode, int shift, string encodedMessage)
    {
        string encodedTest = CaesarCypher.CaesarCipher.Encode(messageToEncode, shift);
        Assert.Equal(encodedMessage, encodedTest);
    }
    
    [Theory]
    [InlineData("ij", 1, "hi")]
    [InlineData("aipp lipps", 4, "well hello")]
    public void TestDecode(string messageToDecode, int shift, string decodedMessage)
    {
        string decodedTest = CaesarCypher.CaesarCipher.Decode(messageToDecode, shift);
        Assert.Equal(decodedMessage, decodedTest);
    }
}