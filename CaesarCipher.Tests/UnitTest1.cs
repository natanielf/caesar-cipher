namespace CaesarCipher.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData("a", 1, "b")]
    [InlineData("b", 1, "c")]
    [InlineData("z", 1, "a")]
    [InlineData("a", 25, "z")]
    [InlineData("d", 25, "c")]
    [InlineData("A", 1, "B")]
    [InlineData("Z", 1, "A")]
    [InlineData("C", 24, "A")]
    public void EncodeSingleAsciiLetter(string letter, int shift, string expected)
    {
        string encoded = CaesarCipher.Encode(letter, shift);
        
        Assert.Equal(expected, encoded);
    }
    
    [Theory]
    [InlineData("b", 1, "a")]
    [InlineData("c", 1, "b")]
    [InlineData("a", 1, "z")]
    [InlineData("z", 25, "a")]
    [InlineData("c", 25, "d")]
    [InlineData("B", 1, "A")]
    [InlineData("A", 1, "Z")]
    [InlineData("A", 24, "C")]
    public void DecodeSingleAsciiLetter(string letter, int shift, string expected)
    {
        string decoded = CaesarCipher.Decode(letter, shift);
        
        Assert.Equal(expected, decoded);
    }
}
