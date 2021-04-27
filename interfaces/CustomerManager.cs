using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer has been added !");
        }

        public void Remove()
        {
          
        }

        public void Update()
        {
            Console.WriteLine("Customer has been updated !");
        }
    }
}
