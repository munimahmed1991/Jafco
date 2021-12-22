Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.IO
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Export
Imports DataDynamics.ActiveReports.Export.Html
Imports DataDynamics.ActiveReports.Export.Pdf
Imports DataDynamics.ActiveReports.Export.Rtf
Imports DataDynamics.ActiveReports.Export.Text
Imports DataDynamics.ActiveReports.Export.Tiff
Imports DataDynamics.ActiveReports.Export.Xls


Public Class frmExport
    Private doc As Document.Document
    Public Sub New(ByVal doc As Document.Document)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.doc = doc
    End Sub
    Private Sub cboExportFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboExportFormat.SelectedIndexChanged
        txtFilename.Text = ""
        Me.export = Nothing
        PropertyGridExport.SelectedObject = Nothing

        'Change export format type
        Select Case cboExportFormat.SelectedIndex
            Case 0 ' html
                Me.export = New HtmlExport()
            Case 1 ' pdf
                Me.export = New PdfExport()
                PropertyGridExport.SelectedObject = Me.export
            Case 2 ' rtf
                Me.export = New RtfExport()
            Case 3 ' tiff
                Me.export = New TiffExport()
                PropertyGridExport.SelectedObject = Me.export
            Case 4 ' txt
                Me.export = New TextExport()
            Case 5 ' xls
                Me.export = New XlsExport()
                PropertyGridExport.SelectedObject = Me.export
            Case Else
                Me.export = Nothing
        End Select
        'Update PropertyGrid
        PropertyGridExport.SelectedObject = Me.export
    End Sub 'cboExportFormat_SelectedIndexChanged


    Private Sub ExportForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboExportFormat.SelectedIndex = 1 ' Set to pdf export
        Call FormCenter(Me)
    End Sub 'ExportForm_Load


    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub 'btnCancel_Click


    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            If txtFilename.Text.Length = 0 Then
                Return
            End If
            If File.Exists(txtFilename.Text) Then
                If MessageBox.Show(Me, "Overwrite Existing File?", "Overwrite File", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                    Return
                End If
            End If

            'Export report based on export type to selected filename
            Select Case cboExportFormat.SelectedIndex
                Case 0
                    CType(export, HtmlExport).Export(Me.doc, Me.txtFilename.Text)
                Case 1
                    CType(export, PdfExport).Export(Me.doc, Me.txtFilename.Text)
                Case 2
                    CType(export, RtfExport).Export(Me.doc, Me.txtFilename.Text)
                Case 3
                    CType(export, TiffExport).Export(Me.doc, Me.txtFilename.Text)
                Case 4
                    CType(export, TextExport).Export(Me.doc, Me.txtFilename.Text)
                Case 5
                    CType(export, XlsExport).Export(Me.doc, Me.txtFilename.Text)
            End Select
            Me.Close()
        Catch exp As System.IO.IOException
            MessageBox.Show(Me, exp.ToString())
        End Try
        Return
    End Sub 'btnOk_Click


    'btnSaveFile_Click - selects filename to use to save the exported report
    Private Sub btnSaveFile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveFile.Click
        Dim _dlgSaveFile As New SaveFileDialog()
        _dlgSaveFile.Title = "Export Report Document"
        _dlgSaveFile.AddExtension = True

        'Set filters based on export type
        Select Case cboExportFormat.SelectedIndex
            Case 0
                _dlgSaveFile.DefaultExt = "htm"
                _dlgSaveFile.Filter = "HTML Files (*.htm;*.html)|*.htm;*.htm"
            Case 1
                _dlgSaveFile.DefaultExt = "htm"
                _dlgSaveFile.Filter = "PDF Files (*.pdf)|*.pdf"
            Case 2
                _dlgSaveFile.DefaultExt = "rtf"
                _dlgSaveFile.Filter = "Rich Text Files (*.rtf)|*.rtf"
            Case 3
                _dlgSaveFile.DefaultExt = "tif"
                _dlgSaveFile.Filter = "Tiff Image Files (*.tif)|*.tif"
            Case 4
                _dlgSaveFile.DefaultExt = "txt"
                _dlgSaveFile.Filter = "Text Files (*.txt)|*.txt"
            Case 5
                _dlgSaveFile.DefaultExt = "xls"
                _dlgSaveFile.Filter = "Microsoft Excel Files (*.xls)|*.xls"
        End Select
        If _dlgSaveFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtFilename.Text = _dlgSaveFile.FileName
        End If
    End Sub
End Class