using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TestTask.Models.Abstract;

namespace TestTask.Models.Repository
{
    public class CommentsRepository : ICommentsRepository
    {
        private ReviewedContext _db { get; set; }

        public CommentsRepository()
            : this(new ReviewedContext())
        {

        }

        public CommentsRepository(ReviewedContext db)
        {
            _db = db;
        }

        public Comment GetById(int id)
        {
            return _db.Comments.SingleOrDefault(c => c.Id == id);
        }

        public IQueryable<Comment> GetAll()
        {
            return _db.Comments;
        }

        public Comment Update(Comment comment)
        {
            _db.Entry(comment).State = EntityState.Modified;
            _db.SaveChanges();
            return comment;
        }

        public Comment Add(Comment comment)
        {
            _db.Comments.Add(comment);
            return comment;
        }

        public void Delete(int id)
        {
            var comment = GetById(id);
            _db.Comments.Remove(comment);
        }

        public IEnumerable<Comment> GetCommentByReviewedId(int id)
        {
            return _db.Comments.Where(c => c.ReviewId == id);
        }
    }
}