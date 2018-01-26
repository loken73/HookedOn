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

        IEnumerable<Animal> GetNewestAnimals { get; }

        IEnumerable<Animal> GetReptiles { get; }

        IEnumerable<Animal> GetMammals { get; }

        IEnumerable<Animal> GetFish { get; }

        IEnumerable<Animal> GetAllAnimals { get; }
    }
}
