Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.Office

Partial Public Class _Default
	Inherits Page
	Private Property FilePath() As String
		Get
			Return If(Session("FilePath") Is Nothing, String.Empty, Session("FilePath").ToString())
		End Get
		Set(ByVal value As String)
			Session("FilePath") = value
		End Set
	End Property
	Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			FilePath = String.Empty
		End If
	End Sub
	Protected Sub Upload_FileUploadComplete(ByVal sender As Object, ByVal e As DevExpress.Web.FileUploadCompleteEventArgs)
        Dim uploadedFilePath As String = Server.MapPath("~/XlsTables/") + e.UploadedFile.FileName
        e.UploadedFile.SaveAs(uploadedFilePath)
        If (Not String.IsNullOrEmpty(FilePath)) Then
            DocumentManager.CloseDocument(FilePath)
        End If
        FilePath = uploadedFilePath
	End Sub
	Protected Sub Spreadsheet_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not String.IsNullOrEmpty(FilePath)) Then
			Spreadsheet.Open(FilePath)
		End If
	End Sub
End Class