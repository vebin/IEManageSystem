﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IEManageSystem.Services.ManageHome.AuthorizeManage.ApiScopes.Dto
{
    public class RemoveManagePermissionInput
    {
        [Required]
        public int ApiScopeId { get; set; }

        [Required]
        public int PermissionId { get; set; }
    }
}
