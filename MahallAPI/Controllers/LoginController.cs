using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MahallAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class Login : ControllerBase
    {
        [HttpGet]
        public String Get()
        {
            return "Mertkan geliyorum, bekle!";
        }
    }
}
