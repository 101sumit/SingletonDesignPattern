using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class SingletonService
    {
        public int Id {  get; private set; }
        private SingletonService() { }
        private static SingletonService _instance;
        private static readonly object _instanceLock = new object();
        public static  SingletonService GetInstance(int id)
        {
            if(_instance == null)
            {
                lock(_instanceLock)
                {
                    if(_instance == null)
                    {
                        _instance = new SingletonService();
                        _instance.Id = id;
                    }
                }
            }
            return _instance;
        }

    }
}
