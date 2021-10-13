using SOLID.DIP.Solucao.Interface;

namespace SOLID.DIP.Solucao
{
    public class CarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        
        public object CreateCar(object car)
        {
            // Seguindo o DIP utilizamos a abstracao do repositorio.
            return _carRepository.CreateCar(car);
        }
    }
}