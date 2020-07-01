using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models
{
    /// <summary>
    /// 面条仓储
    /// </summary>
    public interface INoodleRepository
    {
        List<Noodle> GetAllNoodles();

        Noodle GetNoodleById(int id);
    }
}
