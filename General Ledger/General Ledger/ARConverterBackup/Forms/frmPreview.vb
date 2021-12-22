Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.IO


Imports DataDynamics.ActiveReports.Viewer
Imports DataDynamics.ActiveReports.Document
Public Class frmPreview
    Public rTitle As String
    Private Sub frmPreview_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub
  
    Private Sub arv_HyperLink(ByVal sender As Object, ByVal e As DataDynamics.ActiveReports.Viewer.HyperLinkEventArgs) Handles arv.HyperLink
        Dim strType As String
        Dim strKey As String
        Dim Link As String = e.HyperLink

        Call frmRecoveryReport.CustomerStatementSpecific("No", Link)
        'Dim fTargetForm As Form
    End Sub
  
    Private Sub arv_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles arv.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub arv_LoadCompleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles arv.LoadCompleted
        arv.ReportViewer.Zoom = (-1)
    End Sub

    Private Sub frmPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim _ico As New Icon([GetType]().Module.Assembly.GetManifestResourceStream("DataDynamics.ActiveReports.Samples.CustomPreview.Save16x16.ico"))
        'arv.Toolbar.Images.Images.Add(_ico)
        '_ico = New Icon([GetType]().Module.Assembly.GetManifestResourceStream("DataDynamics.ActiveReports.Samples.CustomPreview.Export16x16.ico"))
        'arv.Toolbar.Images.Images.Add(_ico)


        'Add Save button to the toolbar
        Dim _btn As New DataDynamics.ActiveReports.Toolbar.Button
        _btn.ImageIndex = 14 ' new images were added to Toolbar.Images 
        _btn.ButtonStyle = DataDynamics.ActiveReports.Toolbar.ButtonStyle.Text
        _btn.Caption = "Save"
        _btn.Id = 5001 ' unique identifier for the new tool
        _btn.ToolTip = "Save Report Document"
        arv.Toolbar.Tools.Insert(1, CType(_btn, DataDynamics.ActiveReports.Toolbar.Tool))

        'Add Export button to the toolbar
        _btn = New DataDynamics.ActiveReports.Toolbar.Button
        _btn.ImageIndex = 15
        _btn.Id = 5002
        _btn.ButtonStyle = DataDynamics.ActiveReports.Toolbar.ButtonStyle.Text
        _btn.Caption = "Export"
        _btn.ToolTip = "Export Report Document"
        arv.Toolbar.Tools.Insert(2, CType(_btn, DataDynamics.ActiveReports.Toolbar.Tool))
    End Sub

    Private Sub arv_ToolClick(ByVal sender As Object, ByVal e As DataDynamics.ActiveReports.Toolbar.ToolClickEventArgs) Handles arv.ToolClick
        Try
            Select Case e.Tool.Id
                Case 5001 'Save button
                    Me.SaveDocument()
                Case 5002 'Export button
                    Me.ExportDocument()
            End Select
        Catch exp As System.IO.IOException
            MessageBox.Show(exp.ToString())
        End Try
    End Sub
    Private Sub SaveDocument()
        Dim _dlgSave As New SaveFileDialog
        _dlgSave.Title = "Save Report Document"
        _dlgSave.Filter = "Report Document Files (*.rdf)|*.rdf"
        _dlgSave.DefaultExt = "rdf"
        _dlgSave.AddExtension = True
        If _dlgSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            If File.Exists(_dlgSave.FileName) Then
                If MessageBox.Show(Me, "Overwrite Existing File?", "Overwrite", MessageBoxButtons.YesNo) <> Windows.Forms.DialogResult.Yes Then
                    Return
                End If
            End If
            arv.Document.Save(_dlgSave.FileName)

        End If
    End Sub
    Private Sub ExportDocument()
        Dim _exportForm As New frmExport(arv.Document)
        _exportForm.ShowDialog(Me)
    End Sub

    Private Sub cmdExportPDFPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportPDFPrint.Click
        Dim pdf As New DataDynamics.ActiveReports.Export.Pdf.PdfExport()
        pdf.Export(Me.arv.Document, "d:\myActiveReport.pdf")

        Dim psiPrint As New System.Diagnostics.ProcessStartInfo()
        psiPrint.Verb = "print"
        psiPrint.CreateNoWindow = True
        psiPrint.WindowStyle = ProcessWindowStyle.Hidden
        psiPrint.FileName = "d:\myActiveReport.pdf"
        psiPrint.UseShellExecute = True
        System.Diagnostics.Process.Start(psiPrint)
    End Sub
End Class