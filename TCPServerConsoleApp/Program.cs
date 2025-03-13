// See https://aka.ms/new-console-template for more information

namespace TCPServerConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Server server = new Server();
            server.Start();
            Console.Read();
        }
    }
    
}