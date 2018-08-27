using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Plazius.Routes.Model
{
    [DebuggerDisplay("{Departure} -> {Destination}")]
    public struct RoutePart
    {
        public string Departure;
        public string Destination;

        public RoutePart(string departure, string destination)
        {
            this.Departure = departure;
            this.Destination = destination;
        }
    }
}