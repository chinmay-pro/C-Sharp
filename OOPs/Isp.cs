using System;
namespace OOPs 
{
    class Isp // base class (parent)
    {
        public string provider = "Joister";
        public void speed()
        {
            Console.WriteLine("30 mbps");
        }
    }

    class Router : Isp  // Inheritance
    {
        public string routerName = "Tp link C 1200";
    }
}