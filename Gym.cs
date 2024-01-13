using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_7
{
    public static class Gym
    {
        private static List<User> _users = new();
        public static void AddUser(int userType, string userId, int membershipDays)
        {
            switch (userType)
            {
                case 1:
                    {
                        var registrationDate = DateTime.Now;
                        var user = new NormalUser(UserType.Normal, userId, registrationDate, membershipDays);
                        _users.Add(user);
                        break;
                    }
                case 2:
                    {
                        var registrationDate = DateTime.Now;
                        var user = new VipUser(UserType.VIP, userId, registrationDate, membershipDays);
                        _users.Add(user);
                        break;
                    }
            }
        }
        public static void ShowUser()
        {
            foreach (var user in _users)
            {
                Console.WriteLine($"User:\n" +
                    $"Type: {user.UserType}" +
                    $" Id: {user.Id}\n" +
                    $"RegistrationDate: {user.RegistrationDate}\n" +
                    $"Membership Days: {user.MembershipDays}");
            }
        }
        public static void ShowUserDetails(string userId)
        {
            var user = _users.Find(_=>_.Id == userId);
            if(user.UserType == UserType.Normal)
            {
                var user1 = user as NormalUser;
                user1.TutionCalculate(user1.MembershipDays);
                var ExpiredMembershipDate = user1.RegistrationDate.AddDays(user1.MembershipDays);
                Console.WriteLine($"User Id: {user1.Id}\n" +
                    $"Tuition: {user1.GymTuition}\n" +
                    $"Expired Membership Date: {ExpiredMembershipDate}");

            }
            if (user.UserType == UserType.VIP)
            {
                var user1 = user as VipUser;
                user1.TutionCalculate(user1.MembershipDays);
                var ExpiredMembershipDate = user1.RegistrationDate.AddDays(user1.MembershipDays);
                Console.WriteLine($"User Id: {user1.Id}\n" +
                    $"Tuition: {user1.GymTuition}\n" +
                    $"Expired Membership Date: {ExpiredMembershipDate}");

            }
        }
    }
}
