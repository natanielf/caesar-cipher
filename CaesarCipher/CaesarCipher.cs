namespace CaesarCipher;

public class CaesarCipher
{
    private static int _uppercaseStart = 65;
    private static int _lowercaseStart = 97;
    public static string Encode(string message, int shift)
    {
        shift %= 26;
        string result = "";
        foreach (char c in message)
        {
            char newChar = ConvertChar(c, shift, true);
            result += newChar;
        }
        return result;
    }

    public static string Decode(string message, int shift)
    {
        shift %= 26;
        string result = "";
        foreach (char c in message)
        {
            char newChar = ConvertChar(c, shift, false);
            result += newChar;
        }
        return result;
    }

    public static string Crack(string encodedMessage)
    {
        return "";
    }

    private static char ConvertChar(char c, int shift, bool encode)
    {
        if (char.IsAsciiLetter(c))
        {
            if (!encode)
            {
                shift *= -1;
            }
            int baseAscii = char.IsAsciiLetterUpper(c) ? _uppercaseStart : _lowercaseStart;
            int newCharAscii = c - baseAscii + shift;
            char newChar = (char)((newCharAscii + 26) % 26 + baseAscii); 
            return newChar;
        }
        return c;
    }
}
