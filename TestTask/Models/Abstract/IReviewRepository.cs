using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTask.Models.Abstract
{
    public interface IReviewRepository
    {
        Review GetById(int id);
        IQueryable<Review> GetAll();
        Review Add(Review review);
        Review Update(Review review);
        void Delete(int id);
        IEnumerable<Review> GetByCategory(Category category);
        IEnumerable<Comment> GetReviewComments(int id);
    }
}