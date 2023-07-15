Public Class Employees
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents DsPayroll As Payroll_System.dsPayroll
    Friend WithEvents cnPayroll As System.Data.OleDb.OleDbConnection
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabData As System.Windows.Forms.TabPage
    Friend WithEvents TabList As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtTelNo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtSSS As System.Windows.Forms.TextBox
    Friend WithEvents txtTIN As System.Windows.Forms.TextBox
    Friend WithEvents txtDailyRate As System.Windows.Forms.TextBox
    Friend WithEvents txtAllowance As System.Windows.Forms.TextBox
    Friend WithEvents txtIncentives As System.Windows.Forms.TextBox
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents lblNavLocation As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents daDivision As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents tpDateHired As System.Windows.Forms.DateTimePicker
    Friend WithEvents daEmployees As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents cbPayMethod As System.Windows.Forms.ComboBox
    Friend WithEvents cbDivision As System.Windows.Forms.ComboBox
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents grdEmpList As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DsPayroll = New Payroll_System.dsPayroll
        Me.cnPayroll = New System.Data.OleDb.OleDbConnection
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabData = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tpDateHired = New System.Windows.Forms.DateTimePicker
        Me.cbPayMethod = New System.Windows.Forms.ComboBox
        Me.cbDivision = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.cbStatus = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtPosition = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtIncentives = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtAllowance = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtDailyRate = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTIN = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtSSS = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTelNo = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMiddleName = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.TabList = New System.Windows.Forms.TabPage
        Me.grdEmpList = New System.Windows.Forms.DataGrid
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnFirst = New System.Windows.Forms.Button
        Me.btnPrev = New System.Windows.Forms.Button
        Me.lblNavLocation = New System.Windows.Forms.Label
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.daEmployees = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.daDivision = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        CType(Me.DsPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabData.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabList.SuspendLayout()
        CType(Me.grdEmpList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DsPayroll
        '
        Me.DsPayroll.DataSetName = "dsPayroll"
        Me.DsPayroll.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabData)
        Me.TabControl1.Controls.Add(Me.TabList)
        Me.TabControl1.Location = New System.Drawing.Point(9, 51)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(567, 342)
        Me.TabControl1.TabIndex = 2
        '
        'TabData
        '
        Me.TabData.Controls.Add(Me.GroupBox2)
        Me.TabData.Controls.Add(Me.GroupBox1)
        Me.TabData.Location = New System.Drawing.Point(4, 22)
        Me.TabData.Name = "TabData"
        Me.TabData.Size = New System.Drawing.Size(559, 316)
        Me.TabData.TabIndex = 0
        Me.TabData.Text = "Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tpDateHired)
        Me.GroupBox2.Controls.Add(Me.cbPayMethod)
        Me.GroupBox2.Controls.Add(Me.cbDivision)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.cbStatus)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtPosition)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtIncentives)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtAllowance)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtDailyRate)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtTIN)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtSSS)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 162)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(540, 147)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Work Information"
        '
        'tpDateHired
        '
        Me.tpDateHired.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Employees.DateHired"))
        Me.tpDateHired.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.tpDateHired.Location = New System.Drawing.Point(324, 93)
        Me.tpDateHired.Name = "tpDateHired"
        Me.tpDateHired.Size = New System.Drawing.Size(120, 20)
        Me.tpDateHired.TabIndex = 14
        '
        'cbPayMethod
        '
        Me.cbPayMethod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Employees.PayMethod"))
        Me.cbPayMethod.Location = New System.Drawing.Point(324, 117)
        Me.cbPayMethod.Name = "cbPayMethod"
        Me.cbPayMethod.Size = New System.Drawing.Size(121, 21)
        Me.cbPayMethod.TabIndex = 15
        '
        'cbDivision
        '
        Me.cbDivision.Location = New System.Drawing.Point(323, 69)
        Me.cbDivision.Name = "cbDivision"
        Me.cbDivision.Size = New System.Drawing.Size(165, 21)
        Me.cbDivision.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(248, 117)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 21)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Pay Method:"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(248, 93)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 21)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Date Hired:"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(248, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 21)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Division:"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(248, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 21)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Status:"
        '
        'cbStatus
        '
        Me.cbStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Employees.Status"))
        Me.cbStatus.Location = New System.Drawing.Point(323, 45)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(165, 21)
        Me.cbStatus.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(248, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 21)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Position:"
        '
        'txtPosition
        '
        Me.txtPosition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Employees.PositionTitle"))
        Me.txtPosition.Location = New System.Drawing.Point(323, 21)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.TabIndex = 11
        Me.txtPosition.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(53, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 21)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Incentives:"
        '
        'txtIncentives
        '
        Me.txtIncentives.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Employees.Incentives"))
        Me.txtIncentives.Location = New System.Drawing.Point(128, 117)
        Me.txtIncentives.Name = "txtIncentives"
        Me.txtIncentives.TabIndex = 10
        Me.txtIncentives.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(53, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 21)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Allowance:"
        '
        'txtAllowance
        '
        Me.txtAllowance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Employees.Allowance"))
        Me.txtAllowance.Location = New System.Drawing.Point(128, 93)
        Me.txtAllowance.Name = "txtAllowance"
        Me.txtAllowance.TabIndex = 9
        Me.txtAllowance.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(53, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 21)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Daily Rate:"
        '
        'txtDailyRate
        '
        Me.txtDailyRate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Employees.DailyRate"))
        Me.txtDailyRate.Location = New System.Drawing.Point(128, 69)
        Me.txtDailyRate.Name = "txtDailyRate"
        Me.txtDailyRate.TabIndex = 8
        Me.txtDailyRate.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(53, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 21)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "TIN #.:"
        '
        'txtTIN
        '
        Me.txtTIN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Employees.Tin"))
        Me.txtTIN.Location = New System.Drawing.Point(128, 45)
        Me.txtTIN.Name = "txtTIN"
        Me.txtTIN.TabIndex = 7
        Me.txtTIN.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(53, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 21)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "SSS #.:"
        '
        'txtSSS
        '
        Me.txtSSS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Employees.SSS"))
        Me.txtSSS.Location = New System.Drawing.Point(128, 21)
        Me.txtSSS.Name = "txtSSS"
        Me.txtSSS.TabIndex = 6
        Me.txtSSS.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtTelNo)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMiddleName)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(543, 147)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(25, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Phone:"
        '
        'txtTelNo
        '
        Me.txtTelNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Employees.Phone"))
        Me.txtTelNo.Location = New System.Drawing.Point(110, 120)
        Me.txtTelNo.Name = "txtTelNo"
        Me.txtTelNo.Size = New System.Drawing.Size(135, 20)
        Me.txtTelNo.TabIndex = 5
        Me.txtTelNo.Text = ""
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Employees.Address"))
        Me.txtAddress.Location = New System.Drawing.Point(110, 96)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(408, 20)
        Me.txtAddress.TabIndex = 4
        Me.txtAddress.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(25, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Address:"
        '
        'txtCode
        '
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Employees.AssignCode"))
        Me.txtCode.Location = New System.Drawing.Point(110, 24)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(132, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(25, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Assign Code:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(488, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "M.I."
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(299, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(110, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(25, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name:"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Employees.MiddleName"))
        Me.txtMiddleName.Location = New System.Drawing.Point(485, 72)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(33, 20)
        Me.txtMiddleName.TabIndex = 3
        Me.txtMiddleName.Text = ""
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Employees.FirstName"))
        Me.txtFirstName.Location = New System.Drawing.Point(299, 72)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(183, 20)
        Me.txtFirstName.TabIndex = 2
        Me.txtFirstName.Text = ""
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Employees.LastName"))
        Me.txtLastName.Location = New System.Drawing.Point(110, 72)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(183, 20)
        Me.txtLastName.TabIndex = 1
        Me.txtLastName.Text = ""
        '
        'TabList
        '
        Me.TabList.Controls.Add(Me.grdEmpList)
        Me.TabList.Location = New System.Drawing.Point(4, 22)
        Me.TabList.Name = "TabList"
        Me.TabList.Size = New System.Drawing.Size(559, 316)
        Me.TabList.TabIndex = 1
        Me.TabList.Text = "List"
        '
        'grdEmpList
        '
        Me.grdEmpList.DataMember = ""
        Me.grdEmpList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdEmpList.Location = New System.Drawing.Point(9, 9)
        Me.grdEmpList.Name = "grdEmpList"
        Me.grdEmpList.ReadOnly = True
        Me.grdEmpList.Size = New System.Drawing.Size(540, 300)
        Me.grdEmpList.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(9, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(570, 38)
        Me.Panel1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(4, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(348, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Employee's Information"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(582, 399)
        Me.Panel2.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnDelete)
        Me.Panel3.Controls.Add(Me.btnFirst)
        Me.Panel3.Controls.Add(Me.btnPrev)
        Me.Panel3.Controls.Add(Me.lblNavLocation)
        Me.Panel3.Controls.Add(Me.btnNext)
        Me.Panel3.Controls.Add(Me.btnLast)
        Me.Panel3.Controls.Add(Me.btnAdd)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnExit)
        Me.Panel3.Location = New System.Drawing.Point(3, 405)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(582, 33)
        Me.Panel3.TabIndex = 115
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(418, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "&Delete"
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(12, 4)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(40, 23)
        Me.btnFirst.TabIndex = 16
        Me.btnFirst.Text = "<<"
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(51, 4)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(35, 23)
        Me.btnPrev.TabIndex = 17
        Me.btnPrev.Text = "<"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.BackColor = System.Drawing.Color.White
        Me.lblNavLocation.Location = New System.Drawing.Point(84, 4)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Size = New System.Drawing.Size(95, 23)
        Me.lblNavLocation.TabIndex = 117
        Me.lblNavLocation.Text = "No Records"
        Me.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(180, 4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(35, 23)
        Me.btnNext.TabIndex = 18
        Me.btnNext.Text = ">"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(214, 4)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(40, 23)
        Me.btnLast.TabIndex = 19
        Me.btnLast.Text = ">>"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(267, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "&Add"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(343, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "&Save"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(493, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "E&xit"
        '
        'daEmployees
        '
        Me.daEmployees.DeleteCommand = Me.OleDbDeleteCommand1
        Me.daEmployees.InsertCommand = Me.OleDbInsertCommand1
        Me.daEmployees.SelectCommand = Me.OleDbSelectCommand1
        Me.daEmployees.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Employees", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AssignCode", "AssignCode"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("MiddleName", "MiddleName"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("SSS", "SSS"), New System.Data.Common.DataColumnMapping("Tin", "Tin"), New System.Data.Common.DataColumnMapping("DailyRate", "DailyRate"), New System.Data.Common.DataColumnMapping("Allowance", "Allowance"), New System.Data.Common.DataColumnMapping("Incentives", "Incentives"), New System.Data.Common.DataColumnMapping("PositionTitle", "PositionTitle"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("Division", "Division"), New System.Data.Common.DataColumnMapping("DateHired", "DateHired"), New System.Data.Common.DataColumnMapping("PayMethod", "PayMethod")})})
        Me.daEmployees.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Employees WHERE (AssignCode = ?) AND (Address = ? OR ? IS NULL AND Ad" & _
        "dress IS NULL) AND (Allowance = ? OR ? IS NULL AND Allowance IS NULL) AND (Daily" & _
        "Rate = ? OR ? IS NULL AND DailyRate IS NULL) AND (DateHired = ? OR ? IS NULL AND" & _
        " DateHired IS NULL) AND (Division = ? OR ? IS NULL AND Division IS NULL) AND (Fi" & _
        "rstName = ? OR ? IS NULL AND FirstName IS NULL) AND (Incentives = ? OR ? IS NULL" & _
        " AND Incentives IS NULL) AND (LastName = ? OR ? IS NULL AND LastName IS NULL) AN" & _
        "D (MiddleName = ? OR ? IS NULL AND MiddleName IS NULL) AND (PayMethod = ? OR ? I" & _
        "S NULL AND PayMethod IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL) AND" & _
        " (PositionTitle = ? OR ? IS NULL AND PositionTitle IS NULL) AND (SSS = ? OR ? IS" & _
        " NULL AND SSS IS NULL) AND (Status = ? OR ? IS NULL AND Status IS NULL) AND (Tin" & _
        " = ? OR ? IS NULL AND Tin IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.cnPayroll
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AssignCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AssignCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Allowance", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Allowance", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Allowance1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Allowance", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DailyRate", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DailyRate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DailyRate1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DailyRate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateHired", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateHired", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateHired1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateHired", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Division", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Division", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Division1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Division", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Incentives", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Incentives", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Incentives1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Incentives", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MiddleName", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MiddleName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MiddleName1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MiddleName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PayMethod", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PayMethod", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PayMethod1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PayMethod", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PositionTitle", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PositionTitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PositionTitle1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PositionTitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SSS", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SSS", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SSS1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SSS", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Status1", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Tin", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tin", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Tin1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tin", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Employees(AssignCode, LastName, FirstName, MiddleName, Address, Phone" & _
        ", SSS, Tin, DailyRate, Allowance, Incentives, PositionTitle, Status, Division, D" & _
        "ateHired, PayMethod) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.cnPayroll
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AssignCode", System.Data.OleDb.OleDbType.VarWChar, 10, "AssignCode"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 15, "LastName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 20, "FirstName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MiddleName", System.Data.OleDb.OleDbType.VarWChar, 2, "MiddleName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 12, "Phone"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SSS", System.Data.OleDb.OleDbType.VarWChar, 15, "SSS"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Tin", System.Data.OleDb.OleDbType.VarWChar, 16, "Tin"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DailyRate", System.Data.OleDb.OleDbType.Currency, 0, "DailyRate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Allowance", System.Data.OleDb.OleDbType.Currency, 0, "Allowance"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Incentives", System.Data.OleDb.OleDbType.Currency, 0, "Incentives"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PositionTitle", System.Data.OleDb.OleDbType.VarWChar, 20, "PositionTitle"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 12, "Status"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Division", System.Data.OleDb.OleDbType.Integer, 0, "Division"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DateHired", System.Data.OleDb.OleDbType.DBDate, 0, "DateHired"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PayMethod", System.Data.OleDb.OleDbType.VarWChar, 20, "PayMethod"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT AssignCode, LastName, FirstName, MiddleName, Address, Phone, SSS, Tin, Dai" & _
        "lyRate, Allowance, Incentives, PositionTitle, Status, Division, DateHired, PayMe" & _
        "thod FROM Employees"
        Me.OleDbSelectCommand1.Connection = Me.cnPayroll
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Employees SET AssignCode = ?, LastName = ?, FirstName = ?, MiddleName = ?," & _
        " Address = ?, Phone = ?, SSS = ?, Tin = ?, DailyRate = ?, Allowance = ?, Incenti" & _
        "ves = ?, PositionTitle = ?, Status = ?, Division = ?, DateHired = ?, PayMethod =" & _
        " ? WHERE (AssignCode = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND" & _
        " (Allowance = ? OR ? IS NULL AND Allowance IS NULL) AND (DailyRate = ? OR ? IS N" & _
        "ULL AND DailyRate IS NULL) AND (DateHired = ? OR ? IS NULL AND DateHired IS NULL" & _
        ") AND (Division = ? OR ? IS NULL AND Division IS NULL) AND (FirstName = ? OR ? I" & _
        "S NULL AND FirstName IS NULL) AND (Incentives = ? OR ? IS NULL AND Incentives IS" & _
        " NULL) AND (LastName = ? OR ? IS NULL AND LastName IS NULL) AND (MiddleName = ? " & _
        "OR ? IS NULL AND MiddleName IS NULL) AND (PayMethod = ? OR ? IS NULL AND PayMeth" & _
        "od IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL) AND (PositionTitle = " & _
        "? OR ? IS NULL AND PositionTitle IS NULL) AND (SSS = ? OR ? IS NULL AND SSS IS N" & _
        "ULL) AND (Status = ? OR ? IS NULL AND Status IS NULL) AND (Tin = ? OR ? IS NULL " & _
        "AND Tin IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.cnPayroll
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("AssignCode", System.Data.OleDb.OleDbType.VarWChar, 10, "AssignCode"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 15, "LastName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 20, "FirstName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MiddleName", System.Data.OleDb.OleDbType.VarWChar, 2, "MiddleName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 12, "Phone"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SSS", System.Data.OleDb.OleDbType.VarWChar, 15, "SSS"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Tin", System.Data.OleDb.OleDbType.VarWChar, 16, "Tin"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DailyRate", System.Data.OleDb.OleDbType.Currency, 0, "DailyRate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Allowance", System.Data.OleDb.OleDbType.Currency, 0, "Allowance"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Incentives", System.Data.OleDb.OleDbType.Currency, 0, "Incentives"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PositionTitle", System.Data.OleDb.OleDbType.VarWChar, 20, "PositionTitle"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 12, "Status"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Division", System.Data.OleDb.OleDbType.Integer, 0, "Division"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DateHired", System.Data.OleDb.OleDbType.DBDate, 0, "DateHired"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("PayMethod", System.Data.OleDb.OleDbType.VarWChar, 20, "PayMethod"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AssignCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AssignCode", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Allowance", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Allowance", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Allowance1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Allowance", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DailyRate", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DailyRate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DailyRate1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DailyRate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateHired", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateHired", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DateHired1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DateHired", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Division", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Division", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Division1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Division", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Incentives", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Incentives", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Incentives1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Incentives", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MiddleName", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MiddleName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MiddleName1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MiddleName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PayMethod", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PayMethod", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PayMethod1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PayMethod", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PositionTitle", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PositionTitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PositionTitle1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PositionTitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SSS", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SSS", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SSS1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SSS", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Status1", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Status", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Tin", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tin", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Tin1", System.Data.OleDb.OleDbType.VarWChar, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tin", System.Data.DataRowVersion.Original, Nothing))
        '
        'daDivision
        '
        Me.daDivision.DeleteCommand = Me.OleDbDeleteCommand2
        Me.daDivision.InsertCommand = Me.OleDbInsertCommand2
        Me.daDivision.SelectCommand = Me.OleDbSelectCommand2
        Me.daDivision.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Division", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Division", "Division"), New System.Data.Common.DataColumnMapping("DivisionID", "DivisionID")})})
        Me.daDivision.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM Division WHERE (DivisionID = ?) AND (Division = ? OR ? IS NULL AND Di" & _
        "vision IS NULL)"
        Me.OleDbDeleteCommand2.Connection = Me.cnPayroll
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DivisionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DivisionID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Division", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Division", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Division1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Division", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO Division(Division) VALUES (?)"
        Me.OleDbInsertCommand2.Connection = Me.cnPayroll
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Division", System.Data.OleDb.OleDbType.VarWChar, 50, "Division"))
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT Division, DivisionID FROM Division"
        Me.OleDbSelectCommand2.Connection = Me.cnPayroll
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE Division SET Division = ? WHERE (DivisionID = ?) AND (Division = ? OR ? IS" & _
        " NULL AND Division IS NULL)"
        Me.OleDbUpdateCommand2.Connection = Me.cnPayroll
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Division", System.Data.OleDb.OleDbType.VarWChar, 50, "Division"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DivisionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DivisionID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Division", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Division", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Division1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Division", System.Data.DataRowVersion.Original, Nothing))
        '
        'Employees
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(591, 446)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Employees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        CType(Me.DsPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabData.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabList.ResumeLayout(False)
        CType(Me.grdEmpList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim oldcbDivision As String

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case msg.WParam.ToInt32()
            Case 13 ' enter Key 
                If TypeOf Me.ActiveControl Is TextBox Or TypeOf Me.ActiveControl Is ComboBox Then
                    SendKeys.Send("{Tab}")
                    Return True
                End If
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function 'ProcessCmdKey 

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Employees_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnPayroll.ConnectionString = cnSettings()

        daEmployees.Fill(DsPayroll)
        daDivision.Fill(DsPayroll)

        With cbStatus
            .Items.Add("ACTIVE")
            .Items.Add("RESIGNED")
            .Items.Add("RETIRED")
        End With

        With cbDivision
            .DataSource = DsPayroll
            .DisplayMember = "Division.Division"
            .ValueMember = "Division.DivisionID"
            .DataBindings.Add("Tag", DsPayroll.Tables("Employees"), "Division")
            .DataBindings.Add(New Binding("SelectedValue", _
                 DsPayroll, "Employees.Division"))
        End With

        With cbPayMethod
            .Items.Add("MONTHLY")
            .Items.Add("DAILY")
        End With

        BindEmpList()

        Me.BindingContext(DsPayroll, "Employees").Position = 0

        AddHandler Me.BindingContext(DsPayroll, "Employees").PositionChanged, _
            AddressOf Employee_PositionChanged

        DisplayNav(sender, e)
    End Sub

    Sub BindEmpList()

        With grdEmpList
            .CaptionText = "Employees"
            .DataMember = "Employees"
            .DataSource = DsPayroll
        End With

        ' You must clear out the TableStyles collection before 
        grdEmpList.TableStyles.Clear()

        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .MappingName = "Employees"
        End With

        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .MappingName = "AssignCode"
            .HeaderText = "Assign Code"
            .Width = 140
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .MappingName = "LastName"
            .HeaderText = "Last Name"
            .Width = 140
        End With

        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .MappingName = "FirstName"
            .HeaderText = "First Name"
            .Width = 140
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .MappingName = "MiddleName"
            .HeaderText = "M.I."
            .Width = 75
        End With

        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .MappingName = "Section"
            .HeaderText = "Section"
            .Width = 75
        End With

        Dim grdColStyle6 As New DataGridTextBoxColumn
        With grdColStyle6
            .MappingName = "DateHired"
            .HeaderText = "Date Hired"
            .Width = 75
        End With

        Dim grdColStyle7 As New DataGridTextBoxColumn
        With grdColStyle7
            .MappingName = "Phone"
            .HeaderText = "Phone"
            .Width = 75
        End With

        Dim grdColStyle8 As New DataGridTextBoxColumn
        With grdColStyle8
            .MappingName = "Status"
            .HeaderText = "Status"
            .Width = 75
        End With

        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() {grdColStyle1, grdColStyle2, _
                grdColStyle3, grdColStyle4, grdColStyle5, _
                grdColStyle6, grdColStyle7, grdColStyle8})
        grdEmpList.TableStyles.Add(grdTableStyle1)
    End Sub

    Private Sub DisplayNav(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click, btnPrev.Click, btnNext.Click, btnLast.Click, btnDelete.Click
        'Update record position when Update & Delete events
        lblNavLocation.Text = Me.BindingContext(DsPayroll, "Employees").Position + 1 & " of " & Me.BindingContext(DsPayroll, "Employees").Count
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Save_Record()
        Me.BindingContext(DsPayroll, "Employees").Position += 1
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        Save_Record()
        Me.BindingContext(DsPayroll, "Employees").Position -= 1
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Save_Record()
        Me.BindingContext(DsPayroll, "Employees").Position = Me.BindingContext(DsPayroll, "Employees").Count - 1
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        Save_Record()
        Me.BindingContext(DsPayroll, "Employees").Position = 0
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "&Add" Then
            Me.BindingContext(DsPayroll, "Employees").AddNew()
            cbDivision.Text = ""
            Change_Button(False)
            btnAdd.Text = "&Revert"
        Else
            Me.BindingContext(DsPayroll, "Employees").CancelCurrentEdit()
            Change_Button(True)
            btnAdd.Text = "&Add"
            DisplayNav(sender, e)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If btnAdd.Text = "&Revert" Then
                If txtCode.Text = "" Then
                    MessageBox.Show("Please don't leave assign code field blank.", "Error", MessageBoxButtons.OK)
                    Exit Sub
                End If
            End If
            Save_Record()
            Change_Button(True)
            btnAdd.Text = "&Add"

            DisplayNav(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            Me.BindingContext(DsPayroll, "Employees").RemoveAt(Me.BindingContext(DsPayroll, "Employees").Position)

            Save_Record()

            DisplayNav(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Save_Record()
        Try
            Me.BindingContext(DsPayroll, "Employees").EndCurrentEdit()

            daEmployees.Update(DsPayroll)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Change_Button(ByVal bval As Boolean)
        btnFirst.Enabled = bval
        btnPrev.Enabled = bval
        btnNext.Enabled = bval
        btnLast.Enabled = bval
        btnDelete.Enabled = bval
        btnExit.Enabled = bval
    End Sub

    Private Sub txtDailyRate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDailyRate.LostFocus
        If IsValidTextbox(txtDailyRate) = False Then Exit Sub
    End Sub

    Private Sub txtAllowance_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAllowance.LostFocus
        If IsValidTextbox(txtAllowance) = False Then Exit Sub
    End Sub

    Private Sub txtIncentives_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIncentives.LostFocus
        If IsValidTextbox(txtIncentives) = False Then Exit Sub
    End Sub

    Private Sub cbDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDivision.SelectedIndexChanged
        oldcbDivision = cbDivision.Text
    End Sub

    Private Sub cbDivision_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDivision.SelectionChangeCommitted
        If cbDivision.Text = "Add Division" Then
            Dim Division As New Division

            cbDivision.Text = oldcbDivision

            Division.ShowDialog()

            daDivision.Fill(DsPayroll)
        End If
    End Sub

    Private Sub Employee_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        DisplayNav(sender, e)
    End Sub
End Class
