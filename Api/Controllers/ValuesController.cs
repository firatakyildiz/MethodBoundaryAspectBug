using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private Operation operation;

        public ValuesController()
        {
            operation = new Operation();
        }

        [HttpPost("SampleEndpoint")]
        public string SampleEndpoint()
        {
            return operation.SampleMethod();
        }
    }
}
