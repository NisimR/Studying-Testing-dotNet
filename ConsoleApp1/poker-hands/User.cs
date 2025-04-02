using System.Collections.Generic;

namespace StudyingTesting.poker_hands
{
    public class User
    {
        public List<string> Permissions { get; set; }

        public User()
        {
            Permissions = new List<string>();
        }

        public bool CanOpenTable()
        {
            
            return Permissions.Contains("Admin") || Permissions.Contains("Manager");
           //return true;
        }
    }
}