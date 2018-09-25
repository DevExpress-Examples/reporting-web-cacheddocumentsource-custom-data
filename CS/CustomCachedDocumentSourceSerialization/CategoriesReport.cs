using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;

namespace CustomCachedDocumentSourceSerialization {
    public partial class CategoriesReport : DevExpress.XtraReports.UI.XtraReport {
        Dictionary<int, List<int>> pageAdditionalData = new Dictionary<int, List<int>>();

        public CategoriesReport() {
            InitializeComponent();
            this.PrintingSystem.XlSheetCreated += PrintingSystem_XlSheetCreated;
            this.PrintingSystem.AddService(typeof(CustomPageDataService), new CustomPageDataService(pageAdditionalData));
        }

        void PrintingSystem_XlSheetCreated(object sender, DevExpress.XtraPrinting.XlSheetCreatedEventArgs e) {
            var serviceProvider = PrintingSystem as IServiceProvider;
            CustomPageDataService customPageDataService = null;
            if (serviceProvider != null && (customPageDataService = serviceProvider.GetService(typeof(CustomPageDataService)) as CustomPageDataService) != null) {
                customPageDataService.PrintingSystem_XlSheetCreated(sender, e);
            }
        }

        private void CategoryId_PrintOnPage(object sender, PrintOnPageEventArgs e) {
            var cell = sender as XRTableCell;
            int categoryNumber;
            if (cell != null && int.TryParse(cell.Text, out categoryNumber)) {
                if (!pageAdditionalData.ContainsKey(e.PageIndex)) {
                    pageAdditionalData[e.PageIndex] = new List<int>();
                }
                pageAdditionalData[e.PageIndex].Add(categoryNumber);
            }
        }
    }
}
