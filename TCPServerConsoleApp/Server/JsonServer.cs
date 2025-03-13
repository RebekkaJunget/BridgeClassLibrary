using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TCPServerConsoleApp.Server
{
    internal class JsonServer
    {
        private const int PORT = 8889;

        public void start()
        {
            TcpListener server = new TcpListener(System.Net.IPAddress.Any, PORT);
            server.Start();

            Console.WriteLine("Server started on port " + PORT);

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
        private void HandleClient(TcpClient socket)
        {
            StreamReader reader = new StreamReader(socket.GetStream());
            StreamWriter writer = new StreamWriter(socket.GetStream());
            writer.WriteLine("{\"Method\": \"Random\", \"Number1\": 10, \"Number2\": 20}");
            writer.AutoFlush = true;
            {
                try
                {
                    string? json = reader.ReadLine();
                    Console.WriteLine("Received: " + json);
                    if (json == null)
                    {
                        writer.WriteLine("Did not receive data");
                        return;
                    }




                    string response = HandleOperation(json);
                    writer.WriteLine(response);

                }
                catch (Exception e)
                {
                    writer.WriteLine("Error: " + e.Message);
                }

            }
        }

        private string HandleOperation(string jsonInput)
        {

                RequestData? request = JsonSerializer.Deserialize<RequestData>(jsonInput);
                if (request == null)
                {
                    return JsonSerializer.Serialize(new { error = "You have to put in two numbers" });
                }
                int num1 = request.Number1;
                int num2 = request.Number2;
                int result = 0;

                switch (request.Method.ToLower())
                {
                    case "random":
                        if (num1 > num2)
                        {
                            return JsonSerializer.Serialize(new { error = "First number must be smaller than second number" });
                        }
                        result = new Random().Next(num1, num2 + 1);
                        break;
                    case "add":
                        result = num1 + num2;
                        break;
                    case "sub":
                        result = num1 - num2;
                        break;
                    default:
                        return "Invalid operation";
                }


                return JsonSerializer.Serialize(new { result });
            
          

        }
    }
}

