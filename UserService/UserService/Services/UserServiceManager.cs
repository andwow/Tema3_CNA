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
            _logger.LogInformation(root, "New message");
            Message messageFromProto = request.Message;
            MessagePattern message = new MessagePattern(messageFromProto.UserName, messageFromProto.Message_);
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
        public override Task<UserResponse> GetUserStream(UserResponse userResponse, ServerCallContext context)
        {
            return new UserResponse();
        }
        
    }
}

