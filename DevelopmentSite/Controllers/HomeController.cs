using System.Linq;
using System.Web.Mvc;

using CMS.DocumentEngine;

using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;

namespace Kentico.AspNet.Mvc.DevelopmentSite
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // Uncomment and optionally adjust the document query sample when using Page builder on the Home page
            // See ~/App_Start/ApplicationConfig.cs, ~/Views/Shared/_Layout.cshtml and ~/Views/Home/Index.cshtml
            // In the administration UI, create a Page type and set its
            //   URL pattern = '/'
            //   Use Page tab = True
            // In the administration UI, create a Page utilizing the new Page type

            TreeNode page = DocumentHelper
                .GetDocuments()
                .Path("/Development-Page")
                .OnCurrentSite()
                .TopN(1)
                .FirstOrDefault();
            if (page == null)
            {
                return HttpNotFound();
            }

            HttpContext
                .Kentico()
                .PageBuilder()
                .Initialize(page.DocumentID);

            return View();
        }
    }
}