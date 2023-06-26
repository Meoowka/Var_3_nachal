using Microsoft.CodeAnalysis.CSharp;
using System;
using System.ServiceModel;


namespace HostBook
{
    public class Program
    {
       

        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(BookService.BookService)))
            {
                host.Open();
                Console.WriteLine("Host Started @" + DateTime.Now.ToString());
                Console.ReadLine();
                host.Close();
            }  
        }    
    }
}

