﻿namespace Proxy
{
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("Request executed!");
        }

    }
}
