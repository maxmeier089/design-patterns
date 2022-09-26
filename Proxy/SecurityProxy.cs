namespace Proxy
{
    public class SecurityProxy : ISubject
    {

        private readonly RealSubject realSubject;

        private readonly string userName;

        public void Request()
        {
            if (Environment.UserName == userName)
            {
                realSubject.Request();
            }
            else throw new UnauthorizedAccessException();
        
        }

        public SecurityProxy(RealSubject realSubject, string userName)
        {
            this.realSubject = realSubject;
            this.userName = userName;
        }

    }
}
