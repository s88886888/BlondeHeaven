using System.ComponentModel.DataAnnotations.Schema;


namespace BlondeHeaven.Models
{
    public class Ranking : BaseEntity
    {
        /// <summary>
        /// 排行榜
        /// </summary>
        /// 

        [ForeignKey(nameof(ShopKeeper))]
        public int ShopKeeperId { get; set; }
        public ShopKeeper ShopKeepers { get; set; }
    }
}
