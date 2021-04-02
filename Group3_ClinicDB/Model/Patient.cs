using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3_ClinicDB.Model
{
    /// <summary>
    /// The Patient model class
    /// </summary>
    public class Patient
    {
        public int Id { get; }
        public int PersonsId { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; }
        public string Gender { get; }
        public string SSN { get; }
        public string Address1 { get; }
        public string Address2 { get; }
        public string City { get; }
        public string State { get; }
        public string ZipCode { get; }
        public string PhoneNumber { get;}

        public Patient(int id, int personID, string firstName, string lastName, DateTime dateOfBirth, 
                        string gender, string ssn, string address1, string address2, string city, 
                        string state, string zipCode, string phoneNumber)
        {
            if (id <= 0)
            {
                throw new Exception("Id cannot be less than 0");
            }

            if (personID <= 0)
            {
                throw new Exception("Person id cannot be less than 0");
            }

            if (firstName.Length == 0)
            {
                throw new Exception("First Name cannot be empty");
            }

            if (lastName.Length == 0)
            {
                throw new Exception("Last Name cannot be empty");
            }

            if (gender.Length == 0)
            {
                throw new Exception("Gender cannot be empty");
            }

            if (ssn.Length == 0)
            {
                throw new Exception("SSN cannot be empty");
            }

            if (address1.Length == 0)
            {
                throw new Exception("Address cannot be empty");
            }

            if (city.Length == 0)
            {
                throw new Exception("City cannot be empty");
            }

            if (state.Length == 0)
            {
                throw new Exception("State cannot be empty");
            }

            if (zipCode.Length == 0)
            {
                throw new Exception("Zip Code cannot be empty");
            }

            if (phoneNumber.Length == 0)
            {
                throw new Exception("Phone Number cannot be empty");
            }

            this.Id = id;
            this.PersonsId = personID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.SSN = ssn;
            this.Address1 = address1;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.PhoneNumber = phoneNumber;
        }
    }
}
