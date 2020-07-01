using System.ComponentModel.DataAnnotations.Schema;


namespace BlondeHeaven.Models
{ 
    public class Order : BaseEntity
    {


        public double Price { get; set; }

        [ForeignKey(nameof(ShopKeeper))]
        public int ShopKeeperId { get; set; }
        public ShopKeeper ShopKeepers { get; set; }
    }
}
