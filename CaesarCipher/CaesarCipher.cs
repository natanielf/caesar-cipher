namespace CaesarCypher;

public static class CaesarCipher
{
    private static char[] lowerCaseAlphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 
        'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    private static char[] upperCaseAlphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 
        'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
    
    public static string Encode(string message, int shift)
    {
        string encodedMessage = "";

        if (message.Length > 0)
        {
            encodedMessage = encodeCharacters(message, shift);
        }
        
        return encodedMessage;
    }

    private static string encodeCharacters(string message, int shift)
    {
        string encodedMessage = "";
        foreach (char character in message)
        {
            encodedMessage = encodedMessage + encodeCharacter(character, shift);
        }
        return encodedMessage;
    }

    private static char encodeCharacter(char character, int shift)
    {
        if (lowerCaseAlphabet.Contains(character))
        {
            return lowerCaseAlphabet[(Array.IndexOf(lowerCaseAlphabet, character) + shift) % 26];
        } else if (upperCaseAlphabet.Contains(character))
        {
            return upperCaseAlphabet[(Array.IndexOf(upperCaseAlphabet, character) + shift) % 26];
        }
        else
        {
            return character;
        }
    }


    public static string Decode(string message, int shift)
    {
        string decodedMessage = "";

        if (message.Length > 0)
        {
            decodedMessage = decodeCharacters(message, shift);
        }
        
        return decodedMessage;
    }
    
    private static string decodeCharacters(string message, int shift)
    {
        string decodedMessage = "";
        foreach (char character in message)
        {
            decodedMessage = decodedMessage + decodeCharacter(character, shift);
        }
        return decodedMessage;
    }

    private static char decodeCharacter(char character, int shift)
    {
        if (lowerCaseAlphabet.Contains(character))
        {
            int index = Array.IndexOf(lowerCaseAlphabet, character) - shift;
            if (index < 0)
            {
                return lowerCaseAlphabet[index + 26];
            }
            else
            {
                return lowerCaseAlphabet[index];
            }
        } else if (upperCaseAlphabet.Contains(character))
        {
            int index = Array.IndexOf(upperCaseAlphabet, character) - shift;
            if (index < 0)
            {
                return upperCaseAlphabet[index + 26];
            }
            else
            {
                return upperCaseAlphabet[index];
            }
        }
        else
        {
            return character;
        }
    }

    public static string Crack(string encodedMessage)
    {
        return "";
    }
}
