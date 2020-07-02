using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.Models
{
    public class UserShop:BaseEntity
    {

        public string Phone { get; set; }

        [Required, StringLength(50)]
        public string PassWrod { get; set; }


        public List<ShopKeeper> ShopKeepers { get; set; }
    }
}
