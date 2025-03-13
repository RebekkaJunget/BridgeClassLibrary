// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using TCPServerConsoleApp.Server;

namespace TCPServerConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            JsonServer jserver = new JsonServer();
            jserver.start();
            Console.Read();
        }
    }
    
}