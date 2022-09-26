using Proxy;

ISubject subject = new SecurityProxy(new RealSubject(), "Max");

try
{
    subject.Request();
}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("Unauthorized user!");
}