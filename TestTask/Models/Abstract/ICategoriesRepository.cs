using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTask.Models.Abstract
{
    public interface ICategoriesRepository
    {
        Category GetById(int id);
        Category GetByName(string name);
        IQueryable<Category> GetAll();
        Category Add(Category category);
        Category Update(Category category);
        void Delete(int id);
    }
}