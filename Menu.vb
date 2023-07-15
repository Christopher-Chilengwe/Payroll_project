Public Class Menu
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnPayroll As System.Windows.Forms.Button
    Friend WithEvents btnEmployees As System.Windows.Forms.Button
    Friend WithEvents btnCompProfile As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSecurity As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnSecurity = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnReports = New System.Windows.Forms.Button
        Me.btnPayroll = New System.Windows.Forms.Button
        Me.btnEmployees = New System.Windows.Forms.Button
        Me.btnCompProfile = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btnAbout = New System.Windows.Forms.Button
        Me.btnQuit = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(6, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(489, 276)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.btnSecurity)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btnReports)
        Me.Panel3.Controls.Add(Me.btnPayroll)
        Me.Panel3.Controls.Add(Me.btnEmployees)
        Me.Panel3.Controls.Add(Me.btnCompProfile)
        Me.Panel3.Location = New System.Drawing.Point(6, 78)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(474, 186)
        Me.Panel3.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(300, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 23)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Security"
        '
        'btnSecurity
        '
        Me.btnSecurity.Location = New System.Drawing.Point(249, 21)
        Me.btnSecurity.Name = "btnSecurity"
        Me.btnSecurity.Size = New System.Drawing.Size(36, 30)
        Me.btnSecurity.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(93, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 23)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Reports"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(93, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Payroll"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(93, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Employee's Profile"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Company Profile"
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(42, 135)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(36, 30)
        Me.btnReports.TabIndex = 3
        '
        'btnPayroll
        '
        Me.btnPayroll.Location = New System.Drawing.Point(42, 99)
        Me.btnPayroll.Name = "btnPayroll"
        Me.btnPayroll.Size = New System.Drawing.Size(36, 30)
        Me.btnPayroll.TabIndex = 2
        '
        'btnEmployees
        '
        Me.btnEmployees.Location = New System.Drawing.Point(42, 60)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(36, 30)
        Me.btnEmployees.TabIndex = 1
        '
        'btnCompProfile
        '
        Me.btnCompProfile.Location = New System.Drawing.Point(42, 21)
        Me.btnCompProfile.Name = "btnCompProfile"
        Me.btnCompProfile.Size = New System.Drawing.Size(36, 30)
        Me.btnCompProfile.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(471, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Negros Saturn Marketing"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(477, 36)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(462, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payroll System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel4.Controls.Add(Me.btnAbout)
        Me.Panel4.Controls.Add(Me.btnQuit)
        Me.Panel4.Location = New System.Drawing.Point(6, 285)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(489, 36)
        Me.Panel4.TabIndex = 3
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Location = New System.Drawing.Point(13, 5)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(81, 27)
        Me.btnAbout.TabIndex = 4
        Me.btnAbout.Text = "About"
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.Location = New System.Drawing.Point(394, 5)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(81, 27)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "QUIT"
        '
        'Menu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(501, 330)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Menu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case CompDB
            Case "NSM"
                Label2.Text = "Negros Saturn Marketing"
            Case "PPE"
                Label2.Text = "Paperworld Printing Enterprises"
            Case "S&W"
                Label2.Text = "S && W's Marketing"
            Case "SDOM"
                Label2.Text = "SKT Digitel Office Marketing"
            Case "SSN"
                Label2.Text = "SKT Saturn Network, Inc."
        End Select
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnCompProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompProfile.Click
        Dim Company As New Company
        Company.Show()
    End Sub

    Private Sub btnEmployees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployees.Click
        Dim Employees As New Employees
        Employees.Show()
    End Sub

    Private Sub btnPayroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayroll.Click
        Dim Payroll As New Payroll
        Payroll.Show()
    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        Dim ReportDialog As New ReportDialog
        ReportDialog.Show()
    End Sub

    Private Sub btnSecurity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSecurity.Click
        Dim Password As New Password
        Password.Show()
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        Dim About As New About
        About.ShowDialog()
    End Sub

    Private Sub Menu_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        dbSelect.StartUp.Show()
    End Sub
End Class
