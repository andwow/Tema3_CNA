using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace UserManager.Services
{
    public class UserServiceManager : Service.ServiceBase
    {
        public override async Task GetUserStream(UserRequest request, IServerStreamWriter<UserResponse> responseStream, ServerCallContext context)
        {
            Random random = new Random();

            try
            {
                while (!context.CancellationToken.IsCancellationRequested)
                {
                    await Task.Delay(2000);

                    var weatherData = new UserResponse()
                    {
                        DateTimeStamp = Timestamp.FromDateTime(DateTime.UtcNow),
                        UserName = "dacac",
                        Message = "dasdadasd"
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

