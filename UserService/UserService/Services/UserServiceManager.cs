using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace UserService
{
    public class UserServiceManager : UserServiceAddMessage.UserServiceAddMessageBase
    {
        public override async Task GetUserStream(UserRequest request, IServerStreamWriter<UserResponse> responseStream, ServerCallContext context)
        {
            try
            {
                while (!context.CancellationToken.IsCancellationRequested)
                {
                    await Task.Delay(2000);
                    var weatherData = new UserResponse()
                    {
                        DateTimeStamp = Timestamp.FromDateTime(DateTime.UtcNow),
                        UserName = request.UserName,
                        Message = request.Message
                    };
                    await responseStream.WriteAsync(weatherData);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n" + e.Message + "\n");
            }
        }
    }
}

