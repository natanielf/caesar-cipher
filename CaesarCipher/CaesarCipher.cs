namespace CaesarCipher;

public static class CaesarCipher
{
    private static char[] _alphabet = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];
    
    public static string Encode(string message, int shift)
    {
        
        string encodedMessage = string.Empty;
        message = message.ToLower();
        
        for (int i = 0; i < message.Length; i++)
        {
            char currentChar = message[i];
            int alphabetIndex = Array.IndexOf(_alphabet, currentChar);
            int encodedIndex = (alphabetIndex + shift) % 26;
            if (encodedIndex < 0)
            {
                encodedIndex += 26;
            }
            char encodedChar = _alphabet[encodedIndex];
            encodedMessage += encodedChar;
        }

        return encodedMessage;
    }

    public static string Decode(string message, int shift)
    {
        string decodedMessage = string.Empty;
        message = message.ToLower();

        for (int i = 0; i < message.Length; i++)
        {
            char currentChar = message[i];
            int alphabetIndex = Array.IndexOf(_alphabet, currentChar);
            int decodedIndex = (alphabetIndex - shift) % 26;
            if (decodedIndex < 0)
            {
                decodedIndex += 26;
            }
            char decodedChar = _alphabet[decodedIndex];
            
            decodedMessage += decodedChar;
        }
        return decodedMessage;
    }

    public static string Crack(string encodedMessage)
    {
        throw new NotImplementedException();
    }

    private static bool IsCapitalized()
    {
        throw new NotImplementedException();
    }
}
