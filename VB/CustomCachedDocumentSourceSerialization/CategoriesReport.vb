Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraReports.UI

Namespace CustomCachedDocumentSourceSerialization
	Partial Public Class CategoriesReport
		Inherits DevExpress.XtraReports.UI.XtraReport

		Private pageAdditionalData As New Dictionary(Of Integer, List(Of Integer))()

		Public Sub New()
			InitializeComponent()
			AddHandler PrintingSystem.XlSheetCreated, AddressOf PrintingSystem_XlSheetCreated
			Me.PrintingSystem.AddService(GetType(CustomPageDataService), New CustomPageDataService(pageAdditionalData))
		End Sub

		Private Sub PrintingSystem_XlSheetCreated(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.XlSheetCreatedEventArgs)
			Dim serviceProvider = TryCast(PrintingSystem, IServiceProvider)
			Dim customPageDataService As CustomPageDataService = Nothing
			customPageDataService = TryCast(serviceProvider.GetService(GetType(CustomPageDataService)), CustomPageDataService)
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: if (serviceProvider != null && (customPageDataService = TryCast(serviceProvider.GetService(typeof(CustomPageDataService)), CustomPageDataService)) != null)
			If serviceProvider IsNot Nothing AndAlso customPageDataService IsNot Nothing Then
				customPageDataService.PrintingSystem_XlSheetCreated(sender, e)
			End If
		End Sub

		Private Sub CategoryId_PrintOnPage(ByVal sender As Object, ByVal e As PrintOnPageEventArgs) Handles xrTableCell2.PrintOnPage
			Dim cell = TryCast(sender, XRTableCell)
			Dim categoryNumber As Integer = Nothing
			If cell IsNot Nothing AndAlso Integer.TryParse(cell.Text, categoryNumber) Then
				If Not pageAdditionalData.ContainsKey(e.PageIndex) Then
					pageAdditionalData(e.PageIndex) = New List(Of Integer)()
				End If
				pageAdditionalData(e.PageIndex).Add(categoryNumber)
			End If
		End Sub
	End Class
End Namespace
