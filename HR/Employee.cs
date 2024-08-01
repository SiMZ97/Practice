using System;
using System.Text.Json;

namespace Practice.HR
{
    internal class Employee : IEmployee
    {
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double? hourlyRate;

        private DateTime birthDay;
        private const int minimalHoursWorkedUnit = 1;

        private Address address;

        public static double taxRate = 0.15;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email 
        {
            get { return email; }
            set { email = value; }
        }  

        public int NumberOfHoursWorked
        {
            get { return numberOfHoursWorked; }
            protected set { numberOfHoursWorked = value; }
        }

        public double Wage
        {
            get { return wage; }
            private set { wage = value; }
        }

        public double? HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                if (value < 0)
                {
                    hourlyRate = 0;
                }
                else
                {
                    hourlyRate = value;
                }
            }
        }

        public DateTime BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        } 

        public Employee(string firstName, string lastName, string email,
         DateTime birthday): this(firstName, lastName, email, birthday, null)
        {
        }

        public Employee(string firstName, string lastName, string email,
         DateTime birthday, double? hourlyRate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthday;
            HourlyRate = hourlyRate ?? 10;
        }

        public Employee(string firstName, string lastName, string email,
         DateTime birthday, double? hourlyRate, string street, string houseNumber, string zip, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthday;
            HourlyRate = hourlyRate ?? 10;

            Address = new Address(street, houseNumber, zip, city);
        }

        public void PerformWork()
        {
            PerformWork(minimalHoursWorkedUnit);
        }

        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;

            Console.WriteLine($"{FirstName} {LastName} has worked for" +
                              $"{NumberOfHoursWorked} hour(s)!");
        }

        public int CalculateBonus(int bonus)
        {
            if (NumberOfHoursWorked > 10)
                bonus *= 2;

            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;        
        }

        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if (NumberOfHoursWorked > 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }  

            Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}"); 
            return bonus; 
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} received a bonus of 100");
        }

        public double ReceiveWage(bool resetHours = true)
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{FirstName} {LastName} has received a wage of {wage} for {numberOfHoursWorked} hours of work");
            
            if (resetHours)
                NumberOfHoursWorked = 0;

            return wage;    
        }

        public double CalculateWage()
        {
            WageCalculations wageCalculations = new WageCalculations();

            double calculateValue = wageCalculations.ComplexWageCalculation(Wage, taxRate, 3, 42);

            return calculateValue;
        }

        public string ConvertToJson()
        {
            string json = JsonSerializer.Serialize(this);

            return json;
        }

        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }

        public void DisplayEmployeeDetails()
        {   
            Console.WriteLine($"\nFirst name: \t{FirstName}\nLast name: \t{LastName}" +
                              $"\nEmail: \t\t{Email}\nBirthday: \t{BirthDay.ToShortDateString()}");

        }

        public void GiveCompliment()
        {
            Console.WriteLine($"You are doing a great job, {FirstName}!");
        }
    }

    internal class WageCalculations
    {
        public double ComplexWageCalculation(double wage, double taxRate, int factor1, int factor2)
        {
            return wage - (wage * taxRate);
        }
    }        
}