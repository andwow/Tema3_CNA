namespace Models
{
    public class MessagePattern
    {
        private string userName;
        private string message;
        private string dateTime;
        public MessagePattern(string userName, string message, string dateTime)
        {
            this.userName = userName;
            this.message = message;
            this.dateTime = dateTime;
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
        public string DateTime
        {
            set
            {
                dateTime = value;
            }
            get
            {
                return dateTime;
            }
        }
    }
}