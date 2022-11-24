﻿using Microsoft.AspNetCore.Mvc;

namespace UTNCursoApi.Controllers.v2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("[controller]")]
    public class TodosController : ControllerBase
    {
        //#4
        //#5
        [HttpGet("healthcheck")]
        public async Task<string> Healthcheck()
        {
            return "Ok";
        }

        [HttpGet]
        public async Task<ActionResult> GetAll2()
        {
            return await Task.FromResult(Ok());
        }

        [ApiVersion("2.5")]
        [HttpGet("v{version:apiVersion}/fail")]
        public async Task<ActionResult> GetFail()
        {
            return await Task.FromResult(BadRequest());
        }
    }
}
