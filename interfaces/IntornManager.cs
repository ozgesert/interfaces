using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    class IntornManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intorn has been added !");
        }

        public void Remove()
        {
            
        }

        public void Update()
        {
            Console.WriteLine("Intorn has been updated !");
        }
    }
}
