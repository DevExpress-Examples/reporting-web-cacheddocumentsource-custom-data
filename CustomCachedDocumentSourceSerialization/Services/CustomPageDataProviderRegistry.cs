using System.Collections.Concurrent;

namespace CustomCachedDocumentSourceSerialization.Services {
    public class CustomPageDataProviderRegistry {
        readonly ConcurrentDictionary<string, string> reportIdByDocumentIdDictionary = new();
        readonly ConcurrentDictionary<string, ConcurrentStack<string>> documentsByReportIdDictionary = new();
        readonly ConcurrentDictionary<string, CustomPageDataService> customPageDataProviders = new();

        public void BindDocumentIdWithReportId(string reportId, string documentId) {
            reportIdByDocumentIdDictionary.AddOrUpdate(documentId, reportId, (_1, _2) => reportId);
            var documentsStack = documentsByReportIdDictionary.GetOrAdd(reportId, (reportId) => new ConcurrentStack<string>());
            documentsStack.Push(documentId);
        }

        public void ReleaseReportInfo(string reportId) {
            customPageDataProviders.TryRemove(reportId, out var _dataProvider);
            if(documentsByReportIdDictionary.TryRemove(reportId, out ConcurrentStack<string> documents)) {
                while(documents.TryPop(out var documentId)) {
                    reportIdByDocumentIdDictionary.TryRemove(documentId, out string _ignore);
                }
            }
        }

        public void SetPageDataService(string reportId, CustomPageDataService customPageDataService) {
            customPageDataProviders.AddOrUpdate(reportId, customPageDataService, (_id, _existingService) => customPageDataService);
        }

        public bool TryGetPageDataService(string documentId, out CustomPageDataService customPageDataService) {
            customPageDataService = null;
            return reportIdByDocumentIdDictionary.TryGetValue(documentId, out string reportId) && customPageDataProviders.TryGetValue(reportId, out customPageDataService);
        }
    }
}
