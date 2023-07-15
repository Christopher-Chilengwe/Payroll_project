Option Explicit On 

Imports System.Data.OleDb

Public Class Payroll
    Inherits System.Windows.Forms.Form

    Dim ACCESS_CONNECTION_STRING As String = cnSettings()
    Dim strSelectedAssignCode As String
    Dim dblAllowance As Double
    Dim dblIncentives As Double
    Dim intIndex As Integer

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtIncentives As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtHolPayTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSunOTTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtHolPay As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSunOT As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRegOT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtWorkDays As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDailyRate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtRegOTTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtDed3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDed2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDed1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd3 As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd1 As System.Windows.Forms.TextBox
    Friend WithEvents txtLates As System.Windows.Forms.TextBox
    Friend WithEvents txtSSSLoan As System.Windows.Forms.TextBox
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents txtSSS As System.Windows.Forms.TextBox
    Friend WithEvents txtGross As System.Windows.Forms.TextBox
    Friend WithEvents txtNetIncome As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpFromPay As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpToPay As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDedDesc3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDedDesc2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDedDesc1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddDesc3 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddDesc2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddDesc1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalDed As System.Windows.Forms.TextBox
    Friend WithEvents txtAllowance As System.Windows.Forms.TextBox
    Friend WithEvents lvName As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.dtpToPay = New System.Windows.Forms.DateTimePicker
        Me.dtpFromPay = New System.Windows.Forms.DateTimePicker
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label22 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.lvName = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtTotalDed = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtDed3 = New System.Windows.Forms.TextBox
        Me.txtDedDesc3 = New System.Windows.Forms.TextBox
        Me.txtDed2 = New System.Windows.Forms.TextBox
        Me.txtDedDesc2 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtDed1 = New System.Windows.Forms.TextBox
        Me.txtDedDesc1 = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtLates = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtSSSLoan = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtTax = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtSSS = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtNetIncome = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDailyRate = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtRegOTTotal = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtGross = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtAdd3 = New System.Windows.Forms.TextBox
        Me.txtAddDesc3 = New System.Windows.Forms.TextBox
        Me.txtAdd2 = New System.Windows.Forms.TextBox
        Me.txtAddDesc2 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtAdd1 = New System.Windows.Forms.TextBox
        Me.txtAddDesc1 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtIncentives = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtAllowance = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtHolPayTotal = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSunOTTotal = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtHolPay = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSunOT = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtRegOT = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtWorkDays = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.lvName)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.txtNetIncome)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 417)
        Me.Panel1.TabIndex = 31
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dtpToPay)
        Me.GroupBox4.Controls.Add(Me.dtpFromPay)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 48)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 66)
        Me.GroupBox4.TabIndex = 54
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'dtpToPay
        '
        Me.dtpToPay.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpToPay.Location = New System.Drawing.Point(66, 42)
        Me.dtpToPay.Name = "dtpToPay"
        Me.dtpToPay.Size = New System.Drawing.Size(126, 20)
        Me.dtpToPay.TabIndex = 10
        '
        'dtpFromPay
        '
        Me.dtpFromPay.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFromPay.Location = New System.Drawing.Point(66, 18)
        Me.dtpFromPay.Name = "dtpFromPay"
        Me.dtpFromPay.Size = New System.Drawing.Size(126, 20)
        Me.dtpFromPay.TabIndex = 9
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(9, 42)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(51, 21)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "To:"
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(9, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(51, 21)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "From:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(732, 38)
        Me.Panel2.TabIndex = 53
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label22.Location = New System.Drawing.Point(4, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(348, 23)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Payroll"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(651, 378)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 30
        Me.btnExit.Text = "Exit"
        '
        'lvName
        '
        Me.lvName.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvName.FullRowSelect = True
        Me.lvName.GridLines = True
        Me.lvName.HideSelection = False
        Me.lvName.Location = New System.Drawing.Point(9, 117)
        Me.lvName.MultiSelect = False
        Me.lvName.Name = "lvName"
        Me.lvName.Size = New System.Drawing.Size(201, 291)
        Me.lvName.TabIndex = 1
        Me.lvName.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Code"
        Me.ColumnHeader1.Width = 70
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 120
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(549, 378)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Save"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTotalDed)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtDed3)
        Me.GroupBox3.Controls.Add(Me.txtDedDesc3)
        Me.GroupBox3.Controls.Add(Me.txtDed2)
        Me.GroupBox3.Controls.Add(Me.txtDedDesc2)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtDed1)
        Me.GroupBox3.Controls.Add(Me.txtDedDesc1)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtLates)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtSSSLoan)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtTax)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtSSS)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(525, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(213, 276)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Deductions"
        '
        'txtTotalDed
        '
        Me.txtTotalDed.Enabled = False
        Me.txtTotalDed.Location = New System.Drawing.Point(135, 246)
        Me.txtTotalDed.Name = "txtTotalDed"
        Me.txtTotalDed.Size = New System.Drawing.Size(66, 20)
        Me.txtTotalDed.TabIndex = 27
        Me.txtTotalDed.TabStop = False
        Me.txtTotalDed.Text = "0.00"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(6, 246)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(123, 21)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "TOTAL DEDUCTIONS:"
        '
        'txtDed3
        '
        Me.txtDed3.Location = New System.Drawing.Point(135, 219)
        Me.txtDed3.Name = "txtDed3"
        Me.txtDed3.Size = New System.Drawing.Size(66, 20)
        Me.txtDed3.TabIndex = 23
        Me.txtDed3.Text = "0.00"
        '
        'txtDedDesc3
        '
        Me.txtDedDesc3.Location = New System.Drawing.Point(63, 219)
        Me.txtDedDesc3.Name = "txtDedDesc3"
        Me.txtDedDesc3.Size = New System.Drawing.Size(66, 20)
        Me.txtDedDesc3.TabIndex = 22
        Me.txtDedDesc3.Text = ""
        '
        'txtDed2
        '
        Me.txtDed2.Location = New System.Drawing.Point(135, 198)
        Me.txtDed2.Name = "txtDed2"
        Me.txtDed2.Size = New System.Drawing.Size(66, 20)
        Me.txtDed2.TabIndex = 21
        Me.txtDed2.Text = "0.00"
        '
        'txtDedDesc2
        '
        Me.txtDedDesc2.Location = New System.Drawing.Point(63, 198)
        Me.txtDedDesc2.Name = "txtDedDesc2"
        Me.txtDedDesc2.Size = New System.Drawing.Size(66, 20)
        Me.txtDedDesc2.TabIndex = 20
        Me.txtDedDesc2.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(63, 153)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 18)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Desc:"
        '
        'txtDed1
        '
        Me.txtDed1.Location = New System.Drawing.Point(135, 174)
        Me.txtDed1.Name = "txtDed1"
        Me.txtDed1.Size = New System.Drawing.Size(66, 20)
        Me.txtDed1.TabIndex = 19
        Me.txtDed1.Text = "0.00"
        '
        'txtDedDesc1
        '
        Me.txtDedDesc1.Location = New System.Drawing.Point(63, 174)
        Me.txtDedDesc1.Name = "txtDedDesc1"
        Me.txtDedDesc1.Size = New System.Drawing.Size(66, 20)
        Me.txtDedDesc1.TabIndex = 18
        Me.txtDedDesc1.Text = ""
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(63, 129)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 21)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Others:"
        '
        'txtLates
        '
        Me.txtLates.Location = New System.Drawing.Point(135, 102)
        Me.txtLates.Name = "txtLates"
        Me.txtLates.Size = New System.Drawing.Size(66, 20)
        Me.txtLates.TabIndex = 17
        Me.txtLates.Text = "0.00"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(63, 102)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 21)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Lates:"
        '
        'txtSSSLoan
        '
        Me.txtSSSLoan.Location = New System.Drawing.Point(135, 78)
        Me.txtSSSLoan.Name = "txtSSSLoan"
        Me.txtSSSLoan.Size = New System.Drawing.Size(66, 20)
        Me.txtSSSLoan.TabIndex = 16
        Me.txtSSSLoan.Text = "0.00"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(63, 78)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 21)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "SSS Loan:"
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(135, 54)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(66, 20)
        Me.txtTax.TabIndex = 15
        Me.txtTax.Text = "0.00"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(63, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 21)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "W/Tax:"
        '
        'txtSSS
        '
        Me.txtSSS.Location = New System.Drawing.Point(135, 30)
        Me.txtSSS.Name = "txtSSS"
        Me.txtSSS.Size = New System.Drawing.Size(66, 20)
        Me.txtSSS.TabIndex = 14
        Me.txtSSS.Text = "0.00"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(63, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 21)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "SSS/MCR:"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(570, 330)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 21)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "NET INCOME:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNetIncome
        '
        Me.txtNetIncome.Enabled = False
        Me.txtNetIncome.Location = New System.Drawing.Point(660, 330)
        Me.txtNetIncome.Name = "txtNetIncome"
        Me.txtNetIncome.Size = New System.Drawing.Size(66, 20)
        Me.txtNetIncome.TabIndex = 28
        Me.txtNetIncome.TabStop = False
        Me.txtNetIncome.Text = "0.00"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtDailyRate)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtWorkDays)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(219, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 363)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Income"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(219, 42)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(66, 20)
        Me.txtTotal.TabIndex = 19
        Me.txtTotal.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(147, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 21)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Total:"
        '
        'txtDailyRate
        '
        Me.txtDailyRate.Enabled = False
        Me.txtDailyRate.Location = New System.Drawing.Point(219, 18)
        Me.txtDailyRate.Name = "txtDailyRate"
        Me.txtDailyRate.Size = New System.Drawing.Size(66, 20)
        Me.txtDailyRate.TabIndex = 17
        Me.txtDailyRate.Text = "0.00"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(147, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Basic Rate:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtRegOTTotal)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txtGross)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtAdd3)
        Me.GroupBox2.Controls.Add(Me.txtAddDesc3)
        Me.GroupBox2.Controls.Add(Me.txtAdd2)
        Me.GroupBox2.Controls.Add(Me.txtAddDesc2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtAdd1)
        Me.GroupBox2.Controls.Add(Me.txtAddDesc1)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtIncentives)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtAllowance)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtHolPayTotal)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtSunOTTotal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtHolPay)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtSunOT)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtRegOT)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(285, 285)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OT Hrs. / Day"
        '
        'txtRegOTTotal
        '
        Me.txtRegOTTotal.Enabled = False
        Me.txtRegOTTotal.Location = New System.Drawing.Point(210, 21)
        Me.txtRegOTTotal.Name = "txtRegOTTotal"
        Me.txtRegOTTotal.Size = New System.Drawing.Size(66, 20)
        Me.txtRegOTTotal.TabIndex = 33
        Me.txtRegOTTotal.Text = "0.00"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(138, 21)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 21)
        Me.Label23.TabIndex = 32
        Me.Label23.Text = "Reg. OT"
        '
        'txtGross
        '
        Me.txtGross.Enabled = False
        Me.txtGross.Location = New System.Drawing.Point(210, 255)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.Size = New System.Drawing.Size(66, 20)
        Me.txtGross.TabIndex = 26
        Me.txtGross.TabStop = False
        Me.txtGross.Text = "0.00"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(138, 255)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 21)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "GROSS:"
        '
        'txtAdd3
        '
        Me.txtAdd3.Location = New System.Drawing.Point(210, 228)
        Me.txtAdd3.Name = "txtAdd3"
        Me.txtAdd3.Size = New System.Drawing.Size(66, 20)
        Me.txtAdd3.TabIndex = 13
        Me.txtAdd3.Text = "0.00"
        '
        'txtAddDesc3
        '
        Me.txtAddDesc3.Location = New System.Drawing.Point(138, 228)
        Me.txtAddDesc3.Name = "txtAddDesc3"
        Me.txtAddDesc3.Size = New System.Drawing.Size(66, 20)
        Me.txtAddDesc3.TabIndex = 12
        Me.txtAddDesc3.Text = ""
        '
        'txtAdd2
        '
        Me.txtAdd2.Location = New System.Drawing.Point(210, 207)
        Me.txtAdd2.Name = "txtAdd2"
        Me.txtAdd2.Size = New System.Drawing.Size(66, 20)
        Me.txtAdd2.TabIndex = 11
        Me.txtAdd2.Text = "0.00"
        '
        'txtAddDesc2
        '
        Me.txtAddDesc2.Location = New System.Drawing.Point(138, 207)
        Me.txtAddDesc2.Name = "txtAddDesc2"
        Me.txtAddDesc2.Size = New System.Drawing.Size(66, 20)
        Me.txtAddDesc2.TabIndex = 10
        Me.txtAddDesc2.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(138, 162)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 18)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Desc:"
        '
        'txtAdd1
        '
        Me.txtAdd1.Location = New System.Drawing.Point(210, 183)
        Me.txtAdd1.Name = "txtAdd1"
        Me.txtAdd1.Size = New System.Drawing.Size(66, 20)
        Me.txtAdd1.TabIndex = 9
        Me.txtAdd1.Text = "0.00"
        '
        'txtAddDesc1
        '
        Me.txtAddDesc1.Location = New System.Drawing.Point(138, 183)
        Me.txtAddDesc1.Name = "txtAddDesc1"
        Me.txtAddDesc1.Size = New System.Drawing.Size(66, 20)
        Me.txtAddDesc1.TabIndex = 8
        Me.txtAddDesc1.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(138, 138)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 21)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Others:"
        '
        'txtIncentives
        '
        Me.txtIncentives.Location = New System.Drawing.Point(210, 114)
        Me.txtIncentives.Name = "txtIncentives"
        Me.txtIncentives.Size = New System.Drawing.Size(66, 20)
        Me.txtIncentives.TabIndex = 7
        Me.txtIncentives.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(138, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 21)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Incentives:"
        '
        'txtAllowance
        '
        Me.txtAllowance.Location = New System.Drawing.Point(210, 90)
        Me.txtAllowance.Name = "txtAllowance"
        Me.txtAllowance.Size = New System.Drawing.Size(66, 20)
        Me.txtAllowance.TabIndex = 6
        Me.txtAllowance.Text = "0.00"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(138, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 21)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Allowance:"
        '
        'txtHolPayTotal
        '
        Me.txtHolPayTotal.Enabled = False
        Me.txtHolPayTotal.Location = New System.Drawing.Point(210, 66)
        Me.txtHolPayTotal.Name = "txtHolPayTotal"
        Me.txtHolPayTotal.Size = New System.Drawing.Size(66, 20)
        Me.txtHolPayTotal.TabIndex = 13
        Me.txtHolPayTotal.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(138, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Hol. Pay:"
        '
        'txtSunOTTotal
        '
        Me.txtSunOTTotal.Enabled = False
        Me.txtSunOTTotal.Location = New System.Drawing.Point(210, 42)
        Me.txtSunOTTotal.Name = "txtSunOTTotal"
        Me.txtSunOTTotal.Size = New System.Drawing.Size(66, 20)
        Me.txtSunOTTotal.TabIndex = 11
        Me.txtSunOTTotal.Text = "0.00"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(138, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sun. OT:"
        '
        'txtHolPay
        '
        Me.txtHolPay.Location = New System.Drawing.Point(69, 66)
        Me.txtHolPay.Name = "txtHolPay"
        Me.txtHolPay.Size = New System.Drawing.Size(66, 20)
        Me.txtHolPay.TabIndex = 5
        Me.txtHolPay.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hol. Pay:"
        '
        'txtSunOT
        '
        Me.txtSunOT.Location = New System.Drawing.Point(69, 42)
        Me.txtSunOT.Name = "txtSunOT"
        Me.txtSunOT.Size = New System.Drawing.Size(66, 20)
        Me.txtSunOT.TabIndex = 4
        Me.txtSunOT.Text = "0.0000"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sun. OT:"
        '
        'txtRegOT
        '
        Me.txtRegOT.Location = New System.Drawing.Point(69, 18)
        Me.txtRegOT.Name = "txtRegOT"
        Me.txtRegOT.Size = New System.Drawing.Size(66, 20)
        Me.txtRegOT.TabIndex = 3
        Me.txtRegOT.Text = "0.0000"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Reg. OT:"
        '
        'txtWorkDays
        '
        Me.txtWorkDays.Location = New System.Drawing.Point(81, 18)
        Me.txtWorkDays.Name = "txtWorkDays"
        Me.txtWorkDays.Size = New System.Drawing.Size(63, 20)
        Me.txtWorkDays.TabIndex = 2
        Me.txtWorkDays.Text = "0.0000"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "# work days:"
        '
        'Payroll
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(756, 426)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Payroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case msg.WParam.ToInt32()
            Case 13 ' enter Key 
                If TypeOf Me.ActiveControl Is TextBox Then
                    SendKeys.Send("{Tab}")
                    Return True
                End If
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function 'ProcessCmdKey 

    Private Sub Payroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateNameList()
    End Sub

    Private Sub PopulateNameList()
        Dim Connection As New OleDbConnection(ACCESS_CONNECTION_STRING)

        lvName.Items.Clear()
        lvName.Sorting = SortOrder.Ascending

        Dim cmdfill As New OleDbCommand("SELECT AssignCode, LastName & ', ' & FirstName & ' ' & MiddleName as Name FROM Employees", Connection)

        Try
            Connection.Open()

            Dim datareader As OleDbDataReader

            datareader = cmdfill.ExecuteReader

            While datareader.Read
                Dim lvi As New ListViewItem
                lvi.Text = CStr(datareader("AssignCode"))
                lvi.SubItems.Add(CStr(datareader("Name")))
                lvName.Items.Add(lvi)
            End While

            If datareader.HasRows Then
                lvName.TopItem.Selected = True
                lvName.TopItem.Focused = True
                lvName.TopItem.EnsureVisible()
                lvName.Select()

                'lvName.Items(0).Selected = True
                'strSelectedAssignCode = lvName.Items(0).SubItems(0).Text
                lvName_SelectedIndexChanged(Nothing, Nothing)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Connection.Close()
        End Try
    End Sub

    Private Sub lvName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvName.SelectedIndexChanged
        Dim cnOleDb As OleDbConnection
        Dim cmSQL As OleDbCommand
        Dim drSQL As OleDbDataReader
        Dim strSQL As String
        'Dim strID As String
        Dim ThisItem As ListViewItem

        If IsNothing(lvName.FocusedItem) Then Exit Sub

        For Each ThisItem In lvName.SelectedItems
            strSelectedAssignCode = lvName.Items(ThisItem.Index).SubItems(0).Text
        Next
        'strSelectedAssignCode = lvName.FocusedItem.Text

        Try
            strSQL = "SELECT AssignCode, " & _
             "DailyRate, " & _
             "Allowance, " & _
             "Incentives " & _
             "FROM Employees " & _
             "WHERE AssignCode = '" & strSelectedAssignCode & "'"

            cnOleDb = New OleDbConnection(ACCESS_CONNECTION_STRING)
            cnOleDb.Open()

            cmSQL = New OleDbCommand(strSQL, cnOleDb)
            drSQL = cmSQL.ExecuteReader()

            drSQL.Read()

            txtDailyRate.Text = Format(Convert.ToDouble(drSQL.Item("DailyRate").ToString()), "0.00")
            dblAllowance = Format(Convert.ToDouble(drSQL.Item("Allowance").ToString()), "0.00")
            txtAllowance.Text = dblAllowance
            dblIncentives = Format(Convert.ToDouble(drSQL.Item("Incentives").ToString()), "0.00")
            txtIncentives.Text = dblIncentives

            ' Close and Clean up objects
            drSQL.Close()
            cnOleDb.Close()
            cmSQL.Dispose()
            cnOleDb.Dispose()

            GetPayslip()

            txtTotal.Text = Format(txtWorkDays.Text * txtDailyRate.Text, "0.00")
            Calc_Gross()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "General Error")
        End Try
    End Sub

    Private Sub GetPayslip()
        Dim cnOleDb As OleDbConnection
        Dim cmSQL As OleDbCommand
        Dim drSQL As OleDbDataReader
        Dim strSQL As String
        'Dim strID As String

        If IsNothing(lvName.FocusedItem) Then Exit Sub

        'strSelectedAssignCode = lvName.FocusedItem.Text

        Try
            strSQL = "SELECT * " & _
             "FROM Payroll " & _
             "WHERE AssignCode = '" & strSelectedAssignCode & "' And FromPay = #" & dtpFromPay.Text & "# And ToPay = #" & dtpToPay.Text & "#"

            cnOleDb = New OleDbConnection(ACCESS_CONNECTION_STRING)
            cnOleDb.Open()

            cmSQL = New OleDbCommand(strSQL, cnOleDb)
            drSQL = cmSQL.ExecuteReader()

            If drSQL.HasRows Then
                drSQL.Read()
                txtWorkDays.Text = drSQL.Item("NoWorkDays").ToString()
                txtWorkDays.Text = Format(CDbl(txtWorkDays.Text), "0.0000")
                txtRegOT.Text = Format(CDbl(drSQL.Item("RegOT").ToString()), "0.0000")
                txtSunOT.Text = Format(CDbl(drSQL.Item("SunOT").ToString()), "0.0000")
                txtHolPay.Text = Format(Convert.ToDouble(drSQL.Item("HolOT").ToString()), "0.00")
                txtAdd1.Text = Format(Convert.ToDouble(drSQL.Item("Add1").ToString()), "0.00")
                txtAdd2.Text = Format(Convert.ToDouble(drSQL.Item("Add2").ToString()), "0.00")
                txtAdd3.Text = Format(Convert.ToDouble(drSQL.Item("Add3").ToString()), "0.00")
                txtAddDesc1.Text = drSQL.Item("AddDesc1").ToString()
                txtAddDesc2.Text = drSQL.Item("AddDesc2").ToString()
                txtAddDesc3.Text = drSQL.Item("AddDesc3").ToString()
                txtSSS.Text = Format(Convert.ToDouble(drSQL.Item("SSS_MCR").ToString()), "0.00")
                txtTax.Text = Format(Convert.ToDouble(drSQL.Item("WTax").ToString()), "0.00")
                txtSSSLoan.Text = Format(Convert.ToDouble(drSQL.Item("SSS_Loans").ToString()), "0.00")
                txtLates.Text = Format(Convert.ToDouble(drSQL.Item("Lates").ToString()), "0.00")
                txtDed1.Text = Format(Convert.ToDouble(drSQL.Item("Ded1").ToString()), "0.00")
                txtDed2.Text = Format(Convert.ToDouble(drSQL.Item("Ded2").ToString()), "0.00")
                txtDed3.Text = Format(Convert.ToDouble(drSQL.Item("Ded3").ToString()), "0.00")
                txtDedDesc1.Text = drSQL.Item("DedDesc1").ToString()
                txtDedDesc2.Text = drSQL.Item("DedDesc2").ToString()
                txtDedDesc3.Text = drSQL.Item("DedDesc3").ToString()

                ' Close and Clean up objects
                drSQL.Close()
                cnOleDb.Close()
                cmSQL.Dispose()
                cnOleDb.Dispose()
            End If

            txtRegOTTotal.Text = Format(((txtDailyRate.Text / 8) * 1.25) * txtRegOT.Text, "0.00")
            txtSunOTTotal.Text = Format(((txtDailyRate.Text / 8) * 1.3) * txtSunOT.Text, "0.00")
            txtHolPayTotal.Text = Format(txtDailyRate.Text * txtHolPay.Text, "0.00")
            txtIncentives.Text = Format(txtIncentives.Text * txtWorkDays.Text, "0.00")
            txtAllowance.Text = Format(txtAllowance.Text * txtWorkDays.Text, "0.00")

            Calc_Gross()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "General Error")
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If strSelectedAssignCode = "" Then
            MsgBox("Please select employee", MsgBoxStyle.OKOnly)
            Exit Sub
        End If

        If txtWorkDays.Text > 0 Then
            Dim ReturnValue As String = isRecordExist()

            If ReturnValue = "Exist" Then
                If MsgBox("Payslip already exist for this employee." & vbCrLf & vbCrLf & "Do you want to overight existing record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    UpdatePaySlip()
                End If
                SelectIndex()
                lvName_SelectedIndexChanged(sender, e)
            ElseIf ReturnValue <> "Error" Then
                AddPaySlip()
                SelectIndex()
                lvName_SelectedIndexChanged(sender, e)
            End If
        Else
            MsgBox("Please enter No. of Working days.", MsgBoxStyle.OKOnly)
        End If
    End Sub

    Private Function isRecordExist() As String
        Dim Connection As New OleDbConnection(ACCESS_CONNECTION_STRING)

        Dim cmdfill As New OleDbCommand("SELECT AssignCode, FromPay, ToPay FROM Payroll Where AssignCode = '" & strSelectedAssignCode & "' And FromPay = #" & dtpFromPay.Text & "# And ToPay = #" & dtpToPay.Text & "#", Connection)

        Try
            Connection.Open()

            Dim datareader As OleDbDataReader

            datareader = cmdfill.ExecuteReader

            If datareader.HasRows Then Return "Exist"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return "Error"
        Finally
            Connection.Close()
            Connection.Dispose()
        End Try
    End Function

    Private Sub AddPaySlip()
        Try
            'Dim dbCommand As OleDbCommand
            Dim DBConn As OleDbConnection
            Dim DBInsert As New OleDbCommand

            DBConn = New OleDbConnection(ACCESS_CONNECTION_STRING)

            DBInsert.CommandText = "INSERT INTO Payroll VALUES (" _
            & "'" & dtpFromPay.Text & "', " _
            & "'" & dtpToPay.Text & "', " _
            & "'" & strSelectedAssignCode & "', " _
            & "'" & txtWorkDays.Text & "', " _
            & "'" & txtDailyRate.Text & "', " _
            & "'" & txtTotal.Text & "', " _
            & "'" & txtRegOT.Text & "', " _
            & "'" & txtSunOT.Text & "', " _
            & "'" & txtHolPay.Text & "', " _
            & "'" & txtRegOTTotal.Text & "', " _
            & "'" & txtSunOTTotal.Text & "', " _
            & "'" & txtHolPayTotal.Text & "', " _
            & "'" & txtAdd1.Text & "', " _
            & "'" & txtAdd2.Text & "', " _
            & "'" & txtAdd3.Text & "', " _
            & "'" & txtAddDesc1.Text & "', " _
            & "'" & txtAddDesc2.Text & "', " _
            & "'" & txtAddDesc3.Text & "', " _
            & "'" & txtIncentives.Text & "', " _
            & "'" & txtAllowance.Text & "', " _
            & "'" & txtGross.Text & "', " _
            & "'" & txtSSS.Text & "', " _
            & "'" & txtTax.Text & "', " _
            & "'" & txtSSSLoan.Text & "', " _
            & "'" & txtLates.Text & "', " _
            & "'" & txtDed1.Text & "', " _
            & "'" & txtDed2.Text & "', " _
            & "'" & txtDed3.Text & "', " _
            & "'" & txtDedDesc1.Text & "', " _
            & "'" & txtDedDesc2.Text & "', " _
            & "'" & txtDedDesc3.Text & "', " _
            & "'" & txtTotalDed.Text & "', " _
            & "'" & txtNetIncome.Text & "', " _
            & "'" & DateTime.Now.ToString & "')"

            DBInsert.Connection = DBConn
            DBInsert.Connection.Open()
            DBInsert.ExecuteNonQuery()
            MsgBox("Payslip created successfully.", MsgBoxStyle.OKOnly)
            DBConn.Close()
            DBConn.Dispose()
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "General Error")
        End Try
    End Sub

    Private Sub UpdatePaySlip()
        Try
            'Dim dbCommand As OleDbCommand
            Dim DBConn As OleDbConnection
            Dim DBUpdate As New OleDbCommand

            DBConn = New OleDbConnection(ACCESS_CONNECTION_STRING)

            DBUpdate.CommandText = "UPDATE Payroll SET " & _
                    "FromPay = #" & dtpFromPay.Text & "#, " & _
                    "ToPay = #" & dtpToPay.Text & "#, " & _
                    "AssignCode = '" & strSelectedAssignCode & "', " & _
                    "NoWorkDays = '" & txtWorkDays.Text & "', " & _
                    "Rate = '" & txtDailyRate.Text & "', " & _
                    "RegWage = '" & txtTotal.Text & "', " & _
                    "RegOT = '" & txtRegOT.Text & "', " & _
                    "SunOT = '" & txtSunOT.Text & "', " & _
                    "HolOT = '" & txtHolPay.Text & "', " & _
                    "RegOTTotal = '" & txtRegOTTotal.Text & "', " & _
                    "SunOTTotal = '" & txtSunOTTotal.Text & "', " & _
                    "HolOTTotal = '" & txtHolPayTotal.Text & "', " & _
                    "Add1 = '" & txtAdd1.Text & "', " & _
                    "Add2 = '" & txtAdd2.Text & "', " & _
                    "Add3 = '" & txtAdd3.Text & "', " & _
                    "AddDesc1 = '" & txtAddDesc1.Text & "', " & _
                    "AddDesc2 = '" & txtAddDesc2.Text & "', " & _
                    "AddDesc3 = '" & txtAddDesc3.Text & "', " & _
                    "Incentives = '" & txtIncentives.Text & "', " & _
                    "Allowance = '" & txtAllowance.Text & "', " & _
                    "GrossPay = '" & txtGross.Text & "', " & _
                    "SSS_MCR = '" & txtSSS.Text & "', " & _
                    "WTax = '" & txtTax.Text & "', " & _
                    "SSS_Loans = '" & txtSSSLoan.Text & "', " & _
                    "Lates = '" & txtLates.Text & "', " & _
                    "Ded1 = '" & txtDed1.Text & "', " & _
                    "Ded2 = '" & txtDed2.Text & "', " & _
                    "Ded3 = '" & txtDed3.Text & "', " & _
                    "DedDesc1 = '" & txtDedDesc1.Text & "', " & _
                    "DedDesc2 = '" & txtDedDesc2.Text & "', " & _
                    "DedDesc3 = '" & txtDedDesc3.Text & "', " & _
                    "TotalDed = '" & txtTotalDed.Text & "', " & _
                    "NetPay = '" & txtNetIncome.Text & "' " & _
                    "WHERE AssignCode = '" & strSelectedAssignCode & "' And " & _
                    "FromPay = #" & dtpFromPay.Text & "# And " & _
                    "ToPay = #" & dtpToPay.Text & "#"

            DBUpdate.Connection = DBConn
            DBUpdate.Connection.Open()
            DBUpdate.ExecuteNonQuery()

            MsgBox("Payslip created successfully.", MsgBoxStyle.OKOnly)

            DBConn.Close()
            DBConn.Dispose()
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "General Error")
        End Try
    End Sub

    Private Sub Calc_Gross()
        Try
            txtGross.Text = Convert.ToDouble(IIf(txtTotal.Text = "", "0.00", txtTotal.Text)) _
                            + Convert.ToDouble(IIf(txtRegOTTotal.Text = "", "0.00", txtRegOTTotal.Text)) _
                            + Convert.ToDouble(IIf(txtSunOTTotal.Text = "", "0.00", txtSunOTTotal.Text)) _
                            + Convert.ToDouble(IIf(txtHolPayTotal.Text = "", "0.00", txtHolPayTotal.Text)) _
                            + Convert.ToDouble(IIf(txtAllowance.Text = "", "0.00", txtAllowance.Text)) _
                            + Convert.ToDouble(IIf(txtIncentives.Text = "", "0.00", txtIncentives.Text)) _
                            + Convert.ToDouble(IIf(txtAdd1.Text = "", "0.00", txtAdd1.Text)) _
                            + Convert.ToDouble(IIf(txtAdd2.Text = "", "0.00", txtAdd2.Text)) _
                            + Convert.ToDouble(IIf(txtAdd3.Text = "", "0.00", txtAdd3.Text))
            txtGross.Text = Format(CDbl(txtGross.Text), "0.00")
            Calc_Deductions()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "General Error")
        End Try
    End Sub

    Private Sub Calc_Deductions()
        Try
            txtTotalDed.Text = Convert.ToDouble(IIf(txtSSS.Text = "", "0.00", txtSSS.Text)) _
                            + Convert.ToDouble(IIf(txtTax.Text = "", "0.00", txtTax.Text)) _
                            + Convert.ToDouble(IIf(txtSSSLoan.Text = "", "0.00", txtSSSLoan.Text)) _
                            + Convert.ToDouble(IIf(txtLates.Text = "", "0.00", txtLates.Text)) _
                            + Convert.ToDouble(IIf(txtDed1.Text = "", "0.00", txtDed1.Text)) _
                            + Convert.ToDouble(IIf(txtDed2.Text = "", "0.00", txtDed2.Text)) _
                            + Convert.ToDouble(IIf(txtDed3.Text = "", "0.00", txtDed3.Text))
            txtTotalDed.Text = Format(CDbl(txtTotalDed.Text), "0.00")
            txtNetIncome.Text = Convert.ToDouble(IIf(txtGross.Text = "", "0.00", txtGross.Text) - IIf(txtTotalDed.Text = "", "0.00", txtTotalDed.Text))
            txtNetIncome.Text = Format(CDbl(txtNetIncome.Text), "0.00")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "General Error")
        End Try

    End Sub

    Private Sub txtWorkDays_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWorkDays.LostFocus
        If IsNumeric(txtWorkDays.Text) = False Then
            MsgBox("Please enter correct information", MsgBoxStyle.OKOnly)
            txtWorkDays.Focus()
            txtWorkDays.SelectAll()
            Exit Sub
        End If

        txtWorkDays.Text = Format(CDbl(txtWorkDays.Text), "0.0000")
        txtAllowance.Text = Format(dblAllowance * txtWorkDays.Text, "0.00")
        txtIncentives.Text = Format(dblIncentives * txtWorkDays.Text, "0.00")
        txtTotal.Text = Format(txtWorkDays.Text * txtDailyRate.Text, "0.00")
        Calc_Gross()
    End Sub

    Private Sub txtRegOT_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRegOT.LostFocus
        If IsNumeric(txtRegOT.Text) = False Then
            MsgBox("Please enter correct information", MsgBoxStyle.OKOnly)
            txtRegOT.Focus()
            txtRegOT.SelectAll()
            Exit Sub
        End If

        txtRegOT.Text = Format(CDbl(txtRegOT.Text), "0.0000")
        txtRegOTTotal.Text = Format(((txtDailyRate.Text / 8) * 1.25) * txtRegOT.Text, "0.00")
        Calc_Gross()
    End Sub

    Private Sub txtSunOT_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSunOT.LostFocus
        If IsNumeric(txtSunOT.Text) = False Then
            MsgBox("Please enter correct information", MsgBoxStyle.OKOnly)
            txtSunOT.Focus()
            txtSunOT.SelectAll()
            Exit Sub
        End If

        txtSunOT.Text = Format(CDbl(txtSunOT.Text), "0.0000")
        txtSunOTTotal.Text = Format(((txtDailyRate.Text / 8) * 1.3) * txtSunOT.Text, "0.00")
        Calc_Gross()
    End Sub

    Private Sub txtHolPay_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHolPay.LostFocus
        If IsNumeric(txtHolPay.Text) = False Then
            MsgBox("Please enter correct information", MsgBoxStyle.OKOnly)
            txtHolPay.Focus()
            txtHolPay.SelectAll()
            Exit Sub
        End If

        If IsValidTextbox(txtHolPay) = False Then Exit Sub

        txtHolPayTotal.Text = Format(txtDailyRate.Text * txtHolPay.Text, "0.00")
        Calc_Gross()
    End Sub

    Private Sub txtAllowance_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAllowance.LostFocus
        If IsValidTextbox(txtAllowance) = False Then Exit Sub
        Calc_Gross()
    End Sub

    Private Sub txtIncentives_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIncentives.LostFocus
        If IsValidTextbox(txtIncentives) = False Then Exit Sub
        Calc_Gross()
    End Sub

    Private Sub txtAdd1_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdd1.LostFocus
        If IsValidTextbox(txtAdd1) = False Then Exit Sub
        Calc_Gross()
    End Sub

    Private Sub txtAdd2_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdd2.LostFocus
        If IsValidTextbox(txtAdd2) = False Then Exit Sub
        Calc_Gross()
    End Sub

    Private Sub txtAdd3_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdd3.LostFocus
        If IsValidTextbox(txtAdd3) = False Then Exit Sub
        Calc_Gross()
    End Sub

    Private Sub txtSSS_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSSS.LostFocus
        If IsValidTextbox(txtSSS) = False Then Exit Sub
        Calc_Deductions()
    End Sub

    Private Sub txtTax_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTax.LostFocus
        If IsValidTextbox(txtTax) = False Then Exit Sub
        Calc_Deductions()
    End Sub

    Private Sub txtSSSLoan_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSSSLoan.LostFocus
        If IsValidTextbox(txtSSSLoan) = False Then Exit Sub
        Calc_Deductions()
    End Sub

    Private Sub txtLates_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLates.LostFocus
        If IsValidTextbox(txtLates) = False Then Exit Sub
        Calc_Deductions()
    End Sub

    Private Sub txtDed1_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDed1.LostFocus
        If IsValidTextbox(txtDed1) = False Then Exit Sub
        Calc_Deductions()
    End Sub

    Private Sub txtDed2_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDed2.LostFocus
        If IsValidTextbox(txtDed2) = False Then Exit Sub
        Calc_Deductions()
    End Sub

    Private Sub txtDed3_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDed3.LostFocus
        If IsValidTextbox(txtDed3) = False Then Exit Sub
        Calc_Deductions()
    End Sub

    Private Sub SelectIndex()
        Dim ThisItem As ListViewItem
        Dim intNumRows As Integer

        Try
            For Each ThisItem In lvName.SelectedItems
                intNumRows = lvName.Items.Count
                If ThisItem.Index + 1 <> intNumRows Then
                    lvName.Items(ThisItem.Index + 1).Selected = True
                    strSelectedAssignCode = lvName.Items(ThisItem.Index + 1).SubItems(0).Text
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly)
        End Try
    End Sub

    Private Sub dtpFromPay_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFromPay.ValueChanged
        lvName_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub dtpToPay_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpToPay.ValueChanged
        lvName_SelectedIndexChanged(sender, e)
    End Sub

End Class
