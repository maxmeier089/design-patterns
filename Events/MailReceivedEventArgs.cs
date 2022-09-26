namespace Events
{
    public class MailReceivedEventArgs : EventArgs
    {
        public string Sender { get; }

        public string Subject { get; }

        public string Message { get; }

        public override string ToString()
        {
            return
                "Sender: " + Sender +
                "\nSubject: " + Subject +
                "\n\n" + Message;
        }

        public MailReceivedEventArgs(string sender, string subject, string message)
        {
            Sender = sender;
            Subject = subject;
            Message = message;
        }

    }
}
