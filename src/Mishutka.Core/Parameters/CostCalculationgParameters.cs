using Mishutka.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mishutka.Core.Parameters
{
    public class CostCalculationgParameters
    {
        public IEnumerable<WorkItem> WorkItems { get; set; }
        public double ComplexityMultiplier { get; set; }
        public double WorkMultiplier { get; set; }
    }
}
