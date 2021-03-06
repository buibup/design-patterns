﻿using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var boss = new Manager("Etienne", 0);

            var manager1 = new Manager("Jeff", 1);

            var manager2 = new Manager("Loïc", 2);
            var manager3 = new Manager("Olivier", 2);
            var manager4 = new Manager("Cedric", 2);

            boss.AddEmployee(manager1);

            manager1.AddEmployees(new List<Employee> { manager2, manager3, manager4 });

            var engineer = new SoftwareEngineer("Lionel A", 3);
            var architect = new SoftwareArchitect("Bruno", 3);
            var dev1 = new WebDeveloper("Benoît", 3);

            #region other team members
            var dev2 = new WebDeveloper("Christophe", 3);
            var dev3 = new WebDeveloper("Gauthier", 3);
            var dev4 = new WebDeveloper("Raphaëlle", 3);
            var dev5 = new WebDeveloper("Philippe", 3);
            var dev6 = new WebDeveloper("Clément", 3);
            var dev7 = new WebDeveloper("Lionel R", 3);
            #endregion

            var integrator = new WebIntegrator("Jimmy", 3);

            manager4.AddEmployees(new List<Employee> { engineer, architect, dev1, dev2, dev3, dev4, dev5, dev6, dev7, integrator });

            Console.WriteLine(boss.Display());

            // display only manager 4 and these employees
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine(manager4.Display());

            Console.Read();
        }
    }
}