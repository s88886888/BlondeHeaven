﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace BlondeHeaven.ViewModels.User
{
    public class UserRoleViewModel
    {
        public UserRoleViewModel()
        {
            Users = new List<IdentityUser>();
        }

        public string UserId { get; set; }
        public string RoleId { get; set; }

        public List<IdentityUser> Users { get; set; }
    }
}
