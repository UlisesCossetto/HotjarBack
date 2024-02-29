using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hotjar.Api.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HotjarBaseController: ControllerBase
    {
        protected int CreatorUserId => Convert.ToInt32(User.Claims?.FirstOrDefault(x => x.Type.Equals("idUsuario", StringComparison.OrdinalIgnoreCase))?.Value);
    }
}
