
namespace Practice.HR
{

    internal class Researcher : Employee
    {
        public Researcher(string firstName, string lastName, string email,
         DateTime birthday, double? hourlyRate) : base(firstName, lastName,
          email, birthday, hourlyRate)
        {
        }

        private int numberOfPieTastesInvented = 0;

        public int NumberOfPieTastesInvented
        {
            get { return numberOfPieTastesInvented; }
            set { numberOfPieTastesInvented = value; }
        }

        public void ResearchNewPieTastes(int researchHour)
        {
        NumberOfHoursWorked += researchHour;

        if (new Random().Next(0, 100) > 50)
        {
            NumberOfPieTastesInvented++;

            Console.WriteLine($"Researcher {FirstName} {LastName}" +
            "has invented a new pie taste! Total: {NumberOfPieTastesInvented}");
        }
        else
        {
            Console.WriteLine($"Researcher {FirstName} {LastName} is still researching...");
        }
        }
    }
}