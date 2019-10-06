using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Commands
{

    public class TestAspectsCommandResponse
    {
        public String Status { get; set; }
    }

    public class TestAspectsCommand  : IRequest<TestAspectsCommandResponse>
    {
        public String Value { get; set; }
    }
}
