﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TestTask.Models.Abstract;

namespace TestTask.Models.Repository
{
    public class ReviewRepository : IReviewRepository
    {
        private ReviewedContext _db { get; set; }

        public ReviewRepository()
            :this (new ReviewedContext())
        {
            
        }

        public ReviewRepository(ReviewedContext db)
        {
            _db = db;
        }

        public Review GetById(int id)
        {
            return _db.Reviews.SingleOrDefault(r => r.Id == id);
        }

        public IQueryable<Review> GetAll()
        {
            return _db.Reviews;
        }

        public Review Add(Review review)
        {
            _db.Reviews.Add(review);
            _db.SaveChanges();
            return review;
        }

        public Review Update(Review review)
        {
            _db.Entry(review).State = EntityState.Modified;
            return review;
        }

        public void Delete(int id)
        {
            var review = GetById(id);
            _db.Reviews.Remove(review);
        }

        public IEnumerable<Review> GetByCategory(Category category)
        {
            return _db.Reviews.Where(r => r.CategoryId == category.Id);
        }

        public IEnumerable<Comment> GetReviewComments(int id)
        {
            return _db.Comments.Where(c => c.ReviewId == id);
        }
    }
}