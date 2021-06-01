using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using System.Windows;
using UserService;

namespace UserClientWPF
{
    /// <summary>
    /// Interaction logic for Chat.xaml
    /// </summary>
    public partial class Chat : Window
    {
        private static GrpcChannel channel = GrpcChannel.ForAddress("https://localhost:5001");
        public string UserNameWPF { set; get; }
        public Chat(string userName)
        {
            UserNameWPF = userName;
            InitializeComponent();
        }

        private void SubmitMessage_Click(object sender, RoutedEventArgs e)
        {
            var client = new UserServiceAddMessage.UserServiceAddMessageClient(channel);
            var dataStream = client.GetUserStream(new Empty());
            client.AddMessage(new UserRequest { UserName = UserNameWPF, Message = MessageBox.Text });
        }
    }
}
