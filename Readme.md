# How to store and use custom document data in the Web Document Viewer

This example demonstrates how to serialize your custom data along with other document information and use this data after the document is deserialized.
Override <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.WebDocumentViewerOperationLogger._methods">WebDocumentViewerOperationLogger‘s</a> CachedDocumentSourceSerializing and CachedDocumentSourceDeserialized methods and use the documentDetails parameter’s CustomData property to pass and get custom document data.
Note that starting with v18.1, the Web Document Viewer uses CachedDocumentSource to process document requests such as page render, export and print operations.