using BlondeHeaven.Model;
using BlondeHeaven.Models.Interface;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models.Data
{
    public class CommentRepository : ICommentRepository
    {

        private readonly AppDbContext _db;

        public CommentRepository(AppDbContext m_context)
        {
            _db = m_context;
        }
        public async Task<T> Add(T model)
        {
            _db.Set<T>().Add(model);
            await _db.SaveChangesAsync();
            return model;
        }

        public Comment Add(Comment model)
        {
            _db.Comments.Add(model);
            _db.SaveChanges();
            return model;
        }

        public async Task<IQueryable<T>> GetCommentAll()
        {
            var dbSet = _db.Set<T>();
            var result = await dbSet.ToListAsync();
            return result.AsQueryable<T>();
        }

        public List<Comment> GetListCommentAll()
        {
            return _db.Comments.ToList();
        }
    }
}
