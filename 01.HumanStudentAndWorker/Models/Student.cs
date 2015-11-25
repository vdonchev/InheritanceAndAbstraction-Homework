namespace _01.HumanStudentAndWorker.Models
{
    using System;
    using System.Text.RegularExpressions;

    public class Student : Human
    {
        private const string FactNumberErrorMsg = "Faculty # should contain only letters and digits with length in range [{0}..{1}].";
        private const int MinFactNumLength = 5;
        private const int MaxFactNumLength = 10;

        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            private set
            {
                value = value ?? "";
                if (!Regex.IsMatch(value, @"^[A-Za-z0-9]{5,10}$"))
                {
                    throw new ArgumentException(string.Format(FactNumberErrorMsg, MinFactNumLength, MaxFactNumLength));
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString() =>
            $"{base.ToString()} {this.facultyNumber}";
    }
}