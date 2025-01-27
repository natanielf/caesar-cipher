namespace CaesarCipher;

public class CaesarCipher
{
    private static int _uppercaseStart = 65;
    private static int _lowercaseStart = 97;

    private static char _mostFrequentLetter = 'E';
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
        Dictionary<char, double> letterFrequencies = GetLetterFrequencies(encodedMessage);
        int shift = 0;

        char mostFrequentEncodedLetter = _mostFrequentLetter;
        double highestFrequency = double.MinValue;
        foreach (KeyValuePair<char, double> letterFrequency in letterFrequencies)
        {
            if (letterFrequency.Value > highestFrequency)
            {
                mostFrequentEncodedLetter = letterFrequency.Key;
                highestFrequency = letterFrequency.Value;
            }
        }

        shift = Math.Abs(char.ToUpper(mostFrequentEncodedLetter) - _mostFrequentLetter);
        return Decode(encodedMessage, shift);
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

    private static Dictionary<char, double> GetLetterFrequencies(string encodedMessage)
    {
        Dictionary<char, int> letterCounts = new Dictionary<char, int>();
        int asciiCount = 0;
        foreach (char c in encodedMessage)
        {
            if (char.IsAsciiLetter(c))
            {
                asciiCount++;
                char uppercaseLetter = char.ToUpper(c);
                if (letterCounts.ContainsKey(uppercaseLetter))
                {
                    letterCounts[uppercaseLetter]++;
                }
                else
                {
                    letterCounts.Add(uppercaseLetter, 1);
                }
            }
        }

        Dictionary<char, double> letterFrequencies = new Dictionary<char, double>();
        foreach (char c in letterCounts.Keys)
        {
            double freq = letterCounts[c] / (double)asciiCount;
            double freqPercent = freq * 100;
            letterFrequencies.Add(c, freqPercent);
        }
        return letterFrequencies;
    }
}
