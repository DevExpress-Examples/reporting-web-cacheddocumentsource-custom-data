using System;
using System.Collections.Generic;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Caching;
using DevExpress.XtraReports.Web.WebDocumentViewer;

namespace CustomCachedDocumentSourceSerialization {
    public class CustomWebDocumentViewerOperationLogger: WebDocumentViewerOperationLogger {
        public override void CachedDocumentSourceSerializing(string documentId, CachedDocumentSource cachedDocumentSource, GeneratedDocumentDetails documentDetails, DocumentStorage documentStorage, PrintingSystemBase printingSystemSource) {
            var serviceProvider = printingSystemSource as IServiceProvider;
            var customPageDataService = serviceProvider.GetService(typeof(CustomPageDataService)) as CustomPageDataService;
            if (customPageDataService != null) {
                documentDetails.CustomData = new Dictionary<string, object> { [CustomPageDataService.Key] = customPageDataService.PageAdditionalData };
                cachedDocumentSource.PrintingSystem.XlSheetCreated += customPageDataService.PrintingSystem_XlSheetCreated;
            }
        }

        public override void CachedDocumentSourceDeserialized(string documentId, CachedDocumentSource cachedDocumentSource, GeneratedDocumentDetails documentDetails, DocumentStorage documentStorage) {
            object customData;
            if(documentDetails.CustomData != null && documentDetails.CustomData.TryGetValue(CustomPageDataService.Key, out customData)){
                Dictionary<int, List<int>> customDataServiceDictionary = customData as Dictionary<int, List<int>>;
                if (customDataServiceDictionary == null)
                    return;
                var customPageDataService = new CustomPageDataService(customDataServiceDictionary);
                cachedDocumentSource.PrintingSystem.XlSheetCreated += customPageDataService.PrintingSystem_XlSheetCreated;
            }
        }
    }
}