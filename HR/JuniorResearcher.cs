
namespace Practice.HR
{

    internal class JuniorResearcher : Researcher
    {
        public JuniorResearcher(string firstName, string lastName,
         string email, DateTime birthday, double? hourlyRate) : 
         base(firstName, lastName, email, birthday, hourlyRate)
        {
        }
    }
}