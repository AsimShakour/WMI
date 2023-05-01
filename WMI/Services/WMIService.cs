using System.Collections.Generic;

namespace WMI
{
    public class WMIService : IWMIService
    {
        private readonly List<WMIDTO> _wmis;
        public WMIService(List<WMIDTO> wmis)
        {
            _wmis = wmis;
        }

        public IEnumerable<WMIDTO> GetWmis()
        {
            return _wmis;
        }
    }
}