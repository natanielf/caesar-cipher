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

    [Fact]
    public void CrackString()
    {
        string input =
            "Xli ibxirhih evq wepyxmrk kiwxyvi aew eppikih xs fi fewih sr er ergmirx Vsqer gywxsq, fyx rs orsar Vsqer asvo sj evx hitmgxw mx, rsv hsiw erc ibxerx Vsqer xibx hiwgvmfi mx. Lmwxsvmerw lezi mrwxieh hixivqmrih xlex xli kiwxyvi svmkmrexih jvsq Neguyiw-Psymw Hezmh'w 1784 temrxmrk Sexl sj xli Lsvexmm, almgl hmwtpecih e vemwih evq wepyxexsvc kiwxyvi mr er ergmirx Vsqer wixxmrk. Xli kiwxyvi erh mxw mhirxmjmgexmsr amxl ergmirx Vsqi aew ehzergih mr sxliv Jvirgl risgpewwmg evx.";

        string expected =
            "The extended arm saluting gesture was alleged to be based on an ancient Roman custom, but no known Roman work of art depicts it, nor does any extant Roman text describe it. Historians have instead determined that the gesture originated from Jacques-Louis David's 1784 painting Oath of the Horatii, which displayed a raised arm salutatory gesture in an ancient Roman setting. The gesture and its identification with ancient Rome was advanced in other French neoclassic art.";

        string decoded = CaesarCipher.Crack(input);

        Assert.Equal(expected, decoded);
    }
}
