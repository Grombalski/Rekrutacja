namespace CarComparer.Services
{
    using CarComparer.Models;
    using CarComparer.Services.Base;

    public class CarComparerService : ICarComparerService
    {
        public CarViewModel GetBetterCar(CarComparerViewModel carComparer)
        {
            //// Zużycie paliwa i przyspieszenie (ile sekund do 100 km/h) z minusem, ponieważ niższa wartość parametru jest tutaj lepsza
            var totalScore = this.CalculateScoreForTrait(carComparer.FirstCar.MaxSpeed, carComparer.SecondCar.MaxSpeed)
                - this.CalculateScoreForTrait(carComparer.FirstCar.FuelConsumption, carComparer.SecondCar.FuelConsumption)
                + this.CalculateScoreForTrait(carComparer.FirstCar.TankCapacity, carComparer.SecondCar.TankCapacity)
                + this.CalculateScoreForTrait(carComparer.FirstCar.Range, carComparer.SecondCar.Range)
                - this.CalculateScoreForTrait(carComparer.FirstCar.Acceleration, carComparer.SecondCar.Acceleration);

            if (totalScore > 0)
            {
                return carComparer.FirstCar;
            }

            if (totalScore < 0)
            {
                return carComparer.SecondCar;
            }

            return null;
        }

        private int CalculateScoreForTrait(decimal first, decimal second)
        {
            if (first > second)
            {
                return 1;
            }

            if (first < second)
            {
                return -1;
            }

            return 0;
        }
    }
}
