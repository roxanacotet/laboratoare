using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using MyPhotosManagerWCFService;

namespace MyPhotosManagerHostWCF
{
	class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lansare server WCF...");
            ServiceHost host = new ServiceHost( typeof(MyPhotosManagerWCF), new Uri("http://localhost:8000/PC"));
            foreach (ServiceEndpoint se in host.Description.Endpoints)
                Console.WriteLine("(address): {0} (binding): {1} (Contract): {2}", se.Address, se.Binding.Name, se.Contract.Name);
            host.Open();
            Console.WriteLine("Server in executie. Se asteapta conexiuni...");
            Console.WriteLine("Apasati Enter pentru a opri serverul!");
            Console.ReadKey();
            Console.ReadLine();
            host.Close();
        }
    }
}
