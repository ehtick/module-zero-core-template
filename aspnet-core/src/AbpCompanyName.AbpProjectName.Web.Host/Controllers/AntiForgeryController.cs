using Abp.Web.Security.AntiForgery;
using AbpCompanyName.AbpProjectName.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace AbpCompanyName.AbpProjectName.Web.Host.Controllers
{
    public class AntiForgeryController : AbpProjectNameControllerBase
    {
        private readonly IAntiforgery _antiforgery;
        private readonly IAbpAntiForgeryManager _antiForgeryManager;

        public AntiForgeryController(IAntiforgery antiforgery, IAbpAntiForgeryManager antiForgeryManager)
        {
            _antiforgery = antiforgery;
            _antiForgeryManager = antiForgeryManager;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }

        public void SetCookie()
        {
            _antiForgeryManager.SetCookie(HttpContext);
        }
    }
}
