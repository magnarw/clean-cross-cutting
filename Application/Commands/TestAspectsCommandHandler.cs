using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Backend.Commands
{
    public class TestAspectsCommandHandler : IRequestHandler<TestAspectsCommand, TestAspectsCommandResponse>
    {
        public async  Task<TestAspectsCommandResponse> Handle(TestAspectsCommand request, CancellationToken cancellationToken)
        {
            return new TestAspectsCommandResponse
            {
                Status = "OK"
            };
        }
    }
}
