using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client serviceClient = new ServiceReference1.Service1Client();
            Console.Write(serviceClient.GetTestData());
            Console.ReadKey();
        }
    }
}
