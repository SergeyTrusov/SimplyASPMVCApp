using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TestTask.Models.Abstract;

namespace TestTask.Models.Repository
{
    public class CategoriesRepository : ICategoriesRepository
    {
        ReviewedContext _db { get; set; }

        public CategoriesRepository()
            : this (new ReviewedContext())
        {

        }

        public CategoriesRepository(ReviewedContext db)
        {
            _db = db;
        }

        public Category GetById(int id)
        {
            return _db.Categories.SingleOrDefault(c => c.Id == id);
        }

        public Category GetByName(string name)
        {
            return _db.Categories.SingleOrDefault(c => c.Name == name);
        }

        public IQueryable<Category> GetAll()
        {
            return _db.Categories;
        }

        public Category Add(Category category)
        {
            _db.Categories.Add(category);
            return category;
        }

        public Category Update(Category category)
        {
            _db.Entry(category).State = EntityState.Modified;
            return category;
        }

        public void Delete(int id)
        {
            var category = GetById(id);
            _db.Categories.Remove(category);
        }
    }
}