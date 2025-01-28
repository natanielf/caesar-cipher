using CaesarCipher;
namespace CaesarCipher.Tests;


public class UnitTest1
{
    [Fact]
    public void ReturnsCorrectEncodeForSingleMessageInput()
    {
        //Arrange
        string message = "sandie";
        int shift = 4;
        
        //Act
        string encoded = CaesarCipher.Encode(message, shift);
        
        //Assert
        Assert.Equal("werhmi", encoded);
    }
    
    //TODO: Test Multiple Word Input
    [Fact]
    public void ReturnsCorrectEncodeForMultipleWordMessageInput()
    {
        
    }
    
    //TODO: Test Upper and Lower Case
    [Fact]
    public void ReturnsCorrectEncodeForUpperAndLowerCaseMessageInput()
    {
        //Arrange
        string message = "Sandie";
        int shift = 4;
        
        //Act
        string encoded = CaesarCipher.Encode(message, shift);
        
        //Assert
    }
    //TODO: Test Leading and Trailing Spaces
    [Fact]
    public void ReturnsCorrectEncodeForMessageWithLeadingAndTrailingSpaces()
    {
        //Arrange
        string message = " sandie ";
        int shift = 4;
        
        //Act
        string encoded = CaesarCipher.Encode(message, shift);
        
        //Assert
        
    }
    
    //TODO: Test Non-Alpha Characters
    [Fact]
    public void ReturnsCorrectEncodeForMessageWithNonAlphaCharacters()
    {
        
    }
    //TODO: Test Null Input
    [Fact]
    public void ReturnsEmptyEncodeForNullMessageInput()
    {
        //Arrange
        string message = null;
        int shift = 4;
        
        //Act
        string encoded = CaesarCipher.Encode(message, shift);
        
        //Assert
        Assert.Equal("", encoded);
    }
    
    //TODO: Test Shift of 0
    [Fact]
    public void ReturnsCorrectEncodeForZeroShiftInput()
    {
        //Arrange
        string message = "sandie";
        int shift = 0;
        
        //Act
        string encoded = CaesarCipher.Encode(message, shift);
        
        //Assert
        Assert.Equal("sandie", encoded);
    }
    
    [Fact]
    public void ReturnsCorrectEncodeForNegativeShiftInput()
    {
        //Arrange
        string message = "sandie";
        int shift = -22;
        
        //Act
        string encoded = CaesarCipher.Encode(message, shift);
        
        //Assert
        Assert.Equal("werhmi", encoded);
    }
    
    [Fact]
    public void ReturnsCorrectEncodeForBigShiftInput()
    {
        //Arrange
        string message = "sandie";
        int shift = 134;
        
        //Act
        string encoded = CaesarCipher.Encode(message, shift);
        
        //Assert
        Assert.Equal("werhmi", encoded);
    }
}