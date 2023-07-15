Public Class Division
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
    Friend WithEvents daDivision As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents cnPayroll As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDivision As System.Windows.Forms.TextBox
    Friend WithEvents DsPayroll As Payroll_System.dsPayroll
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.daDivision = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.cnPayroll = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDivision = New System.Windows.Forms.TextBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.DsPayroll = New Payroll_System.dsPayroll
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DsPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'cnPayroll
        '
        Me.cnPayroll.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""E:\Project\Payroll Syste" & _
        "m\bin\Data\NSM\Payroll.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global B" & _
        "ulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=" & _
        ";Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Dat" & _
        "abase Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Loca" & _
        "le on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin" & _
        ";Jet OLEDB:Encrypt Database=False"
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
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtDivision)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(318, 159)
        Me.Panel2.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 18)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Division Name:"
        '
        'txtDivision
        '
        Me.txtDivision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPayroll, "Division.Division"))
        Me.txtDivision.Location = New System.Drawing.Point(108, 66)
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.Size = New System.Drawing.Size(198, 20)
        Me.txtDivision.TabIndex = 25
        Me.txtDivision.Text = ""
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(167, 114)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 33
        Me.btnExit.Text = "&Cancel"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(74, 114)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 32
        Me.btnSave.Text = "&Save"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(306, 38)
        Me.Panel1.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(4, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(269, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Division"
        '
        'DsPayroll
        '
        Me.DsPayroll.DataSetName = "dsPayroll"
        Me.DsPayroll.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Division
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(330, 171)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Division"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Division"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Division_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnPayroll.ConnectionString = cnSettings()

        Me.BindingContext(DsPayroll, "Division").AddNew()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Me.BindingContext(DsPayroll, "Division").EndCurrentEdit()

            daDivision.Update(DsPayroll)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
