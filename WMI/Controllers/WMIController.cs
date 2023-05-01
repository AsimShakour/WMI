using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WMI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WMIController : ControllerBase
    {

        private readonly ILogger<WMIController> _logger;
        private readonly IWmiService _wmiService;

        public WMIController(ILogger<WMIController> logger, IWmiService wmiService)
        {
            _logger = logger;
            _wmiService = wmiService;
        }

        [HttpGet]
        public IEnumerable<WMIDTO> GetWmis()
        {
            return _wmiService.GetWmis();
        }
        //if more time add try catch and break into smaller files interface, service etc
    }

    public interface IWmiService
    {
        IEnumerable<WMIDTO> GetWmis();
    }

    public class WmiService : IWmiService
    {
        private readonly List<WMIDTO> _wmis;
        public WmiService(List<WMIDTO> wmis)
        {
            _wmis = wmis;
        }

        public IEnumerable<WMIDTO> GetWmis()
        {
            return _wmis;
        }
    }
}

