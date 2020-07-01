using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models
{
    /// <summary>
    /// 客户评价仓储
    /// </summary>
    public interface IFeedbackRepository
    {
        List<Feedback> GetAllFeedbacks();
        void AddFeedback(Feedback feedback);
    }
}
