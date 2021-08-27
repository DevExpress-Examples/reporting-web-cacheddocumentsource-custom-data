<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/150279301/18.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830513)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to store and use custom document data in the Web Document Viewer

This example demonstrates how to serialize your custom data along with other document information and use this data after the document is deserialized.
Override <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.WebDocumentViewerOperationLogger._methods">WebDocumentViewerOperationLogger�s</a> CachedDocumentSourceSerializing and CachedDocumentSourceDeserialized methods and use the documentDetails parameter�s CustomData property to pass and get custom document data.
Note that starting with v18.1, the Web Document Viewer uses CachedDocumentSource to process document requests such as page render, export and print operations.
