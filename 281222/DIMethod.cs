using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _281222
{
    public interface IServiceMethod
    {
        void Serve();
    }
    public class Service1Method : IServiceMethod
    {
        public void Serve()
        {
            Console.WriteLine("Service1 Called");
        }
    }
    public class Service2Method : IServiceMethod
    {
        public void Serve()
        {
            Console.WriteLine("Service2 Called");
        }
    }
    public class ClientMethod
    {
        public void ServeMethod(IServiceMethod service)
        {
            service.Serve();
        }
    }
    class ProgramMethod
    {
        //static void Main(string[] args)
        //{
        //    //creating object
        //    Service1Method s1 = new Service1Method();

        //    ClientMethod client = new ClientMethod();
        //   // client.Start(s1); //passing dependency
        //                      //TO DO:
        //    client.ServeMethod(s1);

        //    Service2Method s2 = new Service2Method();
        //  //  client.Start(s2); //passing dependency
        //    client.ServeMethod(s2);
        //}
    }
}
