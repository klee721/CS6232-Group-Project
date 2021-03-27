using System;

namespace Group3_ClinicDB.Model
{
    /// <summary>
    /// The Persons model class
    /// </summary>
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime  DateOfBirth { get; }
        public string Gender { get; }
        public string Ssn { get; }
        public string Address1 { get; }
        public string Address2 {get; }
        public string City { get; }
        public string State { get; }
        public string ZipCode { get; }
        public string PhoneNumber { get; }

        public Person(string firstName, string lastName, DateTime dob, string gender, string ssn,
                        string address1, string address2, string city, string state, string zipCode, string phoneNumber)
        {
            if (firstName.Length == 0)
            {
                throw new ArgumentException("First name cannot be empty");
            }
            if (lastName.Length == 0)
            {
                throw new ArgumentException("Last name cannot be empty");
            }
            if (gender.Length == 0)
            {
                throw new ArgumentException("Gender cannot be empty");
            }
            if (ssn.Length == 0)
            {
                throw new ArgumentException("Social security number cannot be empty");
            }
            if (address1.Length == 0)
            {
                throw new ArgumentException("Address1 cannot be empty");
            }
            if (city.Length == 0)
            {
                throw new ArgumentException("City cannot be empty");
            }
            if (state.Length == 0)
            {
                throw new ArgumentException("State cannot be empty");
            }
            if (zipCode.Length == 0)
            {
                throw new ArgumentException("Zip code cannot be empty");
            }
            if (phoneNumber.Length == 0)
            {
                throw new ArgumentException("Phone number cannot be empty");
            }
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dob;
            this.Gender = gender;
            this.Ssn = ssn;
            this.Address1 = address1;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.PhoneNumber = phoneNumber;
        }
    }
}
