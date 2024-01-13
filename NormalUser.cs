using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_7
{
    public class NormalUser : User , ITuitionCalculate
    {
        public NormalUser(UserType userType, string id, DateTime registrationDate, int membershipDays) : base(userType, id, registrationDate, membershipDays)
        {
            NormalUserTutionPerDay = 5;
        }
        public int NormalUserTutionPerDay { get; set; }
        public void TutionCalculate(int membershipDays)
        {
            var tuition = membershipDays * NormalUserTutionPerDay;
            SetGymTuition(tuition);               
        }
    }
}
