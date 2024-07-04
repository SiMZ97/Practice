
namespace Practice.HR
{
    internal class StoreManager : Employee
    {
        public StoreManager(string firstName, string lastName, string email,
         DateTime birthday, double? hourlyRate) : base(firstName, lastName, 
         email, birthday, hourlyRate)
        {
        }
    }
}