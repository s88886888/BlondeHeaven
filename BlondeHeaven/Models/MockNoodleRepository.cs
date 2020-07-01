using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models
{
    /// <summary>
    /// 面条仓储实现（假数据）
    /// </summary>
    public class MockNoodleRepository : INoodleRepository
    {
        private List<Noodle> m_noodles;

        public MockNoodleRepository()
        {
            if (m_noodles == null || m_noodles.Count == 0)
            {
                InitializeNoodle();
            }
        }

        private void InitializeNoodle()
        {
            m_noodles = new List<Noodle>()
            {
                new Noodle{Id =1,Name="毛细",Price=12,ShortDescription = "如发丝般细",LongDescription="真的好细好细"},
                new Noodle{Id =2,Name="细",Price=10,ShortDescription = "普通细",LongDescription="还是挺细的"},
                new Noodle{Id =3,Name="二细",Price=10,ShortDescription = "有点粗了",LongDescription="比细的粗点，比粗的细点"},
                new Noodle{Id =4,Name="三细",Price=11,ShortDescription = "粗了",LongDescription="粗的才有嚼劲"},
                new Noodle{Id =5,Name="二柱子",Price=11,ShortDescription = "太粗了",LongDescription="粗的快咬不动了"},
                new Noodle{Id =6,Name="韭叶子",Price=12,ShortDescription = "扁的",LongDescription="韭菜叶一样宽"},
                new Noodle{Id =7,Name="薄宽",Price=11,ShortDescription = "开始宽了",LongDescription="比嘴还宽了"},
                new Noodle{Id =8,Name="大宽",Price=10,ShortDescription = "裤带面",LongDescription="比脸还宽了"},
                new Noodle{Id =9,Name="荞麦棱子",Price=15,ShortDescription = "立方体的",LongDescription="荞麦棱子牛肉面"},
                new Noodle{Id =10,Name="一窝丝",Price=15,ShortDescription = "这是啥",LongDescription="我也没吃过"}
            };
        }

        public List<Noodle> GetAllNoodles()
        {
            return m_noodles;
        }

        public Noodle GetNoodleById(int id)
        {
            return m_noodles.FirstOrDefault(x => x.Id == id);
        }
    }
}
