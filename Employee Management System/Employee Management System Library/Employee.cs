using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System_Library
{
    public class Employee
    {
        string firstName;
        string lastName;
        string streetAddress;
        string city;
        string state;
        string zip;
        DateTime dob;
        DateTime hireDate;
        decimal payRate;
        string position;
        int employeeID;
        bool hasBenefits;

        #region Properties

        public string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }
        
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        
        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }
        
        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }
        
        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }
        
        public decimal PayRate
        {
            get { return payRate; }
            set { payRate = value; }
        }
        
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        
        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        
        public bool HasBenefits
        {
            get { return hasBenefits; }
            set { hasBenefits = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        #endregion


        /// <summary>
        /// Creates a complete Employee Object
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="street"></param>
        /// <param name="mycity"></param>
        /// <param name="mystate"></param>
        /// <param name="myzip"></param>
        /// <param name="Dob"></param>
        /// <param name="hiredate"></param>
        /// <param name="payrate"></param>
        /// <param name="myposition"></param>
        /// <param name="employeeid"></param>
        /// <param name="hasbenefits"></param>
        public Employee(string fname, string lname, string street, string mycity, string mystate, string myzip, 
            DateTime Dob, DateTime hiredate, decimal payrate, string myposition, int employeeid, bool hasbenefits)
        {
            FirstName = fname;
            LastName = lname;
            StreetAddress = street;
            City = mycity;
            State = mystate;
            Zip = myzip;
            DOB = Dob;
            HireDate = hiredate;
            PayRate = payrate;
            Position = myposition;
            EmployeeID = employeeid;
            HasBenefits = hasbenefits;
        }

        public override string ToString()
        {
            return LastName + ", " + FirstName;
        }

    }
}
