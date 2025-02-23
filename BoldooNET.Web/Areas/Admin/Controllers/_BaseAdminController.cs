﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BoldooNET.Web.Areas.Admin.Controllers {

    [Area("Admin")] // Is not inherited. Include in all controllers.
    [Authorize(Roles = "Admin")]
    public class _BaseAdminController : Controller {
    }
}
