using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminWeb.Configuration
{
    public class AppConfig
    {
        public bool Produkcni { get; set; }
        public bool Ostry { get; set; }
        public string DB { get; set; }
        public string DBTest { get; set; }
       
    }
}
