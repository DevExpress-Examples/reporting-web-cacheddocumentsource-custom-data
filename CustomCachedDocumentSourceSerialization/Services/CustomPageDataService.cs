using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CustomCachedDocumentSourceSerialization.Services {
    [DataContract]
    public class CustomPageData {
        [DataMember]
        public int CategoryMin { get; set; }
        [DataMember]
        public int CategoryMax { get; set; }
    }
    public class CustomPageDataService {
        public const string Key = "customPageData";
        public Dictionary<int, CustomPageData> PageAdditionalData { get; private set; }
        public Dictionary<int, string> SheetNames { get; private set; }
        public CustomPageDataService(Dictionary<int, CustomPageData> pageAdditionalData) {
            if (pageAdditionalData == null)
                throw new ArgumentNullException("pageAdditionalData");
            PageAdditionalData = pageAdditionalData;
        }

        public void PrintingSystem_XlSheetCreated(object sender, DevExpress.XtraPrinting.XlSheetCreatedEventArgs e) {
            if (PageAdditionalData.ContainsKey(e.Index)) {
                CustomPageData pageData = PageAdditionalData[e.Index];
                e.SheetName = $"Categories_{pageData.CategoryMin}-{pageData.CategoryMax}";
            }
        }
    }
}
