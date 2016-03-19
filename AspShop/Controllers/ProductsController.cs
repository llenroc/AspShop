using AspShop.Models;
using System.Web.Mvc;

namespace AspShop.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Products()
        {
            var viewModel = new ProductsViewModel();
            viewModel.Refresh();

            return View(viewModel);
        }

        // GET: Product
        public ActionResult Product(int id)
        {
            var viewModel = new ProductViewModel();
            viewModel.Refresh(id);

            return View(viewModel);
        }
    }
}