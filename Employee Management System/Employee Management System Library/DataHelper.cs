using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace Employee_Management_System_Library
{
    public static class DataHelper
    {
        #region private Variables

        static SqlConnection CONN = new SqlConnection("Server=stusql.otc.edu;Database=js0624782;Integrated Security=True");
        const string BASE_SQL_STRING = "SELECT E.[EmployeeID],E.[FirstName],E.[LastName],E.[StreetAddress],E.[City],E.[State],E.[Zip]"
            + ", E.[DOB],E.[HireDate],E.[PayRate],E.[Position],E.[HasBenefits]"
            + ", M.[EmployeeID] ,M.[OfficeLocation] AS ManagerOfficeLocation,M.[Department] AS ManagerDepartment"
            + ", M.[Secretary] AS ManagerSecretary,M.[VacationDays] As ManagerVacationDays,M.[AccessLevel] AS ManagerAccessLevel, M.[ParkingSpot] AS ManagerParkingSpot"
            + ", M.[ManagerID]"
            + ", I.[EmployeeID],I.[IsPaid] AS InternIsPaid,I.[BeginScheduleTime] AS InternBeginSchedule,I.[EndScheduleTime]  AS InternEndSchedule"
            + ", I.[SupervisorID] AS InternSupervisorID,I.[Major] AS InternMajor,I.[School] AS InternSchool"
            + ", S.[EmployeeID],S.[OfficeLocation] AS StaffOfficeLocation,S.[Department] AS StaffDepartment"
            + ", S.[HoursAllowed] AS StaffHoursAllowed,S.[Shift] AS StaffShift,S.[VacationDays] AS StaffVacationDays"
            + " FROM Employee AS E FULL JOIN Manager AS M "
            + "ON M.EmployeeID = E.EmployeeID "
            + "FULL JOIN Intern AS I "
            + "ON E.EmployeeID = I.EmployeeID "
            + "FULL JOIN Staff as S "
            + "ON E.EmployeeID = S.EmployeeID";

        const string BASE_DELETE_STRING = " DELETE From {0} WHERE EmployeeID = @EmpID "
            + "DELETE From Employee WHERE EmployeeID = @EmpID ";

        #endregion

        #region SQL Queries

        /// <summary>
        /// Loads a list of all employees from the database
        /// </summary>
        /// <returns></returns>
        public static List<Employee> LoadEmployees()
        {
            List<Employee> Staff = new List<Employee>();
            SqlCommand command = new SqlCommand(BASE_SQL_STRING, CONN);
            try
            {
                CONN.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Employee emp = LoadEmployee(reader);

                        if (reader["ManagerOfficeLocation"] != DBNull.Value)
                        {
                            Manager manager = LoadManager(emp, reader);
                            Staff.Add(manager);
                        }
                        else if (reader["InternIsPaid"] != DBNull.Value)
                        {
                            Intern intern = LoadInturn(emp, reader);
                            Staff.Add(intern);
                        }
                        else if (reader["StaffOfficeLocation"] != DBNull.Value)
                        {
                            Staff staff = LoadStaff(emp, reader);
                            Staff.Add(staff);
                        }
                    }
                }
                CONN.Close();
                return Staff;
            }
            catch (Exception ex)
            {
                return new List<Employee>();
            }
            finally
            {
                if (CONN.State != System.Data.ConnectionState.Closed)
                    CONN.Close();
            }
        }

        /// <summary>
        /// Gets a specific employee by their employeeid
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        private static Employee GetEmployeeByID(string ID)
        {
            SqlConnection conn2 = new SqlConnection(CONN.ConnectionString);
            SqlCommand command = new SqlCommand(BASE_SQL_STRING +
                " WHERE E.EmployeeID = @EmployeeID", conn2);

            command.Parameters.AddWithValue("@EmployeeID", ID);
            Employee emp = null;
            try
            {
                conn2.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        emp = LoadEmployee(reader);

                        if (reader["ManagerOfficeLocation"] != DBNull.Value)
                        {
                            return LoadManager(emp, reader);
                        }
                        else if (reader["InternIsPaid"] != DBNull.Value)
                        {
                            return LoadInturn(emp, reader);
                        }
                        else if (reader["StaffOfficeLocation"] != DBNull.Value)
                        {
                            return LoadStaff(emp, reader);
                        }
                        else
                        {
                            return emp;
                        }
                    }
                    return emp;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn2.State != System.Data.ConnectionState.Closed)
                    conn2.Close();
            }
        }

        private static Manager GetManagerByManagerID(string ID)
        {
            SqlConnection conn2 = new SqlConnection(CONN.ConnectionString);
            SqlCommand command = new SqlCommand(BASE_SQL_STRING +
                " WHERE M.ManagerID = @ManagerID", conn2);

            command.Parameters.AddWithValue("@ManagerID", ID);
            Employee emp = null;
            try
            {
                conn2.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        emp = LoadEmployee(reader);
                        return LoadManager(emp, reader);
                    }
                    return new Manager(emp);
                }
            }
            catch (Exception ex)
            {
                return new Manager(emp);
            }
            finally
            {
                if (conn2.State != System.Data.ConnectionState.Closed)
                    conn2.Close();
            }
        }

        /// <summary>
        /// Gets the name of an employee by their id
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <returns></returns>
        private static string GetEmployeeNameByID(string EmployeeID)
        {
            SqlConnection conn2 = new SqlConnection(CONN.ConnectionString);
            SqlCommand command = new SqlCommand("SELECT FirstName, LastName FROM Employee WHERE EmployeeID = @employeeID", conn2);
            try
            {
                conn2.Open();
                string name = string.Empty;

                command.Parameters.AddWithValue("@employeeID", EmployeeID);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        name = reader["LastName"] + ", " + reader["FirstName"];
                }

                return name;
            }
            finally
            {
                command.Dispose();
                conn2.Close();
                conn2.Dispose();
            }
        }

        /// <summary>
        /// Removes an employee from the database
        /// </summary>
        /// <param name="employeeID"></param>
        /// <param name="Table"></param>
        public static void DeleteEmployee(string employeeID, string Table)
        {
            string sql = string.Format(BASE_DELETE_STRING, Table);
            SqlCommand command = new SqlCommand(sql, CONN);
            command.Parameters.AddWithValue("@EmpID", employeeID);

            CONN.Open();
            command.ExecuteNonQuery();
            CONN.Close();
        }

        #endregion

        #region Parsing Data

        /// <summary>
        /// Loads the special fields of a manager employee
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="reader"></param>
        /// <returns></returns>
        private static Manager LoadManager(Employee employee, SqlDataReader reader)
        {
            Manager manager = new Manager(employee);

            manager.OfficeLocation = reader["ManagerOfficeLocation"].ToString();
            manager.ParkingSpot = reader["ManagerParkingSpot"].ToString();
            manager.Department = reader["ManagerDepartment"].ToString();
            manager.VacationDays = float.Parse(reader["ManagerVacationDays"].ToString());
            manager.AccessLevel = reader.GetInt32(17);
            string secretaryID = reader["ManagerSecretary"].ToString();
            manager.Secretary = GetEmployeeNameByID(secretaryID);

            return manager;
        }

        /// <summary>
        /// Loads the specific fields of an intern employee
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="reader"></param>
        /// <returns></returns>
        private static Intern LoadInturn(Employee employee, SqlDataReader reader)
        {
            Intern intern = new Intern(employee);

            intern.IsPaid = reader.GetBoolean(21);
            intern.BeginSchedule = reader.GetDateTime(22);
            intern.EndSchedule = reader.GetDateTime(23);
            intern.Supervisor = GetManagerByManagerID(reader["InternSupervisorID"].ToString());
            intern.Major = reader["InternMajor"].ToString();
            intern.School = reader["InternSchool"].ToString();

            return intern;
        }

        /// <summary>
        /// Loads the specific fiels of a staff employee
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="reader"></param>
        /// <returns></returns>
        private static Staff LoadStaff(Employee employee, SqlDataReader reader)
        {
            Staff staff = new Staff(employee);

            staff.OfficeLocation = reader["StaffOfficeLocation"].ToString();
            staff.Department = reader["StaffDepartment"].ToString();
            staff.HoursAllowed = float.Parse(reader["StaffHoursAllowed"].ToString());
            staff.Shift = reader["StaffShift"].ToString();
            staff.VacationDays = float.Parse(reader["StaffVacationDays"].ToString());

            return staff;
        }

        /// <summary>
        /// Parses a reader object into an employee object
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private static Employee LoadEmployee(SqlDataReader reader)
        {
            return new Employee(reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["StreetAddress"].ToString(), reader["City"].ToString(), reader["State"].ToString(),
                             reader["Zip"].ToString(), reader.GetDateTime(7), reader.GetDateTime(8), reader.GetDecimal(9), reader["Position"].ToString(), reader.GetInt32(0), (reader["HasBenefits"].ToString() == "1" ? true : false));

        }

        #endregion
    }
}
