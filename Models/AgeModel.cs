using System.ComponentModel.DataAnnotations;
using System;

namespace FirstResponsiveWebAppTrainer.Models
{
    public class AgeModel
    {
        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a date of birth.")]
        [Range(1, 31, ErrorMessage = "Date must be between 1 and 31.")]
        public int BirthDay { get; set; }

        [Required(ErrorMessage = "Please enter a number for the birth month.")]
        [Range(1, 12, ErrorMessage = "The number for the month must be between 1 and 12.")]
        public int BirthMonth { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(0, 9999, ErrorMessage = "The year must be between 0 and 9999.")]
        public int BirthYear { get; set; }

        //The method will calcualte the age of based on values entered and return the age at the end of this year.
        public int AgeThisYear()
        {
            int currentYear = DateTime.Now.Year;
            int userAge = currentYear - BirthYear;
            return userAge;
        }

        //The method will calcualte the age of based on values entered and return the age as of today.
        public int AgeToday()
        {
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;
            int currentDay = DateTime.Now.Day;
            int userAge;
            if(BirthMonth <= currentMonth)
            {
                if (BirthDay <= currentDay)
                {
                    userAge = currentYear - BirthYear;
                }
                else
                {
                    userAge = currentYear - BirthYear - 1;
                }
            }
            else
            {
                userAge = currentYear - BirthYear - 1;
            }
            return userAge;
        }
    }
}
