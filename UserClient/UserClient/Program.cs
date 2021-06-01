using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Grpc.Net.Client;
using System;
using System.Threading;
using System.Threading.Tasks;
using UserService;

namespace UserServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new UserServiceAddMessage.UserServiceAddMessageClient(channel);
            Console.Write("Username: ");
            var userName = Console.ReadLine();
            var cancellationToken = new CancellationTokenSource(Timeout.Infinite);
            while (!cancellationToken.IsCancellationRequested)
            {
                Console.Write("Option: ");
                var option = Console.ReadLine();
                switch (option)
                {
                    default:
                        Console.Write("Invalid option please insert a valid option.\n");
                        break;
                    case "1":
                        Console.Write("Message: ");
                        var message = Console.ReadLine();
                        MessagePattern pattern = new MessagePattern { UserName = userName, Message = message };
                        client.AddMessage(new UserRequest { Message = pattern });
                        break;
                    case "2":
                        var dataStream = client.GetUserStream(new Empty());
                        foreach (var value in dataStream.ListOfMessage)
                        {
                            Console.WriteLine($"{value.DateTime}: {value.UserName} : {value.Message}");
                        }
                        break;
                }
            }



            //Console.Clear();
            //while (!cancellationToken.IsCancellationRequested)
            //{
            //    //Console.Write("Username: "+ userName + "\n\n\n\n\n" );
            //    Console.Write("Message: ");
            //    var message = Console.ReadLine();
            //    MessagePattern pattern = new MessagePattern { UserName = userName, Message = message };
            //    client.AddMessage(new UserRequest { Message = pattern });
            //    Console.Clear();
            //    var dataStream = client.GetUserStream(new Empty());
            //    Console.Write("Username: " + userName + "\n\n\n\n\n");

            //    foreach (var value in dataStream.ListOfMessage)
            //    {
            //        Console.WriteLine($"{value.DateTime}:{value.UserName} : {value.Message}" );
            //    }

            //    Console.WriteLine("\n\n\n\n\n");
            //}
        }
    }
}

