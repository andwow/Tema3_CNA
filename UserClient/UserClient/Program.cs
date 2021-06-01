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
            Console.Write("Message: ");
            var message = Console.ReadLine();
            var dataStream = client.GetUserStream(new Empty());
            MessagePattern pattern = new MessagePattern { UserName = userName, Message = message };
            client.AddMessage(new UserRequest { Message =  pattern } );
            /*var cancellationToken = new CancellationTokenSource(TimeSpan.FromSeconds(10)).Token;
            try
            {
                await foreach (var weatherData in dataStream.ResponseStream.ReadAllAsync(cancellationToken))
                {
                    Console.WriteLine(weatherData.UserName + " : " + weatherData.Message);
                }
            }
            catch (RpcException e) when (e.StatusCode == StatusCode.Cancelled)
            {
                Console.WriteLine("Stream cancelled by client.");
            }*/
        }
    }
}

