using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;
using Models;

namespace UserService
{
    public class UserServiceManager : UserServiceAddMessage.UserServiceAddMessageBase
    {
        private string root;
        private string messages;
        private JContainer container;
        private JArray array;
        private readonly ILogger<UserServiceManager> _logger;
        public UserServiceManager(ILogger<UserServiceManager> logger)
        {
            _logger = logger;
            root = @".\Resources\messages.json";
            if (new FileInfo(root).Length == 0)
            {
                var json = new JObject();
                json.Add("messages", new JArray());
                File.WriteAllText(root, JsonConvert.SerializeObject(json, Formatting.Indented));
            }
            messages = File.ReadAllText(root);
            container = (JObject)JToken.ReadFrom(new JsonTextReader(new StringReader(messages)));
            array = (JArray)container["messages"];
        }
        public override Task<Empty> AddMessage(UserRequest request, ServerCallContext context)
        {
            //_logger.LogInformation(root, messages);
            MessagePattern message = new MessagePattern(request.UserName, request.Message);
            array.Add(JToken.Parse(JsonConvert.SerializeObject(message, Formatting.Indented)));
            Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
            serializer.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
            using (var returnedText = File.CreateText(root))
            {
                using (var serializedReturnedText = new JsonTextWriter(returnedText))
                {
                    serializer.Serialize(serializedReturnedText, container);
                }
            }
            return Task.FromResult(new Empty());
        }
        public override async Task GetUserStream(Empty _, IServerStreamWriter<UserResponse> responseStream, ServerCallContext context)
        {
            Random random = new Random();

            try
            {
                while (!context.CancellationToken.IsCancellationRequested)
                {
                    await Task.Delay(2000);

                    var weatherData = new UserResponse()
                    {
                        UserName = "dasd",
                        Message = "dsaas"
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

