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
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
            MessagePattern messageFromProto = request.Message;
            MessagePattern message = new MessagePattern();//messageFromProto.UserName, messageFromProto.Message
            message.UserName = messageFromProto.UserName;
            message.Message = messageFromProto.Message;
            message.DateTime = DateTime.Now.ToLongTimeString();
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
        public override Task<Empty> UserConnected(UserConnect userRequest, ServerCallContext context)
        {
            
            Console.WriteLine($"{userRequest.UserName} has connected.");
            return Task.FromResult(new Empty());
        }
        public override Task<Empty> UserDisconnected(UserDisconnect userRequest, ServerCallContext context)
        {
            Console.WriteLine($"{userRequest.UserName} has disconnected.");
            return Task.FromResult(new Empty());
        }
        public override Task<UserResponse> GetUserStream(Empty _, ServerCallContext context)
        {
            UserResponse userResponse = new UserResponse();
            for (int index = 0; index < array.Count(); ++index)
            {
                string userNameString = array[index]["UserName"].ToString();
                string messageString = array[index]["Message"].ToString();
                string dateTime = array[index]["DateTime"].ToString();
                MessagePattern message = new MessagePattern
                {
                    UserName = userNameString,
                    Message = messageString,
                    DateTime = dateTime
                };
                userResponse.ListOfMessage.Add(message);
            }
            return Task.FromResult(userResponse);
        }
        
    }
}

