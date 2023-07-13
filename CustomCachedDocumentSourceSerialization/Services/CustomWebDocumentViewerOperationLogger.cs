using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Caching;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.WebDocumentViewer;

namespace CustomCachedDocumentSourceSerialization.Services {
    public class CustomWebDocumentViewerOperationLogger : WebDocumentViewerOperationLogger {
        readonly CustomPageDataProviderRegistry customPageDataProviderRegistry;

        public CustomWebDocumentViewerOperationLogger(CustomPageDataProviderRegistry customPageDataProviderRegistry) {
            this.customPageDataProviderRegistry = customPageDataProviderRegistry;
        }

        public override void ReportOpening(string reportId, string documentId, XtraReport report) {
            var serviceProvider = report.PrintingSystem as IServiceProvider;
            var customPageDataService = serviceProvider.GetService(typeof(CustomPageDataService)) as CustomPageDataService;
            if(customPageDataService != null) {
                customPageDataProviderRegistry.SetPageDataService(reportId, customPageDataService);
            }
        }

        public override void BuildStarted(string reportId, string documentId, ReportBuildProperties buildProperties) {
            customPageDataProviderRegistry.BindDocumentIdWithReportId(reportId, documentId);
        }

        public override void CachedDocumentSourceSerializing(string documentId, CachedDocumentSource cachedDocumentSource, GeneratedDocumentDetails documentDetails, DocumentStorage documentStorage, PrintingSystemBase printingSystemSource) {
            if(customPageDataProviderRegistry.TryGetPageDataService(documentId, out CustomPageDataService customPageDataService) && customPageDataService != null) {
                documentDetails.CustomData = new Dictionary<string, object> { [CustomPageDataService.Key] = customPageDataService.PageAdditionalData };
                cachedDocumentSource.PrintingSystem.XlSheetCreated += customPageDataService.PrintingSystem_XlSheetCreated;
            }
        }

        public override void CachedDocumentSourceDeserialized(string documentId, CachedDocumentSource cachedDocumentSource, GeneratedDocumentDetails documentDetails, DocumentStorage documentStorage) {
            if(documentDetails.CustomData != null && documentDetails.CustomData.TryGetValue(CustomPageDataService.Key, out object customData)) {
                var customDataServiceDictionary = ((object[])customData).Cast<KeyValuePair<int, CustomPageData>>().ToDictionary(x => x.Key, x => x.Value);
                if(customDataServiceDictionary == null)
                    return;
                var customPageDataService = new CustomPageDataService(customDataServiceDictionary);
                cachedDocumentSource.PrintingSystem.XlSheetCreated += customPageDataService.PrintingSystem_XlSheetCreated;
            }
        }

        public override void CachedReportReleased(string reportId) {
            ReleaseReport(reportId);
        }
        public override void ReleaseReport(string reportId) {
            customPageDataProviderRegistry.ReleaseReportInfo(reportId);
        }
    }
}
