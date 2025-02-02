﻿using Abp.Authorization;
using Abp.Runtime.Session;
using AbpCompanyName.AbpProjectName.Configuration.Dto;
using System.Threading.Tasks;

namespace AbpCompanyName.AbpProjectName.Configuration;

[AbpAuthorize]
public class ConfigurationAppService : AbpProjectNameAppServiceBase, IConfigurationAppService
{
    public async Task ChangeUiTheme(ChangeUiThemeInput input)
    {
        await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
    }
}
