using System.Collections.Generic;
using System.Linq;

namespace BlondeHeaven.Models
{
    public class NoodleRepository : INoodleRepository
    {
        private readonly AppDbContext m_context;
        public NoodleRepository(AppDbContext appDbContext)
        {
            m_context = appDbContext;
        }

        public List<Noodle> GetAllNoodles()
        {
            return m_context.Noodles.ToList();
        }

        public Noodle GetNoodleById(int id)
        {
            return m_context.Noodles.FirstOrDefault(x => x.Id == id);
        }
    }
}
