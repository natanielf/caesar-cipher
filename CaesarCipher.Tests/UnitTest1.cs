namespace CaesarCipher.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData("a", 1, "b")]
    [InlineData("b", 1, "c")]
    [InlineData("z", 1, "a")]
    [InlineData("a", 25, "z")]
    [InlineData("d", 25, "c")]
    public void EncodeSingleLetter(string letter, int shift, string encoded)
    {
        string encodedLetter = CaesarCipher.Encode(letter, shift);
        
        Assert.Equal(encoded, encodedLetter);
    }
}