﻿using Practice.HR;

IEmployee bethany = new StoreManager("Bethany", "Smith", "bethany@snowball.be", 
new DateTime(1979, 1, 16), 25);

IEmployee mary = new Manager("Mary", "Jones", "mary@snowball.be",
 new DateTime(1965, 1, 16), 30);

IEmployee bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be",
 new DateTime(1988, 1, 23), 17);

IEmployee kevin = new StoreManager("Kevin", "Marks", "kevin@snowball.be",
 new DateTime(1953, 8, 8), 10); 

IEmployee kate = new StoreManager("Kate", "Greggs", "kate@snowball.be",
 new DateTime(1993, 8, 8), 10);



List<IEmployee> employees = new List<IEmployee>();
employees.Add(bethany);
employees.Add(mary);
employees.Add(bobJunior);
employees.Add(kevin);
employees.Add(kate);

foreach (Employee employee in employees)
{
    employee.DisplayEmployeeDetails();
    employee.GiveBonus();
    employee.GiveCompliment();
}