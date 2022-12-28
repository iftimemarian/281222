using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _281222
{
    public class Singletone
    {
        private static Singletone instance = null;

        public static Singletone GetInstance()
        {
            if (instance == null)
            {
                instance = new Singletone();
                
            }
            Console.WriteLine(instance + "da");
                return instance;
        }
    }


    //thread safe
    public class SingletoneSafe
    {
        private static SingletoneSafe instance = null;

        public static SingletoneSafe GetInstance()
        {
            lock(typeof(SingletoneSafe))
                    {
                    if (instance == null)
                    {
                        instance = new SingletoneSafe();

                    }

                    return instance;
                    }
        }
    }


    public class teste112233
    {
        //public static void Main(string[] argv)
        //{
        //    Singletone s1 = Singletone.GetInstance();
        //    Singletone s2 = Singletone.GetInstance();

        //    if (s1 == s2)
        //    {
        //        Console.WriteLine("Singleton works, both variables contain the same instance.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Singleton failed, variables contain different instances.");
        //    }

        //    Console.WriteLine(Singletone.GetInstance());
        //}
    }
}
