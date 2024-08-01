
namespace Practice.HR
{
    internal class Manager : Employee
    {
        public Manager(string firstName, string lastName, string email, 
            DateTime birthday, double? hourlyRate) :
             base(firstName, lastName, email, birthday, hourlyRate)
        {
        }

        public void AttendManagementMeeting()
        {
            NumberOfHoursWorked += 10;

            Console.WriteLine($"Manager {FirstName} {LastName} is now" +
            "attending a long meeting that could have been an email.");
        }

        public override void GiveBonus()
        {
            if (NumberOfHoursWorked > 5)
            {
                Console.WriteLine($"Manager {FirstName} {LastName} has earned a bonus of 500!");
            }
            else
            {
                Console.WriteLine($"Manager {FirstName} {LastName} has earned a bonus of 250!");
            }
        }
    }
}