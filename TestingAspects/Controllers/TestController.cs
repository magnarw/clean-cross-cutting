using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestingAspects.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController : ControllerBase
    {


        private readonly IMediator _mediator;

        public TestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public  async Task<String> CreateCommand()
        {
            return (await _mediator.Send<TestAspectsCommandResponse>(new TestAspectsCommand
            {
                Value = "Test"
            })).Status;
        }
    }
}
