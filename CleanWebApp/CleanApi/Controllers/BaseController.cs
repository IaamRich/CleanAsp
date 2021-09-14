using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CleanApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase
    {
        protected readonly ILogger<T> Logger;

        public BaseController(ILogger<T> logger)
        {
            Logger = logger;
        }
    }
}