using System;
namespace SerilogExample.Services
{
	public class DummyService:IDummyService
	{
        private ILogger<DummyService> _logger;
		public DummyService(ILogger<DummyService> logger)
        {
            _logger = logger;
        }

        public void DoSomething()
        {
            _logger.LogInformation("something is done");
            _logger.LogCritical("oops");
            _logger.LogDebug("nothing much");

        }
    }
}

