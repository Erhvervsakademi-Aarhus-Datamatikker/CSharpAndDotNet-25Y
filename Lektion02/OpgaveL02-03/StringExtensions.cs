namespace OpgaveL02_03;

using System.Text;

public static class StringExtensions
{
    public static string ToLeetSpeak(this string text)
    {
        var sb = new StringBuilder();

        foreach (char c in text)
        {
            sb.Append(c switch
            {
                'a' or 'A' => '4',
                'e' or 'E' => '3',
                'i' or 'I' or 'l' or 'L' => '1',
                'o' or 'O' => '0',
                's' or 'S' => '5',
                't' or 'T' => '7',
                _ => c
            });
        }

        return sb.ToString();
    }
}