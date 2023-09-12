using Shop.Core.Domain;
using Shop.Core.Dto;
using Shop.Core.ServiceInterface;
using Shop.Data;

namespace Shop.ApplicationServices.Services
{
    public class SpaceshipServices : ISpaceShipServices
    {
        private readonly ShopContext _context;

        public SpaceshipServices
            (
                ShopContext context
            
            )

        {

            _context = context;
        }
        public async Task<SpaceShip> Create(SpaceShipDto dto)
        {

            SpaceShip spaceship = new SpaceShip();
            spaceship.Id = Guid.NewGuid();
            spaceship.Name = dto.Name;
            spaceship.Type = dto.Type;
            spaceship.Passengers = dto.Passengers;
            spaceship.EnginePower = dto.EnginePower;
            spaceship.Crew = dto.Crew;
            spaceship.Company = dto.Company;
            spaceship.CargoWeight = dto.CargoWeight;
            spaceship.CreatedAt = dto.CreatedAt;
            spaceship.ModifiedAt = dto.ModifiedAt;

            await _context.SaveChangesAsync(spaceship);
            await _context.SaveChangesAsync();



            return spaceship;



        }


    }
}
