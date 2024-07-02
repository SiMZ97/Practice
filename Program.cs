﻿using Practice;

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);

Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), null, EmployeeType.Research);

Employee mysteryEmployee = null;
mysteryEmployee.DisplayEmployeeDetails();



#region First run Bethany

bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();
bethany.PerformWork();
bethany.DisplayEmployeeDetails();

#endregion

#region First run George

george.PerformWork(10);
george.PerformWork();
george.PerformWork();
george.PerformWork();
george.DisplayEmployeeDetails();

#endregion

