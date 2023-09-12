using Microsoft.AspNetCore.Mvc;
using Shop.Core.Dto;
using Shop.Data;
using Shop.Models;
using Shop.Models.Spaceship;

namespace Shop.Controllers
{
    public class SpaceshipsController : Controller
    {
        private readonly ShopContext _context;

        public SpaceshipsController
            (
                ShopContext context
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
        //[HttpPost]

    //    public async Task<IActionResult> Create(SpaceshipsCreateViewModel vm)
    //    {
    //        var dto = new SpaceShipDto
    //        {
    //            Id = vm.Id,
    //            Name = vm.Name,
    //            Type = vm.Type,
    //            EnginePower = vm.EnginePower,
    //            Passengers = vm.Passengers,
    //            Crew = vm.Crew,
    //            Company = vm.Company,
    //            CargoWeight = vm.CargoWeight

    //        };

    //    }


        
        
        
    //    retur
    }
}

