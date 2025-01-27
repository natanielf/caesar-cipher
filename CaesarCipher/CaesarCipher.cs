namespace CaesarCipher;

public class CaesarCipher
{
    private static int _uppercaseStart = 65;
    private static int _uppercaseEnd = 90;
    private static int _lowercaseStart = 97;
    private static int _lowercaseEnd = 122;
    public static string Encode(string message, int shift)
    {
        shift %= 26;
        string result = "";
        foreach (char c in message)
        {
            if (char.IsAsciiLetter(c))
            {
                char newChar = (char)(c + shift);
                if (char.IsAsciiLetterUpper(c))
                {
                    if (!char.IsAsciiLetterUpper(newChar))
                    {
                        newChar = (char)(newChar % (_uppercaseEnd + 1) + _uppercaseStart);
                    }
                } else if (char.IsAsciiLetterLower(c))
                {
                    if (!char.IsAsciiLetterLower(newChar))
                    {
                        newChar = (char)(newChar % (_lowercaseEnd + 1) + _lowercaseStart);
                    }
                }
                result += newChar;
            }
            else
            {
                result += c;
            }
        }
        return result;
    }

    public static string Decode(string message, int shift)
    {
        return "";
    }

    public static string Crack(string encodedMessage)
    {
        return "";
    }
}
