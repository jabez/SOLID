namespace SOLID.DIP.Violacao
{
    public class CarService
    {
        public object CreateCar(object car)
        {
            // Violação, estamos instanciando a classe ao invés da abstração
            return new CarRepository().CreateCar(car);
        }
    }
}