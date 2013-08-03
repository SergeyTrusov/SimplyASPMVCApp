using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTask.Models.Abstract
{
    public interface ICommentsRepository
    {
        Comment GetById(int id);
        IQueryable<Comment> GetAll();
        Comment Add(Comment comment);
        Comment Update(Comment id);
        void Delete(int id);
        IEnumerable<Comment> GetCommentByReviewedId(int id);
    }
}