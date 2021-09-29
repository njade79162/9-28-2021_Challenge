using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_28_2021_Challenge
{
    public class FacebookProfile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
        public int AgeInYears
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalAgeInYears));
            }
        }
        public string Work { get; set; }

        public FacebookProfile()
        {

        }

        public FacebookProfile(string firstName, string lastName, DateTime dateOfBirth, string work)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Work = work;
        }

        public string getFullName()
        {
            return FullName;
        }

        public string getProfile()
        {
            return $"First Name: {FirstName}, Last Name: {LastName}, Full Name: {FullName}, Age: {AgeInYears}, Work: {Work}";
        }
    }
}
