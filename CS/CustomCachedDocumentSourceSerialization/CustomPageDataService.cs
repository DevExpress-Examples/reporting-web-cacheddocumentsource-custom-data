using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomCachedDocumentSourceSerialization {
    public class CustomPageDataService {
        public const string Key = "customPageData";
        public Dictionary<int, List<int>> PageAdditionalData { get; private set; }
        public Dictionary<int, string> SheetNames { get; private set; }
        public CustomPageDataService(Dictionary<int, List<int>> pageAdditionalData) {
            if (pageAdditionalData == null)
                throw new ArgumentNullException("pageAdditionalData");
            PageAdditionalData = pageAdditionalData;
        }

        public void PrintingSystem_XlSheetCreated(object sender, DevExpress.XtraPrinting.XlSheetCreatedEventArgs e) {
            if (PageAdditionalData.ContainsKey(e.Index)) {
                int min = PageAdditionalData[e.Index].Min();
                int max = PageAdditionalData[e.Index].Max();
                e.SheetName = string.Format("Categories_{0}-{1}", min, max);
            }
        }
    }
}