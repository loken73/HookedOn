using HookedOn.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HookedOn.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                AppDbContext context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Animals.Any())
                {
                    context.AddRange
                    (

                        new Reptile
                        {
                            Name = "Eastern Bearded Dragon",
                            Description = "It is one of a group of species known commonly as bearded dragons. " +
                                          "Other common names for this species include Jew lizard and frilly lizard, the latter being a confusion between this and another dragon, the frill - necked lizard(Chlamydosaurus kingii)." +
                                          "This species was originally described in 1829 by Georges Cuvier, who named it Amphibolurus barbatus.",
                            Temperament = "Docile",
                            CareLevel = "Intermediate",
                            LifeExpectancy = "6-10 years",
                            Origin = "Southeast Australia",
                            AdultSize = "24 inches",
                            Diet = "Omnivore",
                            AmbientTemperature = "Should be kept at room temperature around 75 °F with a baskking light hot at 95 °F",
                            Price = 200,
                            DateAdded = new DateTime(2017, 12, 18),
                            Substrate = "Newspaper, paper towel and reptile carpet, also sand but be careful with intestinal impaction for younger pets.",
                            Terrarium = "36\" L x 24\" D x 24\" H",
                            ImageUrl = "/images/eastern_bearded_dragon.jpg"
                        },

                        new Reptile
                        {
                            Name = "Ball Python",
                            Description = "The ball python(Python regius), also known as the royal python, is a python species found in sub - Saharan Africa. " +
                                          "Like all other pythons, it is a non - venomous constrictor. " +
                                          "This is the smallest of the African pythons and is popular in the pet trade, largely due to its small size and typically docile temperament.",
                            Temperament = "Docile",
                            CareLevel = "Easy",
                            LifeExpectancy = "30 years",
                            Origin = "Central and Western Africa",
                            AdultSize = "Males: 2-3 feet long, Females: 4-6 feet long",
                            Diet = "Omnivore",
                            AmbientTemperature = "Should be kept at room temperature around 75 °F with a baskking light hot at 88°F - 95°F",
                            Price = 220,
                            DateAdded = new DateTime(2017, 12, 13),
                            Substrate = "Newspaper, paper towel and reptile carpet, Cypress mulch and orchid bark are great substrates for controlling humidity. " +
                                        "Also, please avoid any substrate containing cedar as that can be poisonous to reptiles.",
                            Terrarium = "Juvenile: 36\" L x 24\" D x 24\" H, Adult: 72\" L x 48\" D x 48\" H, with a hidespot or two.",
                            ImageUrl = "/images/ball_python.jpg"
                        },

                        new Reptile
                        {
                            Name = "Gila Monster",
                            Description = "The Gila monster is a species of venomous lizard native to the southwestern United States and northwestern Mexican state of Sonora." +
                                          " A heavy, typically slow-moving lizard, that can grow up to 60 cm (2.0 ft) long. " +
                                          "The Gila monster is the only venomous lizard native to the United States and one of only two known species of venomous lizards in North America.",
                            Temperament = "Docile",
                            CareLevel = "Advanced",
                            LifeExpectancy = "6-10 years",
                            Origin = "Southwestern United Stated, Northern Mexico",
                            AdultSize = "20-22 inches",
                            Diet = "Carnivore",
                            AmbientTemperature = "Should be kept at room temperature around 75 °F with a baskking light hot at 95 °F",
                            Price = 200,
                            DateAdded = new DateTime(2017, 12, 16),
                            Substrate = "The Gila monster thrives in a spacious cage if a mixture of dry sand and gravel is used to mimic its natural desert terrain. " +
                                        "Add extra rocks and dead wood or cholla cactus limbs, but don’t be surprised if captive Gila monsters constantly rearrange them as they dig around.",
                            Terrarium = "72\" L x 48\" D x 48\" H",
                            ImageUrl = "/images/gila_monster.jpg"
                        },

                        new Reptile
                        {
                            Name = "Crested Gecko",
                            Description = "The crested gecko is a species of gecko native to southern New Caledonia. " +
                                          "In 1866, when New Caledonia was discovered, the crested gecko was discovered by a French zoologist named Alphone Guichenot, " +
                                          "who is also credited with naming the species.",
                            Temperament = "Docile",
                            CareLevel = "Easy",
                            LifeExpectancy = "15-20 years",
                            Origin = "New Caledonia",
                            AdultSize = "8 inches",
                            Diet = "Omnivore",
                            AmbientTemperature = "75°F - 80°F with relative humidity between 50-70%",
                            Price = 200,
                            DateAdded = new DateTime(2017, 12, 15),
                            Substrate = "Reptile carpet, peat-moss-based soil mixed with 50% soil",
                            Terrarium = "36\" L x 24\" D x 24\" H",
                            ImageUrl = "/images/crested_gecko.jpg"
                        },

                        new Fish
                        {
                            Name = "Clownfish",
                            Description = "Clownfish or anemonefish are fishes from the subfamily Amphiprioninae in the family Pomacentridae. " +
                                          "Thirty species are recognized: one in the genus Premnas, while the remaining are in the genus Amphiprion. " +
                                          "In the wild, they all form symbiotic mutualisms with sea anemones. " +
                                          "Depending on species, anemonefish are overall yellow, orange, or a reddish or blackish color, and many show white bars or patches.",
                            Temperament = "Docile",
                            CareLevel = "Easy",
                            LifeExpectancy = "4-8 years",
                            Origin = "Indian, Pacific Oceans",
                            AdultSize = "4 inches",
                            Diet = "Omnivore",
                            AmbientTemperature = "Water should be kept at just below room temperature",
                            Price = 25,
                            DateAdded = new DateTime(2017, 12, 18),
                            AquariumSize = "20 gallon tank",
                            WaterType = "Saltwater",
                            ReefSafe = "Yes",
                            ImageUrl = "/images/clownfish.jpg"
                        },

                        new Fish
                        {
                            Name = "Flame Angelfish",
                            Description = "The flame angelfish (Centropyge loriculus)[1] is a marine angelfish of the family Pomacanthidae found in tropical waters of the Pacific Ocean." +
                                          " Other common names include flame angel, flaming angelfish, and Japanese pygmy angelfish.",
                            Temperament = "Semi-Aggressive",
                            CareLevel = "Intermediate",
                            LifeExpectancy = "6-10 years",
                            Origin = "Central Pacific",
                            AdultSize = "4 inches",
                            Diet = "Omnivore",
                            AmbientTemperature = "Water temperature 72°F - 75°F",
                            Price = 30,
                            DateAdded = new DateTime(2017, 12, 13),
                            AquariumSize = "70 gallon tank",
                            WaterType = "Saltwater",
                            ReefSafe = "With Caution",
                            ImageUrl = "/images/flame_angelfish.jpg"
                        },

                        new Fish
                        {
                            Name = "Volitan Lionfish",
                            Description = "The red lionfish (Pterois volitans) is a venomous coral reef fish in the family Scorpaenidae, order Scorpaeniformes. " +
                                          "P. volitans is natively found in the Indo-Pacific region, but has become an invasive problem in the Caribbean Sea, as well as along the East Coast of the United States. " +
                                          "This and a similar species, Pterois miles, have both been deemed as invasive species. " +
                                          "Red lionfish are clad in white stripes alternated with red/maroon/brown stripes.",
                            Temperament = "Semi-Aggressive",
                            CareLevel = "Easy",
                            LifeExpectancy = "8-12 years",
                            Origin = "Caribbean",
                            AdultSize = "18 inches",
                            Diet = "Carnivore",
                            AmbientTemperature = "Water Temperature 72-78° F",
                            Price = 75,
                            DateAdded = new DateTime(2017, 12, 14),
                            AquariumSize = "120 gallon tank",
                            WaterType = "Saltwater",
                            ReefSafe = "With Caution",
                            ImageUrl = "/images/volitan_lionfish.jpg"
                        },

                        new Fish
                        {
                            Name = "Clown Triggerfish",
                            Description = "Clown triggerfish (Balistoides conspicillum), also known as the bigspotted triggerfish, are demersal marine fish belonging to the family Balistidae, or commonly called triggerfish. " +
                                          "The clown triggerfish is widely distributed throughout the tropical and subtropical waters of the Indian Ocean until the western Pacific Ocean they can also be found in the caribbean.",
                            Temperament = "Easy",
                            CareLevel = "Aggressive",
                            LifeExpectancy = "6-10 years",
                            Origin = "Pacific Ocean, Indian Ocean, Caribbean",
                            AdultSize = "20 inches",
                            Diet = "Carnivore",
                            AmbientTemperature = "Should e kept at room temperature around 75 °F with a baskking light hot at 95 °F",
                            Price = 200,
                            DateAdded = new DateTime(2017, 12, 15),
                            AquariumSize = "300 gallon tank",
                            WaterType = "Saltwater",
                            ReefSafe = "No",
                            ImageUrl = "/images/clown_triggerfish.jpg"
                        },

                        new Mammal
                        {
                            Name = "Sugar Glider",
                            Description = "The sugar glider (Petaurus breviceps) is a small, omnivorous, arboreal, and nocturnal gliding possum belonging to the marsupial infraclass. " +
                                          "The common name refers to its preference for sugary nectarous foods and ability to glide through the air, much like a flying squirrel.",
                            Temperament = "Docile",
                            CareLevel = "Easy",
                            LifeExpectancy = "6-10 years",
                            Origin = "Australia, South Pacific Region",
                            AdultSize = "9-12 inches",
                            Diet = "Omnivore: Small insects, and fruit.",
                            AmbientTemperature = "Should be kept in a warm room with temperature ranging 80°F - 88°F",
                            Price = 80,
                            DateAdded = new DateTime(2017, 12, 10),
                            Substrate = "Carefresh pet bedding, paper towels, a piece of fleece and newspaper",
                            Housing = "Flat bottom cage: 36\" L x 24\" D x 24\" H, Nesting Box since Nocturnal",
                            ImageUrl = "/images/sugar_glider.jpg"
                        },

                        new Mammal
                        {
                            Name = "Four-toed Hedgehog",
                            Description = "A hedgehog is any of the spiny mammals of the subfamily Erinaceinae, in the eulipotyphlan family Erinaceidae. " +
                                          "There are seventeen species of hedgehog in five genera, found through parts of Europe, Asia, and Africa, and in New Zealand by introduction.",
                            Temperament = "Docile",
                            CareLevel = "Easy",
                            LifeExpectancy = "4-7 years",
                            Origin = "Sub-Saharan Africa",
                            AdultSize = "8 inches",
                            Diet = "Omnivore: Small insects, rodents, smaller reptiles, eggs, fruit.",
                            AmbientTemperature = "",
                            Price = 75,
                            DateAdded = new DateTime(2017, 12, 18),
                            Substrate = "Cloth cage liners are preferable for hedgehogs. Fleece, flannel or corduroy fabrics work best.",
                            Housing = "Flat bottom cage, 60\" L x 24\" D x 24\" H",
                            ImageUrl = "/images/hedgehog.jpg"
                        },

                        new Mammal
                        {
                            Name = "Ferret",
                            Description = "The ferret (Mustela putorius furo) is the domesticated form of the European polecat, a mammal belonging to the same genus as the weasel, Mustela of the family Mustelidae. " +
                                          "They typically have brown, black, white, or mixed fur. ",
                            Temperament = "Docile",
                            CareLevel = "Intermediate",
                            LifeExpectancy = "6-10 years",
                            Origin = "Southeast Australia",
                            AdultSize = "24 inches",
                            Diet = "Carnivore",
                            AmbientTemperature = "65°F - 75°F",
                            Price = 45,
                            DateAdded = new DateTime(2017, 12, 15),
                            Substrate = "Cloth cage liners are preferable. Fleece, flannel or corduroy fabrics work best",
                            Housing = "Cage: 60\" L x 24\" D x 24\" H",
                            ImageUrl = "/images/ferret.jpg"
                        },

                        new Mammal
                        {
                            Name = "Guinea Pig",
                            Description = "The domestic guinea pig or simply guinea pig (Cavia porcellus), also known as cavy, is a species of rodent belonging to the family Caviidae and the genus Cavia. " +
                                          "Despite their common name, these animals are not in the pig family Suidae, nor do they come from Guinea in Africa. " +
                                          "Studies based on biochemistry and hybridization suggest they are domestic descendants of a closely related species of cavy such as C. tschudii, and therefore do not exist naturally in the wild.",
                            Temperament = "Docile",
                            CareLevel = "Easy",
                            LifeExpectancy = "8-12 years",
                            Origin = "South America",
                            AdultSize = "18 inches",
                            Diet = "Herbivore",
                            AmbientTemperature = "65°F - 75°F",
                            Price = 20,
                            DateAdded = new DateTime(2017, 12, 10),
                            Substrate = "Cloth cage liners are preferable. Fleece, flannel or corduroy fabrics work best",
                            Housing = "Flat bottom cage: 60\" L x 24\" D x 24\" H, also away from string heat sources",
                            ImageUrl = "/images/guinea_pig.jpg"
                        }

                    );

                    context.SaveChanges();
                }
            }
        }
    }
}
