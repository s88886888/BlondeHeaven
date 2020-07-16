using BlondeHeaven.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlondeHeaven.Model
{
    public class Comment : BaseEntity
    {
        /// <summary>
        /// 评论表
        /// </summary>
        /// 
        ///标题名字
        //public string Name { get; set; }
        [Required, StringLength(3000)]
        ///评论内容
        public string Content { get; set; }

    }
}
