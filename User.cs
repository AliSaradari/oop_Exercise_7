using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_7
{
    public abstract class User
    {
        private string _id;
        private int _membershipDays;
        protected User(UserType userType, string id, DateTime registrationDate, int membershipDays)
        {
            Id = id;
            RegistrationDate = registrationDate;
            MembershipDays = membershipDays;
            UserType = userType;
        }
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Id Cannot Be Empty");
                }
                _id = value;
            }
        }
        public DateTime RegistrationDate { get; set; }
        public int MembershipDays
        {
            get
            {
                return _membershipDays;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Membership Days Cannot Be Negative.");
                }
                _membershipDays = value;
            }
        }
        public UserType UserType { get; set; }
        public int GymTuition { get; private set; }
        public void SetGymTuition(int gymTuition)
        {
            GymTuition = gymTuition;
        }
    }
}
