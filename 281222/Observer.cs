using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _281222
{

    public interface IObserver
    {
        public void Update(string message);
    }
    public interface ISubject
    {
        public void Attach(Observer observer);
        public void Dettach(Observer observer);

        public void Notify();
    }

    public class Subject : ISubject
    {
        List<Observer> listObserver = new List<Observer>();

        public void Attach(Observer observer)
        {
            listObserver.Add(observer);
        }
        public void Dettach(Observer observer)
        {
            listObserver.Remove(observer);
        }

        public void Notify()
        {
            foreach (var item in listObserver)
            {
                item.Update(item.Name);
            }
        }

    }
    public class Observer : IObserver
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void Update(string message)
        {
            Console.WriteLine("Write down observer: " + message);
        }
    }


    public class useformain
    {
        //public static void Main(string[] argcv)
        //{
        //    Observer obs1 = new Observer();
        //    obs1.Name = "Ana";

        //    Observer obs2 = new Observer();
        //    obs2.Name = "John";

        //    Observer obs3 = new Observer();
        //    obs3.Name = "Mary";

        //    Subject subj = new Subject();
        //    subj.Attach(obs3);
        //    subj.Attach(obs2);
        //    subj.Attach(obs1);
        //    subj.Notify();
        //    ///
        //    Console.WriteLine("..........................");
        //    subj.Dettach(obs1);
        //    subj.Notify();
        //}
    }
}
