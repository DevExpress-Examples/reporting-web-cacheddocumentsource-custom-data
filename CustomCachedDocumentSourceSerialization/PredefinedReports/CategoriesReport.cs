using System;
using System.Collections.Generic;
using CustomCachedDocumentSourceSerialization.Services;
using DevExpress.XtraReports.UI;

namespace CustomCachedDocumentSourceSerialization.PredefinedReports {
    public partial class CategoriesReport : DevExpress.XtraReports.UI.XtraReport {
        readonly Dictionary<int, CustomPageData> pageAdditionalData = new Dictionary<int, CustomPageData>();
        readonly CustomPageDataService customPageDataService;

        public CategoriesReport() {
            InitializeComponent();
            this.customPageDataService = new CustomPageDataService(pageAdditionalData);
            this.PrintingSystem.XlSheetCreated += customPageDataService.PrintingSystem_XlSheetCreated;
            this.PrintingSystem.AddService(typeof(CustomPageDataService), customPageDataService);
        }

        private void CategoryId_PrintOnPage(object sender, PrintOnPageEventArgs e) {
            var cell = sender as XRTableCell;
            int categoryNumber;
            if(cell != null && int.TryParse(cell.Text, out categoryNumber)) {
                if(!pageAdditionalData.ContainsKey(e.PageIndex)) {
                    pageAdditionalData[e.PageIndex] = new CustomPageData {
                        CategoryMax = -1,
                        CategoryMin = -1
                    };
                }
                var pageData = pageAdditionalData[e.PageIndex];
                pageData.CategoryMin = pageData.CategoryMin == -1 ? categoryNumber : Math.Min(categoryNumber, pageData.CategoryMin);
                pageData.CategoryMax = Math.Max(categoryNumber, pageData.CategoryMax);
            }
        }
    }
}
