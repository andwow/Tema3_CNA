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
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new UserServiceAddMessage.UserServiceAddMessageClient(channel);
            Console.Write("Username: ");
            var userName = Console.ReadLine();
            Console.Write("Message: ");
            var message = Console.ReadLine();
            var response = client.GetUserStream(new UserRequest { UserName = userName, Message = message});
            try
            {
                Console.WriteLine(response.ResponseStream.Current.UserName + " : " + response.ResponseStream.Current.Message);
            }
            catch (RpcException e) when (e.StatusCode == StatusCode.Cancelled)
            {
                Console.WriteLine("Stream cancelled by client.");
            }
            /*var cancellationToken = new CancellationTokenSource(TimeSpan.FromSeconds(10)).Token;
            try
            {
                await foreach (var weatherData in response.ResponseStream.ReadAllAsync(cancellationToken))
                {
                    Console.WriteLine(weatherData.DateTimeStamp + " : " + weatherData.UserName + " : "
                        + weatherData.Message);
                }
            }
            catch (RpcException e) when (e.StatusCode == StatusCode.Cancelled)
            {
                Console.WriteLine("Stream cancelled by client.");
            }*/
            /*using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new U.UserManagerClient(channel);

            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("CNP: ");
            var cnp = Console.ReadLine();

            var userToBeAdded = new User()
            {
                Name = name.Trim().Length > 0 ? name : "undefined",
                Cnp = cnp.Trim().Length == 13 ? cnp : "undefined"
            };
            var response = await client.AddUserAsync(new AddUserRequest { User = userToBeAdded });
            Console.WriteLine("Status: " + response.Status.ToString());
            if (response.Status.ToString() != "Error")
            {
                Console.WriteLine("Status: " + response.Status.ToString());
                Console.WriteLine("Your age: " + response.Age.ToString());
                Console.WriteLine("Your gender: " + response.Gender.ToString());
            }*/
        }
    }
}

