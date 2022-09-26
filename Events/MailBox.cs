namespace Events
{
    public class MailBox
    {

        public event EventHandler<MailReceivedEventArgs>? MailEvent;

        public void ReceiveMail()
        {
            MailEvent?.Invoke(this, new MailReceivedEventArgs("Hans Müller", "Servus!", "Wie schaut's aus?"));
        }


    }
}
