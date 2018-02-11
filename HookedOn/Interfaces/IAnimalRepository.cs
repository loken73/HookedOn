using HookedOn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HookedOn.Interfaces
{
    public interface IAnimalRepository
    {
        Animal GetAnimalByName(string AnimalName);

        Animal GetAnimalById(int animalId);

        IEnumerable<AnimalCardDTO> GetNewestAnimals { get; }

        IEnumerable<AnimalCardDTO> GetReptiles { get; }

        IEnumerable<AnimalCardDTO> GetMammals { get; }

        IEnumerable<AnimalCardDTO> GetFish { get; }

        IEnumerable<AnimalCardDTO> GetAllAnimals { get; }
    }
}
