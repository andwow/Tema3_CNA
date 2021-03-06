// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/user.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace UserClient {
  public static partial class UserManager
  {
    static readonly string __ServiceName = "userservice.UserManager";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::UserClient.AddUserRequest> __Marshaller_userservice_AddUserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserClient.AddUserRequest.Parser));
    static readonly grpc::Marshaller<global::UserClient.AddUserResponse> __Marshaller_userservice_AddUserResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserClient.AddUserResponse.Parser));

    static readonly grpc::Method<global::UserClient.AddUserRequest, global::UserClient.AddUserResponse> __Method_AddUser = new grpc::Method<global::UserClient.AddUserRequest, global::UserClient.AddUserResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddUser",
        __Marshaller_userservice_AddUserRequest,
        __Marshaller_userservice_AddUserResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::UserClient.UserReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for UserManager</summary>
    public partial class UserManagerClient : grpc::ClientBase<UserManagerClient>
    {
      /// <summary>Creates a new client for UserManager</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public UserManagerClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for UserManager that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public UserManagerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected UserManagerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected UserManagerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::UserClient.AddUserResponse AddUser(global::UserClient.AddUserRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddUser(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::UserClient.AddUserResponse AddUser(global::UserClient.AddUserRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddUser, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::UserClient.AddUserResponse> AddUserAsync(global::UserClient.AddUserRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddUserAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::UserClient.AddUserResponse> AddUserAsync(global::UserClient.AddUserRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddUser, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override UserManagerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new UserManagerClient(configuration);
      }
    }

  }
}
#endregion
