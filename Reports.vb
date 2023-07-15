Option Explicit On 

Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine

Public Class Reports
    Inherits System.Windows.Forms.Form

    Dim ACCESS_CONNECTION_STRING As String = cnSettings()
    Dim strCompName As String
    Dim strAddress As String

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
    Friend WithEvents rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.crViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.rptDoc = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.SuspendLayout()
        '
        'crViewer
        '
        Me.crViewer.ActiveViewIndex = -1
        Me.crViewer.DisplayGroupTree = False
        Me.crViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crViewer.Location = New System.Drawing.Point(0, 0)
        Me.crViewer.Name = "crViewer"
        Me.crViewer.ReportSource = Nothing
        Me.crViewer.ShowGroupTreeButton = False
        Me.crViewer.Size = New System.Drawing.Size(968, 598)
        Me.crViewer.TabIndex = 0
        '
        'rptDoc
        '
        Me.rptDoc.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation
        Me.rptDoc.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
        Me.rptDoc.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Upper
        Me.rptDoc.PrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
        '
        'Reports
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(968, 598)
        Me.Controls.Add(Me.crViewer)
        Me.Name = "Reports"
        Me.Text = "Reports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal frmDialog As ReportDialog, ByVal strReport As String)
        Me.New()

        GetCompName()

        Dim rptReports As New ReportDocument

        Dim pvCollection As New CrystalDecisions.Shared.ParameterValues
        Dim pdvCompName As New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim pdvCompAdd As New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim pdvFromPay As New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim pdvToPay As New CrystalDecisions.Shared.ParameterDiscreteValue

        Dim tbCurrent As CrystalDecisions.CrystalReports.Engine.Table
        Dim tliCurrent As CrystalDecisions.Shared.TableLogOnInfo

        rptReports.Load("Reports\" & strReport)

        'rptReports.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperFolio

        For Each tbCurrent In rptReports.Database.Tables
            tliCurrent = tbCurrent.LogOnInfo
            With tliCurrent.ConnectionInfo
                .ServerName = Application.StartupPath & "\Data\" & CompDB & "\Payroll.mdb"
                .UserID = ""
                .Password = "jaypee"
                .DatabaseName = ""
            End With
            tbCurrent.ApplyLogOnInfo(tliCurrent)
        Next tbCurrent

        pdvCompName.Value = strCompName
        pdvCompAdd.Value = strAddress
        pdvFromPay.Value = frmDialog.FromPay.Text
        pdvToPay.Value = frmDialog.ToPay.Text

        pvCollection.Add(pdvCompName)
        rptReports.DataDefinition.ParameterFields("CompName").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        pvCollection.Add(pdvCompAdd)
        rptReports.DataDefinition.ParameterFields("CompAdd").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        pvCollection.Add(pdvFromPay)
        rptReports.DataDefinition.ParameterFields("FromPay").ApplyCurrentValues(pvCollection)

        pvCollection.Clear()
        pvCollection.Add(pdvToPay)
        rptReports.DataDefinition.ParameterFields("ToPay").ApplyCurrentValues(pvCollection)

        rptReports.RecordSelectionFormula = "{Payroll.FromPay} = #" & Format(frmDialog.FromPay.Text, "short date") & "# AND {Payroll.ToPay} = #" & Format(frmDialog.ToPay.Text, "Short Date") & "#"

        crViewer.ReportSource = rptReports
    End Sub

    Private Sub GetCompName()
        Dim Connection As New OleDbConnection(ACCESS_CONNECTION_STRING)

        Dim cmdfill As New OleDbCommand("SELECT CompName, CompAdd FROM Company", Connection)

        Try
            Connection.Open()

            Dim datareader As OleDbDataReader

            datareader = cmdfill.ExecuteReader

            datareader.Read()
            strCompName = CStr(datareader("CompName"))
            strAddress = CStr(datareader("CompAdd"))

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Connection.Close()
        End Try
    End Sub
End Class
