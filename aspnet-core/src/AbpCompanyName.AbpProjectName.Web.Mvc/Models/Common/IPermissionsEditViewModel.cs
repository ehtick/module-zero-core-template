﻿using AbpCompanyName.AbpProjectName.Roles.Dto;
using System.Collections.Generic;

namespace AbpCompanyName.AbpProjectName.Web.Models.Common;

public interface IPermissionsEditViewModel
{
    List<FlatPermissionDto> Permissions { get; set; }
}