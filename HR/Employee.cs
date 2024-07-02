using System.Security.Cryptography.X509Certificates;

namespace Practice;

    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double? hourlyRate;

        public DateTime birthDate;

        const int minimalHoursWorkedUnit = 1;

        public EmployeeType employeeType;

        public static double taxRate = 0.15;

        public Employee(string first, string last, string em, DateTime bd): this(first, last, em, bd, 0, EmployeeType.StoreManager)
        {
        }


        public Employee(string first, string last, string em, DateTime bd, double? rate, EmployeeType empType)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthDate = bd;
            hourlyRate = rate ?? 10;
            employeeType = empType;
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
            double wageBeforeTax = 0.0;

            if (employeeType == EmployeeType.Manager)
            {
                Console.WriteLine($"An extra was added to the wage since {firstName} is a manager");
                wageBeforeTax = numberOfHoursWorked * hourlyRate.Value * 1.25;
            }
            else
            {
                wageBeforeTax = numberOfHoursWorked * hourlyRate.Value;
            }

            double taxAmount = wageBeforeTax * taxRate;

            wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hours of work");
            
            if (resetHours)
                numberOfHoursWorked = 0;
            return wage;    
        }

        public void DisplayEmployeeDetails()
        {   
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}" +
                              $"\nEmail: \t{email}\nBirth date: \t{birthDate.ToShortDateString()}" +
                              $"\nTax rate: \t{taxRate}");
        }
    }
