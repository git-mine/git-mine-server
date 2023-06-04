namespace GitMine.TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GitMine - TestConsole");

            foreach (var arg in args)
            {
                Console.WriteLine($"    * {arg}");
            }
        }
    }
}
