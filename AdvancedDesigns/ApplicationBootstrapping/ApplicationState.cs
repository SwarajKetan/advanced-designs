using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBootstrapping
{
    internal class ApplicationState
    {
        public bool Module1Result { get; set; }
        public string Module2Reult { get; set; }
        public Complex Module3Result { get; set; }
        public string Module4Result { get; set; }

        public List<string> Errors { get; set; } = new List<string>();
    }
}
