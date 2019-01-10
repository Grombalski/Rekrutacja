namespace CarComparer.Controllers
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using CarComparer.Models;
    using CarComparer.Services.Base;

    public class CarComparerController : Controller
    {
        private ICarComparerService carComparerService;

        public CarComparerController(ICarComparerService carComparerService)
        {
            this.carComparerService = carComparerService;
        }

        public IActionResult CarComparer(CarComparerViewModel viewModel)
        {
            if (viewModel != null)
            {
                viewModel = new CarComparerViewModel();
            }

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Compare(CarComparerViewModel viewModel)
        {
            var result = this.carComparerService.GetBetterCar(viewModel);

            return View("Result", result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
