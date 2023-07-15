Public Class dbSelect
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
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSSN As System.Windows.Forms.Button
    Friend WithEvents btnSDOM As System.Windows.Forms.Button
    Friend WithEvents btnSW As System.Windows.Forms.Button
    Friend WithEvents btnPPE As System.Windows.Forms.Button
    Friend WithEvents btnNSM As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSSN = New System.Windows.Forms.Button
        Me.btnSDOM = New System.Windows.Forms.Button
        Me.btnSW = New System.Windows.Forms.Button
        Me.btnPPE = New System.Windows.Forms.Button
        Me.btnNSM = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Location = New System.Drawing.Point(6, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(375, 261)
        Me.Panel3.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnSSN)
        Me.Panel1.Controls.Add(Me.btnSDOM)
        Me.Panel1.Controls.Add(Me.btnSW)
        Me.Panel1.Controls.Add(Me.btnPPE)
        Me.Panel1.Controls.Add(Me.btnNSM)
        Me.Panel1.Location = New System.Drawing.Point(21, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(335, 192)
        Me.Panel1.TabIndex = 11
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(81, 159)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(189, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit Payroll System"
        '
        'btnSSN
        '
        Me.btnSSN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSSN.Location = New System.Drawing.Point(81, 123)
        Me.btnSSN.Name = "btnSSN"
        Me.btnSSN.Size = New System.Drawing.Size(189, 23)
        Me.btnSSN.TabIndex = 4
        Me.btnSSN.Text = "SSN, Inc"
        '
        'btnSDOM
        '
        Me.btnSDOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSDOM.Location = New System.Drawing.Point(81, 96)
        Me.btnSDOM.Name = "btnSDOM"
        Me.btnSDOM.Size = New System.Drawing.Size(189, 23)
        Me.btnSDOM.TabIndex = 3
        Me.btnSDOM.Text = "SDO Marketing"
        '
        'btnSW
        '
        Me.btnSW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSW.Location = New System.Drawing.Point(81, 69)
        Me.btnSW.Name = "btnSW"
        Me.btnSW.Size = New System.Drawing.Size(189, 23)
        Me.btnSW.TabIndex = 2
        Me.btnSW.Text = "S && W Marketing"
        '
        'btnPPE
        '
        Me.btnPPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPPE.Location = New System.Drawing.Point(81, 42)
        Me.btnPPE.Name = "btnPPE"
        Me.btnPPE.Size = New System.Drawing.Size(189, 23)
        Me.btnPPE.TabIndex = 1
        Me.btnPPE.Text = "PPE Enterprises"
        '
        'btnNSM
        '
        Me.btnNSM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNSM.Location = New System.Drawing.Point(81, 15)
        Me.btnNSM.Name = "btnNSM"
        Me.btnNSM.Size = New System.Drawing.Size(189, 23)
        Me.btnNSM.TabIndex = 0
        Me.btnNSM.Text = "NSM Marketing"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(18, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(339, 38)
        Me.Panel2.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(4, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(332, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Select Company"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dbSelect
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(387, 279)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dbSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Shared StartUp As dbSelect

    Private Sub btnNSM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNSM.Click
        Dim Login As New Login

        CompDB = "NSM"

        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnPPE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPPE.Click
        Dim Login As New Login

        CompDB = "PPE"

        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnSW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSW.Click
        Dim Login As New Login

        CompDB = "S&W"

        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnSDOM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSDOM.Click
        Dim Login As New Login

        CompDB = "SDOM"

        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnSSN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSSN.Click
        Dim Login As New Login

        CompDB = "SSN"

        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub dbSelect_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbSelect.StartUp = Me
    End Sub
End Class
