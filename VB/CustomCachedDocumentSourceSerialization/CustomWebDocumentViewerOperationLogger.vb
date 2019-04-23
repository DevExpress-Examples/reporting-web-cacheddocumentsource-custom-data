Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Caching
Imports DevExpress.XtraReports.Web.WebDocumentViewer

Namespace CustomCachedDocumentSourceSerialization
	Public Class CustomWebDocumentViewerOperationLogger
		Inherits WebDocumentViewerOperationLogger

		Public Overrides Sub CachedDocumentSourceSerializing(ByVal documentId As String, ByVal cachedDocumentSource As CachedDocumentSource, ByVal documentDetails As GeneratedDocumentDetails, ByVal documentStorage As DocumentStorage, ByVal printingSystemSource As PrintingSystemBase)
			Dim serviceProvider = TryCast(printingSystemSource, IServiceProvider)
			Dim customPageDataService = TryCast(serviceProvider.GetService(GetType(CustomPageDataService)), CustomPageDataService)
			If customPageDataService IsNot Nothing Then
				documentDetails.CustomData = New Dictionary(Of String, Object) From {
					{CustomCachedDocumentSourceSerialization.CustomPageDataService.Key, customPageDataService.PageAdditionalData}
				}
				AddHandler cachedDocumentSource.PrintingSystem.XlSheetCreated, AddressOf customPageDataService.PrintingSystem_XlSheetCreated
			End If
		End Sub

		Public Overrides Sub CachedDocumentSourceDeserialized(ByVal documentId As String, ByVal cachedDocumentSource As CachedDocumentSource, ByVal documentDetails As GeneratedDocumentDetails, ByVal documentStorage As DocumentStorage)
			Dim customData As Object = Nothing
			If documentDetails.CustomData IsNot Nothing AndAlso documentDetails.CustomData.TryGetValue(CustomPageDataService.Key, customData) Then
				Dim customDataServiceDictionary As Dictionary(Of Integer, List(Of Integer)) = TryCast(customData, Dictionary(Of Integer, List(Of Integer)))
				If customDataServiceDictionary Is Nothing Then
					Return
				End If
				Dim customPageDataService = New CustomPageDataService(customDataServiceDictionary)
				AddHandler cachedDocumentSource.PrintingSystem.XlSheetCreated, AddressOf customPageDataService.PrintingSystem_XlSheetCreated
			End If
		End Sub
	End Class
End Namespace