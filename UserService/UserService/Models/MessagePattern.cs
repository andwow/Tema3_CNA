namespace Models
{
    public class MessagePattern
    {
        private string userName;
        private string message;
        public MessagePattern(string userName, string message)
        {
            this.userName = userName;
            this.message = message;
        }
        public string Message
        {
            set
            {
                message = value;
            }
            get
            {
                return message;
            }
        }
        public string UserName
        {
            set
            {
                userName = value;
            }
            get
            {
                return userName;
            }
        }
       
    }
}