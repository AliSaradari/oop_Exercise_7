using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_7
{
    public class VipUser : User , ITuitionCalculate
    {
        public VipUser(UserType userType,string id, DateTime registrationDate, int membershipDays) : base(userType, id, registrationDate, membershipDays)
        {
            VipUserTutionPerDay = 20;
        }

        public int VipUserTutionPerDay { get; set; }
        public void TutionCalculate(int membershipDays)
        {
            var tuition = membershipDays * VipUserTutionPerDay;
            SetGymTuition(tuition);
        }
    }
}
