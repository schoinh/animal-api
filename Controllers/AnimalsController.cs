﻿using Animal_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Animal_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private Animal_APIContext _db = new Animal_APIContext();
        private static int _currentPage = 1;
        private static int _entriesPerPage = 3;
        private static int _totalNumEntries;
        private static int _totalPages;
        private static int _prevPage;
        private static int _nextPage;
        private Random _randomGenerator;

        // GET api/animals
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> GetAll(string species = null, string gender = null)
        {
            if (species == null && gender == null)
            {
                return _db.Animals.ToList();
            }
            else if (species == null)
            {
                return _db.Animals.Where(x => x.Gender == gender).ToList();
            }
            else if (gender == null)
            {
                return _db.Animals.Where(x => x.Species == species).ToList();
            }
            else
            {
                return _db.Animals
                    .Where(x => x.Gender == gender)
                    .Where(x => x.Species == species).ToList();
            }
        }

        // GET api/animals (first page)
        [HttpGet("first")]
        public ActionResult<IEnumerable<Animal>> GetFirstPage()
        {
            var allAnimals = _db.Animals.ToList();
            _totalNumEntries = allAnimals.Count();
            _totalPages = (int)Math.Ceiling(_totalNumEntries / (float)_entriesPerPage);
            return _db.Animals.Take(_entriesPerPage).ToList();
        }

        // GET api/animals/next (next page)
        [HttpGet("next")]
        public ActionResult<IEnumerable<Animal>> GetNextPage()
        {
            _nextPage = _currentPage < _totalPages ? _currentPage + 1 : _totalPages;
            var output = _db.Animals
                .Skip((_nextPage - 1) * _entriesPerPage)
                .Take(_entriesPerPage)
                .ToList();
            if (_currentPage < _totalPages)
            {
                _currentPage += 1;
            }
            return output;
        }

        // GET api/animals/prev (previous page)
        [HttpGet("prev")]
        public ActionResult<IEnumerable<Animal>> GetPrevPage()
        {
            _prevPage = _currentPage > 1 ? _currentPage - 1 : 1;
            var output = _db.Animals
                .Skip((_prevPage - 1) * _entriesPerPage)
                .Take(_entriesPerPage)
                .ToList();
            if (_currentPage > 1)
            {
                _currentPage -= 1;
            }
            return output;
        }

        // GET api/animals/5 (retrieve a specific animal)
        [HttpGet("{id}")]
        public ActionResult<Animal> Get(int id)
        {
            return _db.Animals.FirstOrDefault(x => x.AnimalId == id);
        }

        // GET api/animals/random (retrieve a random animal)
        [HttpGet("random")]
        public ActionResult<Animal> GetRandom()
        {
            var allAnimals = _db.Animals.ToList();
            _totalNumEntries = allAnimals.Count();
            _randomGenerator = new Random();
            int randomNum = _randomGenerator.Next(0, _totalNumEntries);
            return allAnimals[randomNum];
        }

        // POST api/animals
        [HttpPost]
        public void Post([FromBody] Animal animal)
        {
            animal.Age = Math.Round((((DateTime.Now - animal.Birthdate).TotalDays) / 365), 1);
            _db.Animals.Add(animal);
            _db.SaveChanges();
        }

        // PUT api/animals/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Animal animal)
        {
            animal.AnimalId = id;
            animal.Age = Math.Round((((DateTime.Now - animal.Birthdate).TotalDays) / 365), 1);
            _db.Entry(animal).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/animals/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var animalToDelete = _db.Animals.FirstOrDefault(x => x.AnimalId == id);
            _db.Animals.Remove(animalToDelete);
            _db.SaveChanges();
        }
    }
}
