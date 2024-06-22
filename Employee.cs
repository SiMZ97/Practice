using System.Security.Cryptography.X509Certificates;

namespace Practice;

    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthDate;

        const int minimalHoursWorkedUnit = 1;

        public Employee(string first, string last, string em, DateTime bd): this(first, last, em, bd, 0)
        {

        }

        public Employee(string first, string last, string em, DateTime bd, double rate)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthDate = bd;
            hourlyRate = rate;
        }

        public void PerformWork()
        {
            PerformWork(minimalHoursWorkedUnit);
        }

        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;

            Console.WriteLine($"{firstName} {lastName} has worked for" +
                              $"{numberOfHoursWorked} hour(s)!");
        }

        public int CalculateBonus(int bonus)
        {
            if (numberOfHoursWorked > 10)
                bonus *= 2;
            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;        
        }

        public int CalculateBonusAndBonusTax(int bonus, ref int bonusTax)
        {
            if (numberOfHoursWorked > 10)
                bonus *= 2;
            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }  

            Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}"); 
            return bonus; 
        }

        public double ReceiveWage(bool resetHours = true)
        {
            wage = numberOfHoursWorked * hourlyRate;
            Console.WriteLine($"{firstName} {lastName} has received ${wage}" + 
                              $"for {numberOfHoursWorked} hours of work!");

            if (resetHours)
            {
                numberOfHoursWorked = 0;
            }
            return wage;    
        }

        public void DisplayEmployeeDetails()
        {   
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}" +
                              $"\nEmail: \t{email}\nBirth date: \t{birthDate}" +
                              $"\nHourly rate: \t{hourlyRate}\nNumber of hours worked: \t{numberOfHoursWorked}" +
                              $"\nWage: \t{wage}");
        }
    }
