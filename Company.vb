Public Class Company
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
    Friend WithEvents cnPayroll As System.Data.OleDb.OleDbConnection
    Friend WithEvents daCompany As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DsPayroll As Payroll_System.dsPayroll
    Friend WithEvents txtCompInit As System.Windows.Forms.TextBox
    Friend WithEvents lblCompInit As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CompName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Address As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TelNo As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cnPayroll = New System.Data.OleDb.OleDbConnection
        Me.daCompany = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.DsPayroll = New Payroll_System.dsPayroll
        Me.txtCompInit = New System.Windows.Forms.TextBox
        Me.lblCompInit = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CompName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Address = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TelNo = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        CType(Me.DsPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'daCompany
        '
        Me.daCompany.DeleteCommand = Me.OleDbDeleteCommand1
        Me.daCompany.InsertCommand = Me.OleDbInsertCommand1
        Me.daCompany.SelectCommand = Me.OleDbSelectCommand1
        Me.daCompany.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Company", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CompAdd", "CompAdd"), New System.Data.Common.DataColumnMapping("CompanyID", "CompanyID"), New System.Data.Common.DataColumnMapping("CompInit", "CompInit"), New System.Data.Common.DataColumnMapping("CompName", "CompName"), New System.Data.Common.DataColumnMapping("CompTel", "CompTel")})})
        Me.daCompany.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Company WHERE (CompanyID = ?) AND (CompAdd = ? OR ? IS NULL AND CompA" & _
        "dd IS NULL) AND (CompInit = ? OR ? IS NULL AND CompInit IS NULL) AND (CompName =" & _
        " ? OR ? IS NULL AND CompName IS NULL) AND (CompTel = ? OR ? IS NULL AND CompTel " & _
        "IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.cnPayroll
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompanyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompanyID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompAdd", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompAdd", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompAdd1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompAdd", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompInit", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompInit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompInit1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompInit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompTel", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompTel", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompTel1", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompTel", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Company(CompAdd, CompInit, CompName, CompTel) VALUES (?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.cnPayroll
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CompAdd", System.Data.OleDb.OleDbType.VarWChar, 60, "CompAdd"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CompInit", System.Data.OleDb.OleDbType.VarWChar, 5, "CompInit"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CompName", System.Data.OleDb.OleDbType.VarWChar, 50, "CompName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CompTel", System.Data.OleDb.OleDbType.VarWChar, 12, "CompTel"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT CompAdd, CompanyID, CompInit, CompName, CompTel FROM Company"
        Me.OleDbSelectCommand1.Connection = Me.cnPayroll
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Company SET CompAdd = ?, CompInit = ?, CompName = ?, CompTel = ? WHERE (Co" & _
        "mpanyID = ?) AND (CompAdd = ? OR ? IS NULL AND CompAdd IS NULL) AND (CompInit = " & _
        "? OR ? IS NULL AND CompInit IS NULL) AND (CompName = ? OR ? IS NULL AND CompName" & _
        " IS NULL) AND (CompTel = ? OR ? IS NULL AND CompTel IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.cnPayroll
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CompAdd", System.Data.OleDb.OleDbType.VarWChar, 60, "CompAdd"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CompInit", System.Data.OleDb.OleDbType.VarWChar, 5, "CompInit"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CompName", System.Data.OleDb.OleDbType.VarWChar, 50, "CompName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CompTel", System.Data.OleDb.OleDbType.VarWChar, 12, "CompTel"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompanyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompanyID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompAdd", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompAdd", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompAdd1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompAdd", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompInit", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompInit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompInit1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompInit", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompTel", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompTel", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CompTel1", System.Data.OleDb.OleDbType.VarWChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompTel", System.Data.DataRowVersion.Original, Nothing))
        '
        'DsPayroll
        '
        Me.DsPayroll.DataSetName = "dsPayroll"
        Me.DsPayroll.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'txtCompInit
        '
        Me.txtCompInit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Company.CompInit"))
        Me.txtCompInit.Location = New System.Drawing.Point(111, 60)
        Me.txtCompInit.Name = "txtCompInit"
        Me.txtCompInit.Size = New System.Drawing.Size(72, 20)
        Me.txtCompInit.TabIndex = 0
        Me.txtCompInit.Text = ""
        '
        'lblCompInit
        '
        Me.lblCompInit.Location = New System.Drawing.Point(12, 60)
        Me.lblCompInit.Name = "lblCompInit"
        Me.lblCompInit.Size = New System.Drawing.Size(93, 18)
        Me.lblCompInit.TabIndex = 1
        Me.lblCompInit.Text = "Company Initial:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Company Name:"
        '
        'CompName
        '
        Me.CompName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Company.CompName"))
        Me.CompName.Location = New System.Drawing.Point(111, 84)
        Me.CompName.Name = "CompName"
        Me.CompName.Size = New System.Drawing.Size(255, 20)
        Me.CompName.TabIndex = 2
        Me.CompName.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Address:"
        '
        'Address
        '
        Me.Address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Company.CompAdd"))
        Me.Address.Location = New System.Drawing.Point(111, 108)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(255, 20)
        Me.Address.TabIndex = 4
        Me.Address.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tel. No.:"
        '
        'TelNo
        '
        Me.TelNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Company.CompTel"))
        Me.TelNo.Location = New System.Drawing.Point(111, 132)
        Me.TelNo.Name = "TelNo"
        Me.TelNo.Size = New System.Drawing.Size(99, 20)
        Me.TelNo.TabIndex = 6
        Me.TelNo.Text = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(9, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 38)
        Me.Panel1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(4, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(348, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Company Information"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(105, 168)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "&Save"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(198, 168)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(369, 201)
        Me.Panel2.TabIndex = 11
        '
        'Company
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(378, 207)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TelNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CompName)
        Me.Controls.Add(Me.lblCompInit)
        Me.Controls.Add(Me.txtCompInit)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Company"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DsPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
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

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Company_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnPayroll.ConnectionString = cnSettings()

        daCompany.Fill(DsPayroll)

        Me.BindingContext(DsPayroll, "Company").Position = 0
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.BindingContext(DsPayroll, "Company").EndCurrentEdit()
        daCompany.Update(DsPayroll)
    End Sub

End Class
