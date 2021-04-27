using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee has been added !"); ;
        }

        public void Remove()
        {

        }

        public void Update()
        {
            Console.WriteLine("Employee has been updated !");
        }
    }
}
