using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TCPServerConsoleApp.Server
{
    internal class Server
    {
        /// <summary>
        /// Port number
        /// </summary>
        private const int PORT = 8888;

        /// <summary>
        /// Start the server and listen for incoming connections and requests from clients
        /// </summary>
        public void Start()
        {
            /// Create a new TCP listener on any IP address and the specified port
            TcpListener server = new TcpListener(IPAddress.Any, PORT);
            server.Start();

            Console.WriteLine("Server started on port " + PORT);
            Console.WriteLine("Choose command: RANDOM, ADD, SUB");

            /// Keep listening for incoming connections
            while (true)
            {
                TcpClient socket = server.AcceptTcpClient();

                Task.Run(() =>
                {
                    TcpClient tempSocket = socket;
                    HandleClient(socket);
                });

            }
        }

        /// <summary>
        /// Handle the client request and send the response back to the client. 
        /// </summary>
        /// <param name="socket"></param>
        public static void HandleClient(TcpClient socket)
        {
            /// Create a reader and writer to read and write data from and to the client
            StreamReader reader = new StreamReader(socket.GetStream());
            StreamWriter writer = new StreamWriter(socket.GetStream());
            writer.AutoFlush = true; // enable automatic flushing
            {
                /// Read the command from the client
                try
                {
                    string command = reader.ReadLine();

                    Console.WriteLine($"1: Client request: {command}");

                    if (command == null)
                    {
                        return;
                    }
                    if (command.ToUpper() == "RANDOM" || command.ToUpper() == "ADD" || command.ToUpper() == "SUB")
                    {
                        writer.WriteLine("2: Input Numbers");

                        string numberInput = reader.ReadLine();
                        Console.WriteLine($"3: Received number : {numberInput}");

                        string[] numbers = numberInput.Split(' ');

                        if (numbers.Length == 2 && int.TryParse(numbers[0], out int num1) && int.TryParse(numbers[1], out int num2)) // check if the input is valid
                        {
                            int result = 0;

                            /// Perform the operation based on the command
                            switch (command.ToUpper())
                            {
                                case "RANDOM":
                                    result = new Random().Next(num1, num2 + 1);
                                    break;
                                case "ADD":
                                    result = num1 + num2;
                                    break;
                                case "SUB":
                                    result = num1 - num2;
                                    break;

                            }
                            writer.WriteLine($"4: Result: {result}");
                            Console.WriteLine($"4: Sent result: {result}");
                        }
                        else
                        {
                            writer.WriteLine("Invalid numbers");

                        }

                    }
                    else
                    {
                        writer.WriteLine("Invalid command");

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    socket.Close(); // close the socket
                }
            }
        }
    }
}
