using Microsoft.AspNetCore.Mvc;
using CarDTO;

namespace PackageAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        readonly ILogger<CarController> _logger;
        readonly ICarService _carService;

        public CarController(ICarService carService, ILogger<CarController> logger)
        {
            _carService = carService;   
            _logger = logger;
        }

        /// <summary>
        /// Permet de connaitre la voiture incluse dans le forfait
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetPackageCar")]
        public Car GetPackageCar()
        {
            bool useStub = true;

            // Donn�es bidon pour tester
            if (useStub)
            {
                _logger.LogInformation("useStub activ� : GetPackageCar envoie une donn�e bidon.");
                return new Car(new Guid(),
                 new CarRentalCompany(new Guid(), "Hertz"),
                 new CarModel(new Guid(),
                     new VehicleSize(6, "Intermediate"),
                     new CarManufacturer(new Guid(), "Toyota"),
                     "Prius",
                     2022)
                 , "Donn�e bidon de l'API forfait");
            }
            else
            {
                // TODO consulter le package et retourner les d�tails de la voiture du forfait
                throw new NotImplementedException();
            }
        }
    }
}