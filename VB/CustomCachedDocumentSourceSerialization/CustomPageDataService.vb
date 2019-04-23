Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace CustomCachedDocumentSourceSerialization
	Public Class CustomPageDataService
		Public Const Key As String = "customPageData"
		Private privatePageAdditionalData As Dictionary(Of Integer, List(Of Integer))
		Public Property PageAdditionalData() As Dictionary(Of Integer, List(Of Integer))
			Get
				Return privatePageAdditionalData
			End Get
			Private Set(ByVal value As Dictionary(Of Integer, List(Of Integer)))
				privatePageAdditionalData = value
			End Set
		End Property
		Private privateSheetNames As Dictionary(Of Integer, String)
		Public Property SheetNames() As Dictionary(Of Integer, String)
			Get
				Return privateSheetNames
			End Get
			Private Set(ByVal value As Dictionary(Of Integer, String))
				privateSheetNames = value
			End Set
		End Property
		Public Sub New(ByVal pageAdditionalData As Dictionary(Of Integer, List(Of Integer)))
			If pageAdditionalData Is Nothing Then
				Throw New ArgumentNullException("pageAdditionalData")
			End If
			Me.PageAdditionalData = pageAdditionalData
		End Sub

		Public Sub PrintingSystem_XlSheetCreated(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.XlSheetCreatedEventArgs)
			If PageAdditionalData.ContainsKey(e.Index) Then
				Dim min As Integer = PageAdditionalData(e.Index).Min()
				Dim max As Integer = PageAdditionalData(e.Index).Max()
				e.SheetName = String.Format("Categories_{0}-{1}", min, max)
			End If
		End Sub
	End Class
End Namespace