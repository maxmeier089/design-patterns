using Events;

static void MailBox_MailEvent(object? sender, MailReceivedEventArgs e)
{
    Console.WriteLine("Mail received!\n");
    Console.WriteLine(e);
    Console.WriteLine();
}

MailBox mailBox = new();

mailBox.MailEvent += MailBox_MailEvent;

mailBox.ReceiveMail();

