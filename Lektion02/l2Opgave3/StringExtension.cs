using System.Text;

namespace l2Opgave3;

public static class StringExtension
{
    public static string Toleet(this string input)
    {
        var stringBuilder = new StringBuilder();
        foreach (var c in input)
        {
            char a = c switch
            {
                'a' => '4',
                'e' => '3',
                'l' => '1',
                _ => c
            };
            stringBuilder.Append(a);
        }
        return stringBuilder.ToString();
    }
}