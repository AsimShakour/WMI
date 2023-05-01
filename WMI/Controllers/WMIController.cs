using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WMI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WMIController : ControllerBase
    {

        private readonly ILogger<WMIController> _logger;
        private readonly IWMIService _WMIService;

        public WMIController(ILogger<WMIController> logger, IWMIService WMIService)
        {
            _logger = logger;
            _WMIService = WMIService;
        }

        [HttpGet]
        public IEnumerable<WMIDTO> GetWmis()
        {
            var retVal = new List<WMIDTO>();
            try
            {
                _logger.LogInformation("GetWmis() called");
                return _WMIService.GetWmis();
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "GetWmis() failed");
                return retVal;
            }
        }
    }
}
