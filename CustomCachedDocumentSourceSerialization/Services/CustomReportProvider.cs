using CustomCachedDocumentSourceSerialization.PredefinedReports;
using DevExpress.XtraReports.Services;
using DevExpress.XtraReports.UI;

public class CustomReportProvider : IReportProvider {
        public XtraReport GetReport(string id, ReportProviderContext context) {
            if (string.IsNullOrEmpty(id))
                return null;
            return new CategoriesReport();
        }
    }
