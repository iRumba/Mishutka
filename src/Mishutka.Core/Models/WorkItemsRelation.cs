using System;
using System.Collections.Generic;
using System.Text;

namespace Mishutka.Core.Models
{
    public class WorkItemsRelation
    {
        public WorkItem Related { get; set; }
        public WorkItem Relation { get; set; }
    }
}
