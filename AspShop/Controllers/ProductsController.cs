using AspShop.Models;
using System.Web.Mvc;

namespace AspShop.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var viewModel = new ProductsViewModel();
            viewModel.ReadFiltered();

            return View(viewModel);
        }

        // GET: Product
        // TODO Parameter.
        public ActionResult Details()
        {
            // TODO
            return null;
        }
    }
}