using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _281222
{
    public class Logger
    {
       
        public void ShowMessage(string _message)
        {
            Console.WriteLine("Print value : " + _message);
        }
    }
    public class Person
    {
        //private readonly Logger logger;
        //public Person()
        //{
        //    logger = new Logger();
        //}

        //public void Save(string message)
        //{
        //    logger.ShowMessage(message);
        //}
        // logger

        Logger logger = new Logger();
        
        public void Save(string message)
        {
            logger.ShowMessage(message);    
        }
    }

    public class PersonDI
    {
        Logger _logger;
        void personDI(Logger logger)
        {
            _logger = logger;
        }
        public void Save(string message)
        {
            _logger.ShowMessage(message);
        }
    }
    ///transformation  Dependency Inversion Principle
    
    public class DataAccessLayer
    {
        public void Save(Object details)
        {
            Console.WriteLine("Save");
        }
    }
    public class BusinessLogicLayer
    {
        private readonly DataAccessLayer Dal;

        public BusinessLogicLayer()
        {
            Dal = new DataAccessLayer();
        }

        public void Save(Object details)
        {
            Dal.Save(details);
        }
    }

    ///
    public interface IRepositoryLayer
    {
        void Save(Object details);

    }

    public class DataAccesLayerTransform : IRepositoryLayer
    {
        public void Save(Object details)
        {
            ///
        }
    }

    public class BusinessLogicLayerTransform
    {
        private readonly IRepositoryLayer irep;
        BusinessLogicLayerTransform(IRepositoryLayer _irep)
        {
            irep = _irep;
        }

        public void Save(Object details)
        {
            irep.Save(details);
        }
    }


    public interface IRepositoryLayerString
    {
        public void Save(string message);
    }
    public class A : IRepositoryLayerString
    {
        public void Save(string message)
        {
            Console.WriteLine("A" + message);
        }
    }

    public class B : IRepositoryLayerString
    {
        public void Save(string message)
        {
            Console.WriteLine("B" + message);
        }
    }

    public class AB
    {
        IRepositoryLayerString repositoryLayerString;
        
        private AB(IRepositoryLayerString _repositoryLayerString)
        {
            repositoryLayerString = _repositoryLayerString;
        }
        public void Save(string details)
        {
            this.repositoryLayerString.Save(details);
        }

        //public static void Main(string[] argv)
        //{
        //    B b = new B();
        //    AB ab = new AB(b);
        //    ab.Save("Bana");


        //    A a = new A();
        //    AB ba = new AB(a);
        //    ba.Save("Aana");
        //}
    }

}
