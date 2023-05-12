using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlowAnswer
{
    public class Mapped_Stations
    {
        public int OriginId { get; set; }

        public int DestinationId { get; set; }

        public Station Origin { get; set; }

        public Station Destination { get; set; }
    }
}
