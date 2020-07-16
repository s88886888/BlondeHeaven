using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeHeaven.ViewModels.Data
{
    public class CommentViewModel
    {
        [Required]
        [Display(Name = "你的大字")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "你的问题")]
        public string Content { get; set; }
    }
}
