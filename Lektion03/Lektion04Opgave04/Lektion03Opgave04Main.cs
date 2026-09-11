namespace Lektion03Opgave04;

class Lektion03Opgave04Main
{

    public static async Task<String> FetchCatAsync(HttpClient client)
    {
        try
        {
            var response = await client.GetStringAsync("https://catfact.ninja/fact");
            return response;
        }
        catch (HttpRequestException e)
        {
            return $"Fejl: {e.Message}";
        }

    }

    static async Task Main(string[] args)
    {
        var client = new HttpClient();
        var result = await FetchCatAsync(client);
        Console.WriteLine(result);
    }
}