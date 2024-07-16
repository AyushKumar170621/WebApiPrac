﻿using AutoMapper;
using WebApiPractice.Data;
using WebApiPractice.Interfaces;
using WebApiPractice.Modals;

namespace WebApiPractice.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Mapper _mapper;
        private readonly DataContext _datacontext;

        public CategoryRepository(DataContext context)
        {
            _datacontext = context;
        }
        public bool CategoryExisits(int id)
        {
            return _datacontext.Categories.Any(c => c.Id == id);
        }

        public ICollection<Category> GetCategories()
        {
            return _datacontext.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return _datacontext.Categories.Where(e => e.Id == id).FirstOrDefault();
        }

        public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
        {
            return _datacontext.PokemonCategories.Where(e=>e.CategoryId == categoryId).Select(c => c.Pokemon).ToList();
        }
    }
}