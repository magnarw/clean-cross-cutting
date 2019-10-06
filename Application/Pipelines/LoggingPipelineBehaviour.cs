using Backend.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Backend.Pipelines
{
    public class LoggingPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private IBosLogger _logger;
        private BosContext _context; 

        public LoggingPipelineBehavior(IBosLogger commandLogger, BosContext context)
        {
            this._logger = commandLogger;
            this._context = context;

        }
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {

            var input = request;
            try
            {
                var response = await next();
                _logger.Log(LogLevel.INFO, typeof(TRequest).Name, _context.GetAuthenticatedUserPrinepal(), _context.GetCorrelationId(),_context.GetRequestId(),_context.GetClientApplication(), input.ToString(), response.ToString(), null);
                return (TResponse)response;
            }
            catch (Exception e)
            {
                _logger.Log(LogLevel.INFO, typeof(TRequest).Name, _context.GetAuthenticatedUserPrinepal(), _context.GetCorrelationId(), _context.GetRequestId(), _context.GetClientApplication(), input.ToString(), null, e.Message);
                throw e;
            }
        }
    }
}
