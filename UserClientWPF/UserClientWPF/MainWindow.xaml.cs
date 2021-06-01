using System.Windows;

namespace UserClientWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitName_Click(object sender, RoutedEventArgs e)
        {
            Chat chat = new Chat(Username.Text);
            chat.Show();
            this.Close();
        }
    }
}
