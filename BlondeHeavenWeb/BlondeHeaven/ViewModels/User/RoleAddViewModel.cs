using System.ComponentModel.DataAnnotations;

namespace BlondeHeaven.ViewModels.User
{
    public class RoleAddViewModel
    {
        [Required]
        [Display(Name = "角色名称")]
        public string RoleName { get; set; }
    }
}
