Module gModule
    Public CompDB As String

    Public Function cnSettings() As String
        Return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data\" & CompDB & "\Payroll.mdb;Jet OLEDB:Database Password=jaypee"
    End Function

    Public Function IsValidTextbox(ByVal TxtBox As TextBox) As Boolean
        If IsNumeric(TxtBox.Text) Then
            TxtBox.Text = Format(CDbl(TxtBox.Text), "0.00")
            IsValidTextbox = True
        Else
            MsgBox("Please enter correct information", MsgBoxStyle.OKOnly)
            TxtBox.Focus()
            TxtBox.SelectAll()
            IsValidTextbox = False
        End If
    End Function
End Module
