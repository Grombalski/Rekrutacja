namespace CarComparer.Models
{
    using Microsoft.AspNetCore.Mvc;

    public class CarComparerViewModel
    {
        public CarComparerViewModel()
        {
            this.FirstCar = new CarViewModel();
            this.SecondCar = new CarViewModel();
        }

        [BindProperty]
        public CarViewModel FirstCar { get; set; }

        [BindProperty]
        public CarViewModel SecondCar { get; set; }
    }
}