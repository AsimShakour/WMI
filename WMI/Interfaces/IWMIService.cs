using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WMI
{
    public interface IWMIService
    {
        IEnumerable<WMIDTO> GetWmis();
    }
}