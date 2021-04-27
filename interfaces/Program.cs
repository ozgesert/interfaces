using System;
using System.Collections.Generic;

namespace interfaces
{
    class Program
    {
        //interfaceler new lenemez
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();
            //customerManager.Update();
            //customerManager.Remove();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();
            //employeeManager.Update();
            //employeeManager.Remove();

            //IPersonManager ıntornManager = new IntornManager();
            //ıntornManager.Add();
            //ıntornManager.Update();
            //ıntornManager.Remove();



            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Update(new CustomerManager());



        }
    }
}
