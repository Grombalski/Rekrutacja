namespace CarComparer.Services.Base
{
    using CarComparer.Models;

    public interface ICarComparerService
    {
        CarViewModel GetBetterCar(CarComparerViewModel carComparer);
    }
}
