using BlondeHeaven.Model;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models.Interface
{
    public interface ICommentRepository
    {
        Task<T> Add(T model);
        Comment Add(Comment model);
        Task<IQueryable<T>> GetCommentAll();
        List<Comment> GetListCommentAll();
    }
}
