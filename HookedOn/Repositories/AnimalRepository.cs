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

        public IEnumerable<AnimalCardDTO> GetNewestAnimals => _AppDbContext.Animals
                                                        .OrderByDescending(a => a.DateAdded)
                                                        .Select(a => new AnimalCardDTO()
                                                        {
                                                            AnimalId = a.AnimalId,
                                                            Name = a.Name,
                                                            ImageUrl = a.ImageUrl,
                                                            CareLevel = a.CareLevel,
                                                            Price = a.Price,
                                                            Temperament = a.Temperament
                                                        }).Take(4).ToList();

        public IEnumerable<AnimalCardDTO> GetReptiles => _AppDbContext.Animals
                                                        .OfType<Reptile>()
                                                        .OrderByDescending(a => a.Name)
                                                        .Select(a => new AnimalCardDTO()
                                                        {
                                                            AnimalId = a.AnimalId,
                                                            Name = a.Name,
                                                            ImageUrl = a.ImageUrl,
                                                            CareLevel = a.CareLevel,
                                                            Price = a.Price,
                                                            Temperament = a.Temperament
                                                        }).ToList();

        public IEnumerable<AnimalCardDTO> GetMammals => _AppDbContext.Animals
                                                        .OfType<Mammal>()
                                                        .OrderByDescending(a => a.Name)
                                                        .Select(a => new AnimalCardDTO()
                                                        {
                                                            AnimalId = a.AnimalId,
                                                            Name = a.Name,
                                                            ImageUrl = a.ImageUrl,
                                                            CareLevel = a.CareLevel,
                                                            Price = a.Price,
                                                            Temperament = a.Temperament
                                                        }).ToList();

        public IEnumerable<AnimalCardDTO> GetFish => _AppDbContext.Animals
                                                    .OfType<Fish>()
                                                    .OrderByDescending(a => a.Name)
                                                    .Select(a => new AnimalCardDTO()
                                                    {
                                                        AnimalId = a.AnimalId,
                                                        Name = a.Name,
                                                        ImageUrl = a.ImageUrl,
                                                        CareLevel = a.CareLevel,
                                                        Price = a.Price,
                                                        Temperament = a.Temperament
                                                    }).ToList();

        public IEnumerable<AnimalCardDTO> GetAllAnimals => _AppDbContext.Animals
                                                            .OrderByDescending(a => a.Name)
                                                            .Select(a => new AnimalCardDTO()
                                                            {
                                                                AnimalId = a.AnimalId,
                                                                Name = a.Name,
                                                                ImageUrl = a.ImageUrl,
                                                                CareLevel = a.CareLevel,
                                                                Price = a.Price,
                                                                Temperament = a.Temperament
                                                            }).ToList();

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
