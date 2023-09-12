using System.ComponentModel.DataAnnotations;

namespace Shop.Core.Domain
{
    public class SpaceShip
    {
        [Key]
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Passengers { get; set; }
        public int EnginePower { get; set; }
        public int Crew { get; set; }
        public string Company { get; set; }
        public int CargoWeight { get; set; }

        //Only in Database

        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }


    }
}