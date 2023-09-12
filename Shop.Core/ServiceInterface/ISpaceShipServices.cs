

using Shop.Core.Domain;
using Shop.Core.Dto;

namespace Shop.Core.ServiceInterface
{
    public internal interface ISpaceShipServices
    {
        Task<SpaceShip> Create(SpaceShipDto dto);
    }
}

