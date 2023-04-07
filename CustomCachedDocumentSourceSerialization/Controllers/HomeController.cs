using DevExpress.AspNetCore.Reporting.WebDocumentViewer;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using Microsoft.AspNetCore.Mvc;


namespace CustomCachedDocumentSourceSerialization.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
        public IActionResult Error() {
            Models.ErrorModel model = new Models.ErrorModel();
            return View(model);
        }
        //public async Task<IActionResult> Viewer([FromServices] IWebDocumentViewerClientSideModelGenerator clientSideModelGenerator) {
        //    var model = new Models.ViewerModel {
        //        ViewerModelToBind = await clientSideModelGenerator.GetModelAsync("CategoriesReport", WebDocumentViewerController.DefaultUri)
        //    };
        //    return View(model);
        //}

        public IActionResult Viewer([FromServices] IWebDocumentViewerClientSideModelGenerator clientSideModelGenerator) {
            var model = new Models.ViewerModel {
                ViewerModelToBind = clientSideModelGenerator.GetModel("CategoriesReport", WebDocumentViewerController.DefaultUri)
            };
            return View(model);
        }
    }
}
