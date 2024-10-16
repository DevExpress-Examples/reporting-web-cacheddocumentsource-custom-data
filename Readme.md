<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/150279301/23.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830513)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for ASP.NET Core - How to Manage Events of a Cached Document and Pass Custom Data to the Exported Document

This example creates and registers a descendant of our [WebDocumentViewerOperationLogger](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.WebDocumentViewerOperationLogger) class to attach the [XlSheetCreated](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase.XlSheetCreated) event handler to the document.

This example also illustrates the technique used to restore event handlers after a document is serialized in the cache and all event handlers are detached.

Run the application and select **Export to XLSX**:

![Export to XLSX](Images/export-screenshot.png)

The product category is used to rename worksheets in the exported XLSX file. The category is displayed in the report on the page from which the worksheet originated.

![Exported XLS file with Renamed Worksheets](Images/result-screenshot.png)

## Files to Review

* [CustomWebDocumentViewerOperationLogger.cs](CustomCachedDocumentSourceSerialization/Services/CustomWebDocumentViewerOperationLogger.cs)

## Documentation

* [Web Document Viewer Cache Management](https://docs.devexpress.com/XtraReports/404234/web-reporting/general-information-on-web-reporting/document-viewer-caching)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-cacheddocumentsource-custom-data&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-web-cacheddocumentsource-custom-data&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
