using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System_Library
{
    public class Staff : Employee
    {
        string officeLocation;
        float vacationDays;
        string department;
        float hoursAllowed;
        string shift;

        #region Properties

        /// <summary>
        /// Staff Office Location 
        /// </summary>
        public string OfficeLocation
        {
            get { return officeLocation; }
            set { officeLocation = value; }
        }

        /// <summary>
        /// Staff Department
        /// </summary>
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        /// <summary>
        /// Staff hours allowed to work
        /// </summary>
        public float HoursAllowed
        {
            get { return hoursAllowed; }
            set { hoursAllowed = value; }
        }

        /// <summary>
        /// Staff shift
        /// </summary>
        public string Shift
        {
            get { return shift; }
            set { shift = value; }
        }

        /// <summary>
        /// staff vacation days
        /// </summary>
        public float VacationDays
        {
            get { return vacationDays; }
            set { vacationDays = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a complete staff object.
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
        /// <param name="officelocation"></param>
        /// <param name="mydepartment"></param>
        /// <param name="hoursallowed"></param>
        /// <param name="myshift"></param>
        /// <param name="vacationdays"></param>
        public Staff(string fname, string lname, string street, string mycity, string mystate, string myzip,
            DateTime Dob, DateTime hiredate, decimal payrate, string myposition, int employeeid, bool hasbenefits,
            string officelocation, string mydepartment, float hoursallowed, string myshift, float vacationdays)
            : base(lname, fname, street, mycity, mystate, myzip, Dob, hiredate, payrate, myposition, employeeid, hasbenefits)
        {
            OfficeLocation = officelocation;
            Department = mydepartment;
            HoursAllowed = hoursallowed;
            Shift = myshift;
            VacationDays = vacationdays;
        }


        /// <summary>
        /// Creates an incomplete staff object from an employee.
        /// </summary>
        /// <param name="emp"></param>
        public Staff(Employee emp)
            : base(emp.FirstName, emp.LastName, emp.StreetAddress, emp.City, emp.State, emp.Zip, emp.DOB, emp.HireDate, emp.PayRate, emp.Position, emp.EmployeeID, emp.HasBenefits)
        {
        }

        #endregion
    }
}
