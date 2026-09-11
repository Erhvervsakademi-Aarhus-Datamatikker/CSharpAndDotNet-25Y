namespace Lektion03Opgave03;

class Lektion03Opgave03Main
{
    static async Task Main(string[] args)
    {
        var repository = new StarWarsRepository();
        // TODO: Gør Main asynkron (async Task Main) og kalde UserRepository herfra med await
        var task = repository.GetUserByIdAsync(1);
        
        while (!task.IsCompleted)
        {
            Console.Write(".");
            await Task.Delay(500);
        }

        var result2 = await task;

        
        
        Console.WriteLine("Henter karakter");
        var result = await repository.GetUserByIdAsync(1);
        Console.WriteLine("Færdig!");
        
       var id1 = await repository.GetUserByIdAsync(2);
       var id2 = await repository.GetUserByIdAsync(3);
       
       Console.WriteLine(result);
       Console.WriteLine(id1);
       Console.WriteLine(id2);
        
    }
}
