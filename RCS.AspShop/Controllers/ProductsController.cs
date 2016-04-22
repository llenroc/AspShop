using RCS.AspShop.Models;
using System.Web.Mvc;

namespace RCS.AspShop.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        // TODO Get the filters, or at least category and subcategory, into the [Route]? Use a Post somehow?
        public ActionResult Products()
        {
            // TODO Have viewModel implicit in cshtml like elsewhere, or the other way around like here? 
            // Currently 2 ways have been used.
            var viewModel = new ProductsViewModel();
            viewModel.Refresh();

            // Note no direct instances of the cshtml views can be made, so this dependent of explicit or even implicit names instead of strongly typed objects.
            return View("Products", viewModel);
        }

        // GET: Product
        public ActionResult Product(int id)
        {
            var viewModel = new ProductViewModel();
            viewModel.Refresh(id);

            return View("Product", viewModel);
        }
    }
}