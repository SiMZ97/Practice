using Practice;

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

bethany.PerformWork(25);

int minimumBonus = 100;
int bonusTax = 0;
int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, ref bonusTax);
Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has received a bonus of {receivedBonus}");

