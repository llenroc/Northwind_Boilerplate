﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Wind.Northwind.Permissions.Dto;

namespace Wind.Northwind.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<PermissionListDto> GetListPermission();
    }
}