using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System_Library
{
    public class Intern : Employee
    {
        bool isPaid;
        DateTime beginSchedule;
        DateTime endSchedule;
        Manager supervisor;
        string major;
        string school;

        #region Properties

        /// <summary>
        /// Is this intern paid?
        /// </summary>
        public bool IsPaid
        {
            get { return isPaid; }
            set { isPaid = value; }
        }

        /// <summary>
        /// When does he/she begin his/her schedule
        /// </summary>
        public DateTime BeginSchedule
        {
            get { return beginSchedule; }
            set { beginSchedule = value; }
        }
        
        /// <summary>
        /// When does he/she end his/her schedule
        /// </summary>
        public DateTime EndSchedule
        {
            get { return endSchedule; }
            set { endSchedule = value; }
        }
        
        /// <summary>
        /// Interns supervisor
        /// </summary>
        public Manager Supervisor
        {
            get { return supervisor; }
            set { supervisor = value; }
        }

        /// <summary>
        /// Interns major
        /// </summary>
        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        /// <summary>
        /// Interns School
        /// </summary>
        public string School
        {
            get { return school; }
            set { school = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a complete intern object
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
        /// <param name="ispaid"></param>
        /// <param name="beginschedule"></param>
        /// <param name="endschedule"></param>
        /// <param name="mysupervisor"></param>
        /// <param name="mymajor"></param>
        /// <param name="myschool"></param>
        public Intern(string fname, string lname, string street, string mycity, string mystate, string myzip,
            DateTime Dob, DateTime hiredate, decimal payrate, string myposition, int employeeid, bool hasbenefits,
            bool ispaid, DateTime beginschedule, DateTime endschedule, Manager mysupervisor, string mymajor, string myschool)
            : base(lname, fname, street, mycity, mystate, myzip, Dob, hiredate, payrate, myposition, employeeid, hasbenefits)
        {
            IsPaid = ispaid;
            BeginSchedule = beginschedule;
            EndSchedule = endschedule;
            Supervisor = mysupervisor;
            Major = mymajor;
            School = myschool;
        }
        
        /// <summary>
        /// Creats an incomplete intern object from an Employee
        /// </summary>
        /// <param name="emp"></param>
        public Intern(Employee emp)
            : base(emp.FirstName, emp.LastName, emp.StreetAddress, emp.City, emp.State, emp.Zip, emp.DOB, emp.HireDate, emp.PayRate, emp.Position, emp.EmployeeID, emp.HasBenefits)
        {
        }

        #endregion
    }
}
