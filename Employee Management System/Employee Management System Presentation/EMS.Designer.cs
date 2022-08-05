namespace Employee_Management_System_Presentation
{
    partial class EMS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.EmployeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlStaff = new System.Windows.Forms.Panel();
            this.lblVacationDays = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblOfficeLocation = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.lbl19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlIntern = new System.Windows.Forms.Panel();
            this.lblMajor = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblIsPaid = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblScheduleEnd = new System.Windows.Forms.Label();
            this.lblScheduleStart = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.pnlManager = new System.Windows.Forms.Panel();
            this.lblAccessLevel = new System.Windows.Forms.Label();
            this.Label50 = new System.Windows.Forms.Label();
            this.lblManagerVacationDays = new System.Windows.Forms.Label();
            this.lblParkingSpot = new System.Windows.Forms.Label();
            this.lblSecretary = new System.Windows.Forms.Label();
            this.lblManagerDepartment = new System.Windows.Forms.Label();
            this.lblManagerOfficeLocation = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.lblBenefits = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblDOH = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmployeeType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTypeToDisplay = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.rdbDESC = new System.Windows.Forms.RadioButton();
            this.rdbASC = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlStaff.SuspendLayout();
            this.pnlIntern.SuspendLayout();
            this.pnlManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee: ";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeeName});
            this.listView1.Location = new System.Drawing.Point(12, 69);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 342);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // EmployeeName
            // 
            this.EmployeeName.Text = "Employee Name";
            this.EmployeeName.Width = 100;
            // 
            // pnlStaff
            // 
            this.pnlStaff.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlStaff.Controls.Add(this.lblVacationDays);
            this.pnlStaff.Controls.Add(this.lblShift);
            this.pnlStaff.Controls.Add(this.lblHours);
            this.pnlStaff.Controls.Add(this.lblDepartment);
            this.pnlStaff.Controls.Add(this.lblOfficeLocation);
            this.pnlStaff.Controls.Add(this.label21);
            this.pnlStaff.Controls.Add(this.Label20);
            this.pnlStaff.Controls.Add(this.lbl19);
            this.pnlStaff.Controls.Add(this.label15);
            this.pnlStaff.Controls.Add(this.label13);
            this.pnlStaff.Location = new System.Drawing.Point(680, 14);
            this.pnlStaff.Name = "pnlStaff";
            this.pnlStaff.Size = new System.Drawing.Size(486, 120);
            this.pnlStaff.TabIndex = 28;
            // 
            // lblVacationDays
            // 
            this.lblVacationDays.BackColor = System.Drawing.SystemColors.Control;
            this.lblVacationDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVacationDays.Location = new System.Drawing.Point(409, 42);
            this.lblVacationDays.Name = "lblVacationDays";
            this.lblVacationDays.Size = new System.Drawing.Size(44, 22);
            this.lblVacationDays.TabIndex = 33;
            // 
            // lblShift
            // 
            this.lblShift.BackColor = System.Drawing.SystemColors.Control;
            this.lblShift.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShift.Location = new System.Drawing.Point(206, 42);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(99, 22);
            this.lblShift.TabIndex = 32;
            // 
            // lblHours
            // 
            this.lblHours.BackColor = System.Drawing.SystemColors.Control;
            this.lblHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHours.Location = new System.Drawing.Point(107, 42);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(44, 22);
            this.lblHours.TabIndex = 31;
            // 
            // lblDepartment
            // 
            this.lblDepartment.BackColor = System.Drawing.SystemColors.Control;
            this.lblDepartment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDepartment.Location = new System.Drawing.Point(327, 10);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(133, 22);
            this.lblDepartment.TabIndex = 30;
            // 
            // lblOfficeLocation
            // 
            this.lblOfficeLocation.BackColor = System.Drawing.SystemColors.Control;
            this.lblOfficeLocation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOfficeLocation.Location = new System.Drawing.Point(107, 10);
            this.lblOfficeLocation.Name = "lblOfficeLocation";
            this.lblOfficeLocation.Size = new System.Drawing.Size(133, 22);
            this.lblOfficeLocation.TabIndex = 29;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(255, 11);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Department: ";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(24, 11);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(85, 13);
            this.Label20.TabIndex = 16;
            this.Label20.Text = "Office Location: ";
            // 
            // lbl19
            // 
            this.lbl19.AutoSize = true;
            this.lbl19.Location = new System.Drawing.Point(327, 43);
            this.lbl19.Name = "lbl19";
            this.lbl19.Size = new System.Drawing.Size(76, 13);
            this.lbl19.TabIndex = 15;
            this.lbl19.Text = "Vacation Days";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(170, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Shift: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Hours Allowed: ";
            // 
            // pnlIntern
            // 
            this.pnlIntern.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlIntern.Controls.Add(this.lblMajor);
            this.pnlIntern.Controls.Add(this.label25);
            this.pnlIntern.Controls.Add(this.lblIsPaid);
            this.pnlIntern.Controls.Add(this.lblManager);
            this.pnlIntern.Controls.Add(this.lblSchool);
            this.pnlIntern.Controls.Add(this.lblScheduleEnd);
            this.pnlIntern.Controls.Add(this.lblScheduleStart);
            this.pnlIntern.Controls.Add(this.label27);
            this.pnlIntern.Controls.Add(this.label28);
            this.pnlIntern.Controls.Add(this.label29);
            this.pnlIntern.Controls.Add(this.label30);
            this.pnlIntern.Controls.Add(this.label31);
            this.pnlIntern.Location = new System.Drawing.Point(680, 140);
            this.pnlIntern.Name = "pnlIntern";
            this.pnlIntern.Size = new System.Drawing.Size(486, 120);
            this.pnlIntern.TabIndex = 34;
            // 
            // lblMajor
            // 
            this.lblMajor.BackColor = System.Drawing.SystemColors.Control;
            this.lblMajor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMajor.Location = new System.Drawing.Point(107, 72);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(133, 22);
            this.lblMajor.TabIndex = 35;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(57, 73);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 13);
            this.label25.TabIndex = 34;
            this.label25.Text = "Major: ";
            // 
            // lblIsPaid
            // 
            this.lblIsPaid.BackColor = System.Drawing.SystemColors.Control;
            this.lblIsPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIsPaid.Location = new System.Drawing.Point(380, 72);
            this.lblIsPaid.Name = "lblIsPaid";
            this.lblIsPaid.Size = new System.Drawing.Size(44, 22);
            this.lblIsPaid.TabIndex = 33;
            // 
            // lblManager
            // 
            this.lblManager.BackColor = System.Drawing.SystemColors.Control;
            this.lblManager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblManager.Location = new System.Drawing.Point(107, 41);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(133, 22);
            this.lblManager.TabIndex = 32;
            // 
            // lblSchool
            // 
            this.lblSchool.BackColor = System.Drawing.SystemColors.Control;
            this.lblSchool.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSchool.Location = new System.Drawing.Point(329, 41);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(133, 22);
            this.lblSchool.TabIndex = 31;
            // 
            // lblScheduleEnd
            // 
            this.lblScheduleEnd.BackColor = System.Drawing.SystemColors.Control;
            this.lblScheduleEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScheduleEnd.Location = new System.Drawing.Point(327, 10);
            this.lblScheduleEnd.Name = "lblScheduleEnd";
            this.lblScheduleEnd.Size = new System.Drawing.Size(133, 22);
            this.lblScheduleEnd.TabIndex = 30;
            // 
            // lblScheduleStart
            // 
            this.lblScheduleStart.BackColor = System.Drawing.SystemColors.Control;
            this.lblScheduleStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScheduleStart.Location = new System.Drawing.Point(107, 10);
            this.lblScheduleStart.Name = "lblScheduleStart";
            this.lblScheduleStart.Size = new System.Drawing.Size(133, 22);
            this.lblScheduleStart.TabIndex = 29;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(243, 11);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(80, 13);
            this.label27.TabIndex = 17;
            this.label27.Text = "Schedule End: ";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(24, 11);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(83, 13);
            this.label28.TabIndex = 16;
            this.label28.Text = "Schedule Start: ";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(335, 73);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(45, 13);
            this.label29.TabIndex = 15;
            this.label29.Text = "Is Paid: ";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(41, 43);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(55, 13);
            this.label30.TabIndex = 13;
            this.label30.Text = "Manager: ";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(272, 43);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(46, 13);
            this.label31.TabIndex = 12;
            this.label31.Text = "School: ";
            // 
            // pnlManager
            // 
            this.pnlManager.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlManager.Controls.Add(this.lblAccessLevel);
            this.pnlManager.Controls.Add(this.Label50);
            this.pnlManager.Controls.Add(this.lblManagerVacationDays);
            this.pnlManager.Controls.Add(this.lblParkingSpot);
            this.pnlManager.Controls.Add(this.lblSecretary);
            this.pnlManager.Controls.Add(this.lblManagerDepartment);
            this.pnlManager.Controls.Add(this.lblManagerOfficeLocation);
            this.pnlManager.Controls.Add(this.label45);
            this.pnlManager.Controls.Add(this.label46);
            this.pnlManager.Controls.Add(this.label47);
            this.pnlManager.Controls.Add(this.label48);
            this.pnlManager.Controls.Add(this.label49);
            this.pnlManager.Location = new System.Drawing.Point(680, 266);
            this.pnlManager.Name = "pnlManager";
            this.pnlManager.Size = new System.Drawing.Size(486, 120);
            this.pnlManager.TabIndex = 35;
            // 
            // lblAccessLevel
            // 
            this.lblAccessLevel.BackColor = System.Drawing.SystemColors.Control;
            this.lblAccessLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccessLevel.Location = new System.Drawing.Point(175, 71);
            this.lblAccessLevel.Name = "lblAccessLevel";
            this.lblAccessLevel.Size = new System.Drawing.Size(44, 22);
            this.lblAccessLevel.TabIndex = 35;
            // 
            // Label50
            // 
            this.Label50.AutoSize = true;
            this.Label50.Location = new System.Drawing.Point(93, 72);
            this.Label50.Name = "Label50";
            this.Label50.Size = new System.Drawing.Size(77, 13);
            this.Label50.TabIndex = 34;
            this.Label50.Text = "Access Level: ";
            // 
            // lblManagerVacationDays
            // 
            this.lblManagerVacationDays.BackColor = System.Drawing.SystemColors.Control;
            this.lblManagerVacationDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblManagerVacationDays.Location = new System.Drawing.Point(386, 71);
            this.lblManagerVacationDays.Name = "lblManagerVacationDays";
            this.lblManagerVacationDays.Size = new System.Drawing.Size(44, 22);
            this.lblManagerVacationDays.TabIndex = 33;
            // 
            // lblParkingSpot
            // 
            this.lblParkingSpot.BackColor = System.Drawing.SystemColors.Control;
            this.lblParkingSpot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblParkingSpot.Location = new System.Drawing.Point(331, 40);
            this.lblParkingSpot.Name = "lblParkingSpot";
            this.lblParkingSpot.Size = new System.Drawing.Size(133, 22);
            this.lblParkingSpot.TabIndex = 32;
            // 
            // lblSecretary
            // 
            this.lblSecretary.BackColor = System.Drawing.SystemColors.Control;
            this.lblSecretary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecretary.Location = new System.Drawing.Point(107, 40);
            this.lblSecretary.Name = "lblSecretary";
            this.lblSecretary.Size = new System.Drawing.Size(133, 22);
            this.lblSecretary.TabIndex = 31;
            // 
            // lblManagerDepartment
            // 
            this.lblManagerDepartment.BackColor = System.Drawing.SystemColors.Control;
            this.lblManagerDepartment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblManagerDepartment.Location = new System.Drawing.Point(331, 9);
            this.lblManagerDepartment.Name = "lblManagerDepartment";
            this.lblManagerDepartment.Size = new System.Drawing.Size(133, 22);
            this.lblManagerDepartment.TabIndex = 30;
            // 
            // lblManagerOfficeLocation
            // 
            this.lblManagerOfficeLocation.BackColor = System.Drawing.SystemColors.Control;
            this.lblManagerOfficeLocation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblManagerOfficeLocation.Location = new System.Drawing.Point(107, 10);
            this.lblManagerOfficeLocation.Name = "lblManagerOfficeLocation";
            this.lblManagerOfficeLocation.Size = new System.Drawing.Size(133, 22);
            this.lblManagerOfficeLocation.TabIndex = 29;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(260, 11);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(68, 13);
            this.label45.TabIndex = 17;
            this.label45.Text = "Department: ";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(24, 11);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(85, 13);
            this.label46.TabIndex = 16;
            this.label46.Text = "Office Location: ";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(304, 72);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(76, 13);
            this.label47.TabIndex = 15;
            this.label47.Text = "Vacation Days";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(255, 40);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(71, 13);
            this.label48.TabIndex = 13;
            this.label48.Text = "Parking Spot:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(43, 42);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(58, 13);
            this.label49.TabIndex = 12;
            this.label49.Text = "Secretary: ";
            // 
            // lblBenefits
            // 
            this.lblBenefits.BackColor = System.Drawing.SystemColors.Control;
            this.lblBenefits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBenefits.Location = new System.Drawing.Point(588, 250);
            this.lblBenefits.Name = "lblBenefits";
            this.lblBenefits.Size = new System.Drawing.Size(42, 22);
            this.lblBenefits.TabIndex = 61;
            // 
            // lblPayRate
            // 
            this.lblPayRate.BackColor = System.Drawing.SystemColors.Control;
            this.lblPayRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPayRate.Location = new System.Drawing.Point(403, 249);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(133, 22);
            this.lblPayRate.TabIndex = 60;
            // 
            // lblPosition
            // 
            this.lblPosition.BackColor = System.Drawing.SystemColors.Control;
            this.lblPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPosition.Location = new System.Drawing.Point(207, 250);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(133, 22);
            this.lblPosition.TabIndex = 59;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployeeID.Location = new System.Drawing.Point(485, 75);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(133, 22);
            this.lblEmployeeID.TabIndex = 58;
            // 
            // lblDOH
            // 
            this.lblDOH.BackColor = System.Drawing.SystemColors.Control;
            this.lblDOH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDOH.Location = new System.Drawing.Point(485, 217);
            this.lblDOH.Name = "lblDOH";
            this.lblDOH.Size = new System.Drawing.Size(133, 22);
            this.lblDOH.TabIndex = 57;
            // 
            // lblDOB
            // 
            this.lblDOB.BackColor = System.Drawing.SystemColors.Control;
            this.lblDOB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDOB.Location = new System.Drawing.Point(261, 217);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(133, 22);
            this.lblDOB.TabIndex = 56;
            // 
            // lblZip
            // 
            this.lblZip.BackColor = System.Drawing.SystemColors.Control;
            this.lblZip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblZip.Location = new System.Drawing.Point(497, 178);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(133, 22);
            this.lblZip.TabIndex = 55;
            // 
            // lblState
            // 
            this.lblState.BackColor = System.Drawing.SystemColors.Control;
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblState.Location = new System.Drawing.Point(422, 180);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 22);
            this.lblState.TabIndex = 54;
            // 
            // lblCity
            // 
            this.lblCity.BackColor = System.Drawing.SystemColors.Control;
            this.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCity.Location = new System.Drawing.Point(207, 178);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(166, 22);
            this.lblCity.TabIndex = 53;
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.BackColor = System.Drawing.SystemColors.Control;
            this.lblStreetAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStreetAddress.Location = new System.Drawing.Point(240, 143);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(390, 22);
            this.lblStreetAddress.TabIndex = 52;
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.SystemColors.Control;
            this.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastName.Location = new System.Drawing.Point(485, 109);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(133, 22);
            this.lblLastName.TabIndex = 51;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstName.Location = new System.Drawing.Point(261, 109);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(133, 22);
            this.lblFirstName.TabIndex = 50;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(177, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "First Name: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(542, 251);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Benefits: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(157, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Position: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(346, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Pay Rate: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Employee ID: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Date of Hire: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "ZIP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Date of Birth: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "State: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "City: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Street Address: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Last Name";
            // 
            // lblEmployeeType
            // 
            this.lblEmployeeType.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmployeeType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployeeType.Location = new System.Drawing.Point(261, 76);
            this.lblEmployeeType.Name = "lblEmployeeType";
            this.lblEmployeeType.Size = new System.Drawing.Size(133, 22);
            this.lblEmployeeType.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Employee Type: ";
            // 
            // cmbTypeToDisplay
            // 
            this.cmbTypeToDisplay.FormattingEnabled = true;
            this.cmbTypeToDisplay.Items.AddRange(new object[] {
            "All",
            "Intern",
            "Manager",
            "Staff"});
            this.cmbTypeToDisplay.Location = new System.Drawing.Point(514, 12);
            this.cmbTypeToDisplay.Name = "cmbTypeToDisplay";
            this.cmbTypeToDisplay.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeToDisplay.TabIndex = 62;
            this.cmbTypeToDisplay.SelectedIndexChanged += new System.EventHandler(this.cmbTypeToDisplay_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(385, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 13);
            this.label17.TabIndex = 63;
            this.label17.Text = "Display Employee Type: ";
            // 
            // rdbDESC
            // 
            this.rdbDESC.AutoSize = true;
            this.rdbDESC.Location = new System.Drawing.Point(68, 29);
            this.rdbDESC.Name = "rdbDESC";
            this.rdbDESC.Size = new System.Drawing.Size(54, 17);
            this.rdbDESC.TabIndex = 64;
            this.rdbDESC.Text = "DESC";
            this.rdbDESC.UseVisualStyleBackColor = true;
            this.rdbDESC.CheckedChanged += new System.EventHandler(this.rdbDESC_CheckedChanged);
            // 
            // rdbASC
            // 
            this.rdbASC.AutoSize = true;
            this.rdbASC.Checked = true;
            this.rdbASC.Location = new System.Drawing.Point(16, 29);
            this.rdbASC.Name = "rdbASC";
            this.rdbASC.Size = new System.Drawing.Size(46, 17);
            this.rdbASC.TabIndex = 65;
            this.rdbASC.TabStop = true;
            this.rdbASC.Text = "ASC";
            this.rdbASC.UseVisualStyleBackColor = true;
            this.rdbASC.CheckedChanged += new System.EventHandler(this.rdbASC_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(560, 39);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 66;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // EMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 423);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.rdbASC);
            this.Controls.Add(this.rdbDESC);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cmbTypeToDisplay);
            this.Controls.Add(this.pnlStaff);
            this.Controls.Add(this.lblBenefits);
            this.Controls.Add(this.lblPayRate);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblDOH);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.pnlIntern);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmployeeType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlManager);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "EMS";
            this.Text = "Employee Management System";
            this.Load += new System.EventHandler(this.EMS_Load);
            this.pnlStaff.ResumeLayout(false);
            this.pnlStaff.PerformLayout();
            this.pnlIntern.ResumeLayout(false);
            this.pnlIntern.PerformLayout();
            this.pnlManager.ResumeLayout(false);
            this.pnlManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader EmployeeName;
        private System.Windows.Forms.Panel pnlStaff;
        private System.Windows.Forms.Label lblVacationDays;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblOfficeLocation;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label Label20;
        private System.Windows.Forms.Label lbl19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlIntern;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblIsPaid;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblScheduleEnd;
        private System.Windows.Forms.Label lblScheduleStart;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel pnlManager;
        private System.Windows.Forms.Label lblAccessLevel;
        private System.Windows.Forms.Label Label50;
        private System.Windows.Forms.Label lblManagerVacationDays;
        private System.Windows.Forms.Label lblParkingSpot;
        private System.Windows.Forms.Label lblSecretary;
        private System.Windows.Forms.Label lblManagerDepartment;
        private System.Windows.Forms.Label lblManagerOfficeLocation;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label lblBenefits;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblDOH;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmployeeType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTypeToDisplay;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton rdbDESC;
        private System.Windows.Forms.RadioButton rdbASC;
        private System.Windows.Forms.Button btnDelete;
    }
}

