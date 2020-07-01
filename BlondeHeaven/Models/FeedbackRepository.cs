
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext m_context;
        public FeedbackRepository(AppDbContext appDbContext)
        {
            m_context = appDbContext;
        }
        public void AddFeedback(Feedback feedback)
        {
            var feed = m_context.Feedbacks.ToList().Count;
            m_context.Feedbacks.Add(feedback);
            m_context.SaveChanges();
        }

        public List<Feedback> GetAllFeedbacks()
        {
            return m_context.Feedbacks.ToList();
        }
    }
}
