<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/150279301/18.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830513)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to store and use custom document data in the Web Document Viewer

This example demonstrates how to serialize custom data along with other document information and use that data after deserializing a document. 

Override the [CachedDocumentSourceSerializing](http://docs.devexpress.devx/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.WebDocumentViewerOperationLogger.---Zf----Sy----) and [CachedDocumentSourceDeserialized](http://docs.devexpress.devx/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.WebDocumentViewerOperationLogger.--cK-------9--a-) methods of the  [WebDocumentViewerOperationLogger](http://docs.devexpress.devx/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.WebDocumentViewerOperationLogger) service and use the `CustomData` property of the **documentDetails** parameter to send and receive custom document data. 

Note that starting with v18.1, the Web Document Viewer uses the `CachedDocumentSource` to handle document requests such as rendering, exporting, and printing page operations.
