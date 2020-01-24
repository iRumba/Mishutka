using System;
using System.Collections.Generic;
using System.Text;

namespace Mishutka.Core.Models
{
    public class WorkItem : TitledBase
    {
        public double Complexity { get; set; }

        public double IntellectualVolume { get; set; }

        public double WorkVolume { get; set; }
    }
}
