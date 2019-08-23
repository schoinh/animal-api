using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Animal_API.Models
{
    [Table("animals")]
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        public DateTime? IntakeDate { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public float? Age { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public float? Weight { get; set; }
        public string Description { get; set; }
        public bool? SpayedNeutered { get; set; }
        public bool? GoodWithCats { get; set; }
        public bool? GoodWithDogs { get; set; }
        public bool? GoodWithKids { get; set; }
    }
}