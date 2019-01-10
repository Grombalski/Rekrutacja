namespace CarComparer.Models
{
    using Microsoft.AspNetCore.Mvc;
    using System.ComponentModel.DataAnnotations;

    public class CarViewModel
    {
        [BindProperty]
        [Display(Name="Model")]
        public string Name { get; set; }

        [BindProperty]
        [Display(Name="Maximum speed [km/s]")]
        public decimal MaxSpeed { get; set; }

        [BindProperty]
        [Display(Name="Tank capacity [l]")]
        public decimal TankCapacity { get; set; }

        [BindProperty]
        [Display(Name="Fuel consumption [l/100km]")]
        public decimal FuelConsumption { get; set; }

        [BindProperty]
        [Display(Name="Acceleration [seconds to 100km/s]")]
        public decimal Acceleration { get; set; }

        [BindProperty]
        [Display(Name="Range [km]")]
        public decimal Range 
        {
            get
            {
                if(this.FuelConsumption != 0)
                {
                    return (this.TankCapacity / this.FuelConsumption) * 100;
                }

                return 0;
            }
        } 
    }
}