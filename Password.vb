Imports System.Data.OleDb

Public Class Password
    Inherits System.Windows.Forms.Form

    Dim ACCESS_CONNECTION_STRING As String = cnSettings()
    Dim strSelectedAssignCode As String
    Dim strOldPassword As String

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
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUserName1 As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName2 As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmPassword2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword2 As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lvUserName As System.Windows.Forms.ListView
    Friend WithEvents grpEdit As System.Windows.Forms.GroupBox
    Friend WithEvents grpAdd As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents btnExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grpAdd = New System.Windows.Forms.GroupBox
        Me.txtUserName1 = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtConfirmPassword1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPassword1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.grpEdit = New System.Windows.Forms.GroupBox
        Me.txtUserName2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtConfirmPassword2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPassword2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtOldPassword = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label22 = New System.Windows.Forms.Label
        Me.lvUserName = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuAdd = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnuDelete = New System.Windows.Forms.MenuItem
        Me.Panel1.SuspendLayout()
        Me.grpAdd.SuspendLayout()
        Me.grpEdit.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.grpAdd)
        Me.Panel1.Controls.Add(Me.grpEdit)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lvUserName)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(420, 237)
        Me.Panel1.TabIndex = 0
        '
        'grpAdd
        '
        Me.grpAdd.Controls.Add(Me.txtUserName1)
        Me.grpAdd.Controls.Add(Me.Label23)
        Me.grpAdd.Controls.Add(Me.txtConfirmPassword1)
        Me.grpAdd.Controls.Add(Me.Label5)
        Me.grpAdd.Controls.Add(Me.txtPassword1)
        Me.grpAdd.Controls.Add(Me.Label6)
        Me.grpAdd.Location = New System.Drawing.Point(183, 48)
        Me.grpAdd.Name = "grpAdd"
        Me.grpAdd.Size = New System.Drawing.Size(228, 108)
        Me.grpAdd.TabIndex = 55
        Me.grpAdd.TabStop = False
        Me.grpAdd.Text = "Add User"
        '
        'txtUserName1
        '
        Me.txtUserName1.Location = New System.Drawing.Point(140, 27)
        Me.txtUserName1.Name = "txtUserName1"
        Me.txtUserName1.Size = New System.Drawing.Size(66, 20)
        Me.txtUserName1.TabIndex = 5
        Me.txtUserName1.Text = ""
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(23, 27)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(111, 21)
        Me.Label23.TabIndex = 32
        Me.Label23.Text = "User name:"
        '
        'txtConfirmPassword1
        '
        Me.txtConfirmPassword1.Location = New System.Drawing.Point(140, 75)
        Me.txtConfirmPassword1.Name = "txtConfirmPassword1"
        Me.txtConfirmPassword1.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword1.Size = New System.Drawing.Size(66, 20)
        Me.txtConfirmPassword1.TabIndex = 7
        Me.txtConfirmPassword1.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(23, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Confirm Password:"
        '
        'txtPassword1
        '
        Me.txtPassword1.Location = New System.Drawing.Point(140, 51)
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword1.Size = New System.Drawing.Size(66, 20)
        Me.txtPassword1.TabIndex = 6
        Me.txtPassword1.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(23, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Password"
        '
        'grpEdit
        '
        Me.grpEdit.Controls.Add(Me.txtUserName2)
        Me.grpEdit.Controls.Add(Me.Label1)
        Me.grpEdit.Controls.Add(Me.txtConfirmPassword2)
        Me.grpEdit.Controls.Add(Me.Label2)
        Me.grpEdit.Controls.Add(Me.txtPassword2)
        Me.grpEdit.Controls.Add(Me.Label3)
        Me.grpEdit.Controls.Add(Me.txtOldPassword)
        Me.grpEdit.Controls.Add(Me.Label4)
        Me.grpEdit.Location = New System.Drawing.Point(183, 48)
        Me.grpEdit.Name = "grpEdit"
        Me.grpEdit.Size = New System.Drawing.Size(228, 135)
        Me.grpEdit.TabIndex = 56
        Me.grpEdit.TabStop = False
        Me.grpEdit.Text = "Edit User"
        Me.grpEdit.Visible = False
        '
        'txtUserName2
        '
        Me.txtUserName2.Enabled = False
        Me.txtUserName2.Location = New System.Drawing.Point(140, 27)
        Me.txtUserName2.Name = "txtUserName2"
        Me.txtUserName2.Size = New System.Drawing.Size(66, 20)
        Me.txtUserName2.TabIndex = 1
        Me.txtUserName2.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 21)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "User name:"
        '
        'txtConfirmPassword2
        '
        Me.txtConfirmPassword2.Location = New System.Drawing.Point(140, 99)
        Me.txtConfirmPassword2.Name = "txtConfirmPassword2"
        Me.txtConfirmPassword2.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword2.Size = New System.Drawing.Size(66, 20)
        Me.txtConfirmPassword2.TabIndex = 4
        Me.txtConfirmPassword2.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Confirm Password:"
        '
        'txtPassword2
        '
        Me.txtPassword2.Location = New System.Drawing.Point(140, 75)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword2.Size = New System.Drawing.Size(66, 20)
        Me.txtPassword2.TabIndex = 3
        Me.txtPassword2.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Password:"
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Location = New System.Drawing.Point(140, 51)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPassword.Size = New System.Drawing.Size(66, 20)
        Me.txtOldPassword.TabIndex = 2
        Me.txtOldPassword.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Old Password:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(315, 198)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "&Cancel"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(210, 198)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "&Save"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(405, 38)
        Me.Panel2.TabIndex = 54
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label22.Location = New System.Drawing.Point(4, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(239, 23)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Password Manager"
        '
        'lvUserName
        '
        Me.lvUserName.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvUserName.FullRowSelect = True
        Me.lvUserName.GridLines = True
        Me.lvUserName.HideSelection = False
        Me.lvUserName.HoverSelection = True
        Me.lvUserName.Location = New System.Drawing.Point(9, 54)
        Me.lvUserName.MultiSelect = False
        Me.lvUserName.Name = "lvUserName"
        Me.lvUserName.Size = New System.Drawing.Size(156, 174)
        Me.lvUserName.TabIndex = 20
        Me.lvUserName.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "User Name"
        Me.ColumnHeader1.Width = 150
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuDelete})
        '
        'mnuAdd
        '
        Me.mnuAdd.Index = 0
        Me.mnuAdd.Text = "Add"
        '
        'mnuEdit
        '
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "Edit"
        '
        'mnuDelete
        '
        Me.mnuDelete.Index = 2
        Me.mnuDelete.Text = "Delete"
        '
        'Password
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 249)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password"
        Me.Panel1.ResumeLayout(False)
        Me.grpAdd.ResumeLayout(False)
        Me.grpEdit.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
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

    Private Sub Password_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateUser()
    End Sub

    Private Sub PopulateUser()
        Dim Connection As New OleDbConnection(ACCESS_CONNECTION_STRING)

        lvUserName.Items.Clear()
        lvUserName.Sorting = SortOrder.Ascending

        Dim cmdfill As New OleDbCommand("SELECT UserName, [Password] FROM [Password]", Connection)

        Try
            Connection.Open()

            Dim datareader As OleDbDataReader

            datareader = cmdfill.ExecuteReader

            While datareader.Read
                Dim lvi As New ListViewItem
                lvi.Text = CStr(datareader("UserName"))
                lvUserName.Items.Add(lvi)
            End While

            If datareader.HasRows Then
                lvUserName.TopItem.Selected = True
                lvUserName.TopItem.Focused = True
                lvUserName.TopItem.EnsureVisible()
                lvUserName.Select()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Connection.Close()
        End Try
    End Sub

    Private Sub RetrieveUser()
        Dim Connection As New OleDbConnection(ACCESS_CONNECTION_STRING)

        Dim cmdfill As New OleDbCommand("SELECT UserName, [Password] FROM [Password] Where UserName = '" & strSelectedAssignCode & "'", Connection)

        Try
            Connection.Open()

            Dim datareader As OleDbDataReader

            datareader = cmdfill.ExecuteReader

            datareader.Read()

            txtUserName2.Text = CStr(datareader("UserName"))
            strOldPassword = CStr(datareader("Password"))

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Connection.Close()
        End Try
    End Sub

    Private Sub AddUser()
        Try
            'Dim dbCommand As OleDbCommand
            Dim DBConn As OleDbConnection
            Dim DBInsert As New OleDbCommand

            DBConn = New OleDbConnection(ACCESS_CONNECTION_STRING)

            DBInsert.CommandText = "INSERT INTO [Password] VALUES (" _
            & "'" & txtUserName1.Text & "', " _
            & "'" & txtPassword1.Text & "')"

            Dim lvi As New ListViewItem
            lvi.Text = txtUserName1.Text
            lvUserName.Items.Add(lvi)

            clearTxtBox()

            DBInsert.Connection = DBConn
            DBInsert.Connection.Open()
            DBInsert.ExecuteNonQuery()
            DBConn.Close()
            DBConn.Dispose()
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "General Error")
        End Try
    End Sub

    Private Sub UpdateUser()
        Try
            'Dim dbCommand As OleDbCommand
            Dim DBConn As OleDbConnection
            Dim DBUpdate As New OleDbCommand

            DBConn = New OleDbConnection(ACCESS_CONNECTION_STRING)

            DBUpdate.CommandText = "UPDATE [Password] SET " & _
                    "[Password] = '" & txtPassword2.Text & "' " & _
                    "WHERE UserName = '" & txtUserName2.Text & "'"

            clearTxtBox()

            DBUpdate.Connection = DBConn
            DBUpdate.Connection.Open()
            DBUpdate.ExecuteNonQuery()

            DBConn.Close()
            DBConn.Dispose()
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "General Error")
        End Try
    End Sub

    Private Sub DeleteUser()
        Try
            Dim DBConn As OleDbConnection
            Dim dbCommand As New OleDbCommand
            'Dim strPath As String

            DBConn = New OleDbConnection(cnSettings())
            dbCommand.CommandText = "DELETE FROM [Password] " _
                                    & "WHERE UserName = '" & strSelectedAssignCode & "'"

            dbCommand.Connection = DBConn
            dbCommand.Connection.Open()
            dbCommand.ExecuteNonQuery()

            lvUserName.Items.Remove(lvUserName.FocusedItem)


            DBConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub clearTxtBox()
        txtUserName1.Text = ""
        txtUserName2.Text = ""
        txtPassword1.Text = ""
        txtPassword2.Text = ""
        txtConfirmPassword1.Text = ""
        txtConfirmPassword2.Text = ""
        txtOldPassword.Text = ""
    End Sub

    Private Sub lvUserName_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvUserName.MouseDown
        Try

            If IsNothing(lvUserName.FocusedItem) Then Exit Sub

            strSelectedAssignCode = lvUserName.FocusedItem.Text

            If e.Button = MouseButtons.Right Then
                If lvUserName.SelectedItems.Count > 0 Then
                    ContextMenu1.Show(lvUserName, New Point(e.X, e.Y))
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly)
        End Try
    End Sub

    Private Sub lvUserName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvUserName.SelectedIndexChanged
        Try
            'If IsNothing(lvUserName.FocusedItem) Then Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly)
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grpEdit.Hide()
        grpAdd.Show()
    End Sub

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        grpAdd.Visible = True
        grpEdit.Visible = False
        btnUpdate.Text = "&Save"
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        grpEdit.Visible = True
        grpAdd.Visible = False
        btnUpdate.Text = "&Update"
        RetrieveUser()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "&Save" Then
            If txtPassword1.Text <> txtConfirmPassword1.Text Then
                MsgBox("Password does not match.", MsgBoxStyle.OKOnly)
                Exit Sub
            End If
            AddUser()
        Else
            If txtOldPassword.Text <> strOldPassword Then
                MsgBox("Please enter the correct password in the Old Password field.", MsgBoxStyle.OKOnly)
                Exit Sub
            End If

            If txtPassword2.Text <> txtConfirmPassword2.Text Then
                MsgBox("Password does not match.", MsgBoxStyle.OKOnly)
                Exit Sub
            End If

            UpdateUser()
        End If
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        If strSelectedAssignCode = "Admin" Then
            MsgBox("Sorry you can't delete this account.", MsgBoxStyle.OKOnly)
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete this user?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then _
            DeleteUser()
    End Sub

End Class
