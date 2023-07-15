Public Class ReportDialog
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ToPay As System.Windows.Forms.DateTimePicker
    Friend WithEvents FromPay As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optVoucher As System.Windows.Forms.RadioButton
    Friend WithEvents optPayrollSum As System.Windows.Forms.RadioButton
    Friend WithEvents optListofEmp As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.optListofEmp = New System.Windows.Forms.RadioButton
        Me.optPayrollSum = New System.Windows.Forms.RadioButton
        Me.optVoucher = New System.Windows.Forms.RadioButton
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnPreview = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToPay = New System.Windows.Forms.DateTimePicker
        Me.FromPay = New System.Windows.Forms.DateTimePicker
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnPreview)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 213)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optListofEmp)
        Me.GroupBox2.Controls.Add(Me.optPayrollSum)
        Me.GroupBox2.Controls.Add(Me.optVoucher)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(153, 102)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Report"
        '
        'optListofEmp
        '
        Me.optListofEmp.Location = New System.Drawing.Point(12, 72)
        Me.optListofEmp.Name = "optListofEmp"
        Me.optListofEmp.Size = New System.Drawing.Size(129, 24)
        Me.optListofEmp.TabIndex = 2
        Me.optListofEmp.Text = "List of Employees"
        '
        'optPayrollSum
        '
        Me.optPayrollSum.Location = New System.Drawing.Point(12, 45)
        Me.optPayrollSum.Name = "optPayrollSum"
        Me.optPayrollSum.Size = New System.Drawing.Size(129, 24)
        Me.optPayrollSum.TabIndex = 1
        Me.optPayrollSum.Text = "&Payroll Summary"
        '
        'optVoucher
        '
        Me.optVoucher.Checked = True
        Me.optVoucher.Location = New System.Drawing.Point(12, 21)
        Me.optVoucher.Name = "optVoucher"
        Me.optVoucher.Size = New System.Drawing.Size(129, 24)
        Me.optVoucher.TabIndex = 0
        Me.optVoucher.TabStop = True
        Me.optVoucher.Text = "&Voucher"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(212, 174)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(92, 174)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.TabIndex = 10
        Me.btnPreview.Text = "Preview"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ToPay)
        Me.GroupBox1.Controls.Add(Me.FromPay)
        Me.GroupBox1.Location = New System.Drawing.Point(177, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 102)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Period Covered"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From:"
        '
        'ToPay
        '
        Me.ToPay.CustomFormat = "MMMM, dd, yyyy"
        Me.ToPay.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.ToPay.Location = New System.Drawing.Point(48, 66)
        Me.ToPay.Name = "ToPay"
        Me.ToPay.Size = New System.Drawing.Size(128, 20)
        Me.ToPay.TabIndex = 1
        '
        'FromPay
        '
        Me.FromPay.CustomFormat = "MMMM, dd, yyyy"
        Me.FromPay.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.FromPay.Location = New System.Drawing.Point(48, 33)
        Me.FromPay.Name = "FromPay"
        Me.FromPay.Size = New System.Drawing.Size(128, 20)
        Me.FromPay.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(369, 38)
        Me.Panel2.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(4, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(348, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Report Options"
        '
        'ReportDialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(390, 219)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReportDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportDialog"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim frmReport As Reports

        If optVoucher.Checked = True Then
            frmReport = New Reports(Me, "Voucher.rpt")
            frmReport.Show()
        ElseIf optPayrollSum.Checked = True Then
            frmReport = New Reports(Me, "PayrollSum.rpt")
            frmReport.Show()
        Else
            Dim frmListofEmpReport As ListofEmpReport
            frmListofEmpReport = New ListofEmpReport(Me, "EmployeesList.rpt")
            frmListofEmpReport.Show()
        End If
    End Sub

    Private Sub optVoucher_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optVoucher.CheckedChanged
        If optVoucher.Checked = True Then
            GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub optPayrollSum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPayrollSum.CheckedChanged
        If optPayrollSum.Checked = True Then
            GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub optListofEmp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optListofEmp.CheckedChanged
        If optListofEmp.Checked = True Then
            GroupBox1.Enabled = False
        End If
    End Sub

End Class
