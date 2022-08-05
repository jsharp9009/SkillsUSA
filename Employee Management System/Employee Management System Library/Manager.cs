using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System_Library
{
    public class Manager : Employee
    {
        string officeLocation;
        string department;
        string secretary;
        string parkingSpot;
        int accessLevel;
        float vacationDays;

        #region Properties

        /// <summary>
        /// Managers Secretary
        /// </summary>
        public string Secretary
        {
            get { return secretary; }
            set { secretary = value; }
        }

        /// <summary>
        /// Number of vacation days
        /// </summary>
        public float VacationDays
        {
            get { return vacationDays; }
            set { vacationDays = value; }
        }

        /// <summary>
        /// Manager Access Level
        /// </summary>
        public int AccessLevel
        {
            get { return accessLevel; }
            set { accessLevel = value; }
        }

        /// <summary>
        /// Manager Parking spot
        /// </summary>
        public string ParkingSpot
        {
            get { return parkingSpot; }
            set { parkingSpot = value; }
        }
        
        /// <summary>
        /// Manager office location
        /// </summary>
        public string OfficeLocation
        {
            get { return officeLocation; }
            set { officeLocation = value; }
        }

        /// <summary>
        /// Manager department
        /// </summary>
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Loads a complete Manager Object
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
        /// <param name="mydepartment"></param>
        /// <param name="officelocation"></param>
        /// <param name="mysecretary"></param>
        /// <param name="parkingspot"></param>
        /// <param name="accesslevel"></param>
        /// <param name="vacationdays"></param>
        public Manager(string fname, string lname, string street, string mycity, string mystate, string myzip, 
            DateTime Dob, DateTime hiredate, decimal payrate, string myposition, int employeeid, bool hasbenefits,
            string mydepartment, string officelocation, string mysecretary, string parkingspot, int accesslevel, float vacationdays)
            : base(lname, fname, street, mycity, mystate, myzip, Dob, hiredate, payrate, myposition, employeeid, hasbenefits)
        {
            OfficeLocation = officelocation;
            Department = mydepartment;
            Secretary = mysecretary;
            ParkingSpot = parkingspot;
            AccessLevel = accesslevel;
            VacationDays = vacationdays;
        }

        /// <summary>
        /// Creates an incomplete manager object from an Employee
        /// </summary>
        /// <param name="emp"></param>
        public Manager(Employee emp)
            : base(emp.FirstName, emp.LastName, emp.StreetAddress, emp.City, emp.State, emp.Zip, emp.DOB, emp.HireDate, emp.PayRate, emp.Position, emp.EmployeeID, emp.HasBenefits)
        {
        }

        #endregion

        public override string ToString()
        {
            return LastName + ", " + FirstName;
        }

    }
}
