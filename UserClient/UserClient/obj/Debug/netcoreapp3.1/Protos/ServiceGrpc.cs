// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace UserService {
  public static partial class UserServiceAddMessage
  {
    static readonly string __ServiceName = "UserServiceAddMessage";

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

    static readonly grpc::Marshaller<global::UserService.UserRequest> __Marshaller_UserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserService.UserRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    static readonly grpc::Marshaller<global::UserService.UserResponse> __Marshaller_UserResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserService.UserResponse.Parser));
    static readonly grpc::Marshaller<global::UserService.UserConnect> __Marshaller_UserConnect = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserService.UserConnect.Parser));
    static readonly grpc::Marshaller<global::UserService.UserDisconnect> __Marshaller_UserDisconnect = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserService.UserDisconnect.Parser));

    static readonly grpc::Method<global::UserService.UserRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddMessage = new grpc::Method<global::UserService.UserRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddMessage",
        __Marshaller_UserRequest,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::UserService.UserResponse> __Method_GetUserStream = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::UserService.UserResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUserStream",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_UserResponse);

    static readonly grpc::Method<global::UserService.UserConnect, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UserConnected = new grpc::Method<global::UserService.UserConnect, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UserConnected",
        __Marshaller_UserConnect,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::UserService.UserDisconnect, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UserDisconnected = new grpc::Method<global::UserService.UserDisconnect, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UserDisconnected",
        __Marshaller_UserDisconnect,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::UserService.ServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of UserServiceAddMessage</summary>
    [grpc::BindServiceMethod(typeof(UserServiceAddMessage), "BindService")]
    public abstract partial class UserServiceAddMessageBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> AddMessage(global::UserService.UserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::UserService.UserResponse> GetUserStream(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UserConnected(global::UserService.UserConnect request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UserDisconnected(global::UserService.UserDisconnect request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for UserServiceAddMessage</summary>
    public partial class UserServiceAddMessageClient : grpc::ClientBase<UserServiceAddMessageClient>
    {
      /// <summary>Creates a new client for UserServiceAddMessage</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public UserServiceAddMessageClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for UserServiceAddMessage that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public UserServiceAddMessageClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected UserServiceAddMessageClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected UserServiceAddMessageClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty AddMessage(global::UserService.UserRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddMessage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty AddMessage(global::UserService.UserRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddMessage, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AddMessageAsync(global::UserService.UserRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddMessageAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AddMessageAsync(global::UserService.UserRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddMessage, null, options, request);
      }
      public virtual global::UserService.UserResponse GetUserStream(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUserStream(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::UserService.UserResponse GetUserStream(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetUserStream, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::UserService.UserResponse> GetUserStreamAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUserStreamAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::UserService.UserResponse> GetUserStreamAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetUserStream, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UserConnected(global::UserService.UserConnect request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UserConnected(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UserConnected(global::UserService.UserConnect request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UserConnected, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UserConnectedAsync(global::UserService.UserConnect request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UserConnectedAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UserConnectedAsync(global::UserService.UserConnect request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UserConnected, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UserDisconnected(global::UserService.UserDisconnect request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UserDisconnected(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UserDisconnected(global::UserService.UserDisconnect request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UserDisconnected, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UserDisconnectedAsync(global::UserService.UserDisconnect request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UserDisconnectedAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UserDisconnectedAsync(global::UserService.UserDisconnect request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UserDisconnected, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override UserServiceAddMessageClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new UserServiceAddMessageClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(UserServiceAddMessageBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddMessage, serviceImpl.AddMessage)
          .AddMethod(__Method_GetUserStream, serviceImpl.GetUserStream)
          .AddMethod(__Method_UserConnected, serviceImpl.UserConnected)
          .AddMethod(__Method_UserDisconnected, serviceImpl.UserDisconnected).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, UserServiceAddMessageBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddMessage, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserService.UserRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.AddMessage));
      serviceBinder.AddMethod(__Method_GetUserStream, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::UserService.UserResponse>(serviceImpl.GetUserStream));
      serviceBinder.AddMethod(__Method_UserConnected, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserService.UserConnect, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UserConnected));
      serviceBinder.AddMethod(__Method_UserDisconnected, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserService.UserDisconnect, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UserDisconnected));
    }

  }
}
#endregion
