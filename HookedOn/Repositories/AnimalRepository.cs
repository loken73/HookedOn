using HookedOn.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HookedOn.Models;
using HookedOn.Data;

namespace HookedOn.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly AppDbContext _AppDbContext;

        public AnimalRepository(AppDbContext appDbContext)
        {
           _AppDbContext = appDbContext;
        }

        public IEnumerable<Animal> GetNewestAnimals => _AppDbContext.Animals.OrderByDescending(a => a.DateAdded).Take(4);

        public IEnumerable<Animal> GetReptiles => _AppDbContext.Animals.OfType<Reptile>().OrderByDescending(a => a.Name);

        public IEnumerable<Animal> GetMammals => _AppDbContext.Animals.OfType<Mammal>().OrderByDescending(a => a.Name);

        public IEnumerable<Animal> GetFish => _AppDbContext.Animals.OfType<Fish>().OrderByDescending(a => a.Name);

        public IEnumerable<Animal> GetAllAnimals => _AppDbContext.Animals.OrderByDescending(a => a.Name);

        public Animal GetAnimalByName(string animalName)
        {
            return _AppDbContext.Animals.FirstOrDefault(a => a.Name == animalName);
        }

        public Animal GetAnimalById (int animalId)
        {
            return _AppDbContext.Animals.FirstOrDefault(a => a.AnimalId == animalId);
        }
    }
}
