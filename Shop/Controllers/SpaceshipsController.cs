using Microsoft.AspNetCore.Mvc;
using Shop.Core.Dto;
using Shop.Core.ServiceInterface;
using Shop.Data;
using Shop.Models;
using Shop.Models.Spaceship;

namespace Shop.Controllers
{
    public class SpaceshipsController : Controller
    {
        private readonly ShopContext _context;
        private readonly ISpaceShipServices _spaceShipServices;

        public SpaceshipsController
            (
                ShopContext context,
                ISpaceShipServices spaceShipServices
            )

        {
            _context = context;
        }
        public IActionResult Index()
        {
            var result = _context.SpaceShips
                .Select(x => new SpaceshipsIndexViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Type = x.Type,
                    EnginePower = x.EnginePower,
                    Passengers = x.Passengers
                });

            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Create(SpaceshipsCreateViewModel vm)
        {
            var dto = new SpaceShipDto
            {
                Id = vm.Id,
                Name = vm.Name,
                Type = vm.Type,
                EnginePower = vm.EnginePower,
                Passengers = vm.Passengers,
                Crew = vm.Crew,
                Company = vm.Company,
                CargoWeight = vm.CargoWeight

            };

            var result = await _spaceShipServices.Create(dto);

               return RedirectToAction(nameof(Index), vm);

        }





        //    retur
    }
}

