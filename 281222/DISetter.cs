using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _281222
{
    public interface IServiceSet
    {
        void Serve();
    }
    public class Service1Set : IServiceSet
    {
        public void Serve()
        {
            Console.WriteLine("Service1 Called");
        }

        int age1;
        public int Age1
        {
            set { age1 = value; }
            get { return age1; }
        }
    }
    public class Service2Set : IServiceSet
    {
        public void Serve()
        {
            Console.WriteLine("Service2 Called");
        }
    }
    public class ClientSet
    {
        private IServiceSet _service;
        public IServiceSet Service
        {
            set { this._service = value; }
        }
        public  void ServeMethod()
        {
            this._service.Serve();
        }
    }
    class ProgramSet
    {
        //static void Main(string[] args)
        //{
        //    //creating object
        //    Service1Set s1 = new Service1Set();

        //    ClientSet client = new ClientSet();
        //    client.Service = s1; //passing dependency
        //                         //TO DO:
        //    client.ServeMethod();

        //    Service2Set s2 = new Service2Set();
        //    client.Service = s2; //passing dependency
        //                         //TO DO:
        //    client.ServeMethod();
        //}
    }
}
