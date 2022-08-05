using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee_Management_System_Library;
using System.Collections;

namespace Employee_Management_System_Presentation
{
    public partial class EMS : Form
    {
        #region Private Variables

        //All employees returned from the database
        List<Employee> Employees;
        //The current list of employees displaying
        List<Employee> CurrentList;
        //the X location of the boxes for the employee types
        const int locationX = 143;
        //the X location of the boxes for the employee types
        const int locationY = 291;

        #endregion

        #region Events

        public EMS()
        {
            InitializeComponent();
        }

        private void EMS_Load(object sender, EventArgs e)
        {
            Employees = DataHelper.LoadEmployees();
            if (Employees.Count > 0)
                DisplayEmployee(Employees[0].EmployeeID);
            PopulateList(Employees);
            cmbTypeToDisplay.SelectedIndex = 0;
        }

        /// <summary>
        /// When the Selected Index is changed, this repopulates the main display with the chosed employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem item = listView1.SelectedItems[0];
                    DisplayEmployee((int)item.Tag);
                }
            }
            catch (IndexOutOfRangeException ex)
            {

            }
        }

        /// <summary>
        /// Filters the employees by type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTypeToDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTypeToDisplay.SelectedIndex)
            {
                case 1:
                    DisplayAllIntern();
                    break;
                case 2:
                    DisplayAllManager();
                    break;
                case 3:
                    DisplayAllStaff();
                    break;
                default:
                    PopulateList(Employees);
                    break;
            }
        }

        /// <summary>
        /// Reorders the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbDESC_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList(CurrentList);
        }

        /// <summary>
        /// reorders the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbASC_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList(CurrentList);
        }

        /// <summary>
        /// Deletes the currently displaying employee, after prompting the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you wish to delete " + lblFirstName.Text + " " + lblLastName.Text + "?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (lblEmployeeType.Text.ToLower() == "staff")
                        DataHelper.DeleteEmployee(lblEmployeeID.Text, "Staff2");
                    else if (lblEmployeeType.Text.ToLower() == "manager")
                        DataHelper.DeleteEmployee(lblEmployeeID.Text, "Manager2");
                    else if (lblEmployeeType.Text.ToLower() == "intern")
                        DataHelper.DeleteEmployee(lblEmployeeID.Text, "Intern2");

                    RemoveFromList(lblEmployeeID.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Delete Employee\nMake sure this employee is not attached to another (such as in a Manager of or Secretary of).");
            }
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Populates the display with the employee
        /// </summary>
        /// <param name="ID"></param>
        private void DisplayEmployee(int ID)
        {
            var Employee =
                from emp in Employees
                where emp.EmployeeID == ID
                select emp;

            foreach (Employee emp in Employee)
            {
                lblEmployeeID.Text = emp.EmployeeID.ToString();
                lblFirstName.Text = emp.FirstName;
                lblLastName.Text = emp.LastName;
                lblStreetAddress.Text = emp.StreetAddress;
                lblCity.Text = emp.City;
                lblState.Text = emp.State;
                lblZip.Text = emp.Zip;
                lblDOB.Text = emp.DOB.ToShortDateString();
                lblDOH.Text = emp.HireDate.ToShortDateString();
                lblPosition.Text = emp.Position;
                lblPayRate.Text = emp.PayRate.ToString();
                lblBenefits.Text = (emp.HasBenefits ? "Yes" : "No");

                if (emp is Intern)
                {
                    lblEmployeeType.Text = "Intern";

                    pnlIntern.Visible = true;
                    pnlManager.Visible = false;
                    pnlStaff.Visible = false;
                    pnlIntern.BringToFront();

                    pnlIntern.Location = new Point(locationX, locationY);
                    pnlManager.Location = new Point(-locationX, -locationY);
                    pnlStaff.Location = new Point(-locationX, -locationY);

                    Intern intern = (Intern)emp;

                    lblIsPaid.Text = (intern.IsPaid ? "Yes" : "No");
                    lblScheduleStart.Text = intern.BeginSchedule.ToShortDateString();
                    lblScheduleEnd.Text = intern.EndSchedule.ToShortDateString();
                    lblManager.Text = intern.Supervisor.ToString();
                    lblSchool.Text = intern.School;
                    lblMajor.Text = intern.Major;
                }
                else if (emp is Manager)
                {
                    lblEmployeeType.Text = "Manager";

                    pnlIntern.Visible = false;
                    pnlManager.Visible = true;
                    pnlStaff.Visible = false;
                    pnlManager.BringToFront();

                    pnlIntern.Location = new Point(-locationX, -locationY);
                    pnlManager.Location = new Point(locationX, locationY);
                    pnlStaff.Location = new Point(-locationX, -locationY);

                    Manager manager = (Manager)emp;

                    lblManagerOfficeLocation.Text = manager.OfficeLocation;
                    lblManagerDepartment.Text = manager.Department;
                    lblSecretary.Text = manager.Secretary;
                    lblParkingSpot.Text = manager.ParkingSpot;
                    lblAccessLevel.Text = manager.AccessLevel.ToString();
                    lblManagerVacationDays.Text = manager.VacationDays.ToString();
                }
                else if (emp is Staff)
                {
                    lblEmployeeType.Text = "Staff";

                    pnlIntern.Visible = false;
                    pnlManager.Visible = false;
                    pnlStaff.Visible = true;
                    pnlStaff.BringToFront();

                    pnlIntern.Location = new Point(-locationX, -locationY);
                    pnlManager.Location = new Point(-locationX, -locationY);
                    pnlStaff.Location = new Point(locationX, locationY);

                    Staff staff = (Staff)emp;

                    lblOfficeLocation.Text = staff.OfficeLocation;
                    lblVacationDays.Text = staff.VacationDays.ToString();
                    lblDepartment.Text = staff.Department;
                    lblHours.Text = staff.HoursAllowed.ToString();
                    lblShift.Text = staff.Shift;
                }
            }
        }

        /// <summary>
        /// Populates listView1 with the list of Employees to Display;
        /// </summary>
        /// <param name="toDisplay"></param>
        private void PopulateList(List<Employee> toDisplay)
        {
            listView1.Items.Clear();

            if (rdbASC.Checked)
            {
                var list =
                    from emp in toDisplay
                    orderby emp.LastName ascending
                    select emp;

                toDisplay = list.ToList();
            }
            else
            {
                var list =
                    from emp in toDisplay
                    orderby emp.LastName descending
                    select emp;

                toDisplay = list.ToList();
            }

            foreach (Employee emp in toDisplay)
            {
                ListViewItem item = listView1.Items.Add(emp.ToString());
                item.Tag = emp.EmployeeID;
            }
            CurrentList = toDisplay;

            if (toDisplay.Count > 0)
            {
                DisplayEmployee(toDisplay[0].EmployeeID);
                listView1.Items[0].Selected = true;
            }
            else
            {
                ClearMainDisplay();
            }
        }

        /// <summary>
        /// Displays all interns
        /// </summary>
        private void DisplayAllIntern()
        {
            var interns =
                from emp in Employees
                where emp is Intern
                select emp;

            PopulateList(interns.ToList());

        }

        /// <summary>
        /// Displays all managers
        /// </summary>
        private void DisplayAllManager()
        {
            var managers =
                from emp in Employees
                where emp is Manager
                select emp;

            PopulateList(managers.ToList());
        }

        /// <summary>
        /// Displays all staff
        /// </summary>
        private void DisplayAllStaff()
        {
            var staff =
                from emp in Employees
                where emp is Staff
                select emp;

            PopulateList(staff.ToList());
        }
       
        /// <summary>
        /// Removes an employee from all lists
        /// </summary>
        /// <param name="EmpID"></param>
        private void RemoveFromList(string EmpID)
        {
            var remove =
                from emp in Employees
                where emp.EmployeeID.ToString() == EmpID
                select emp;

            List<Employee> toRemove = remove.ToList();

            foreach (Employee emp in toRemove)
            {
                Employees.Remove(emp);
            }

            var Currentremove =
                from emp in CurrentList
                where emp.EmployeeID.ToString() == EmpID
                select emp;

            List<Employee> CurrentToRemove = Currentremove.ToList();

            foreach (Employee emp in CurrentToRemove)
            {
                CurrentList.Remove(emp);
            }

            PopulateList(CurrentList);
        }
        
        /// <summary>
        /// Clears the main display
        /// </summary>
        private void ClearMainDisplay()
        {
            lblEmployeeID.Text = string.Empty;
            lblFirstName.Text = string.Empty;
            lblLastName.Text = string.Empty;
            lblStreetAddress.Text = string.Empty;
            lblCity.Text = string.Empty;
            lblState.Text = string.Empty;
            lblZip.Text = string.Empty;
            lblDOB.Text = string.Empty;
            lblDOH.Text = string.Empty;
            lblPosition.Text = string.Empty;
            lblPayRate.Text = string.Empty;
            lblBenefits.Text = string.Empty;

            pnlIntern.Visible = false;
            pnlManager.Visible = false;
            pnlStaff.Visible = false;

            pnlIntern.Location = new Point(-locationX, -locationY);
            pnlManager.Location = new Point(-locationX, -locationY);
            pnlStaff.Location = new Point(-locationX, -locationY);
        }

        #endregion
    }
}