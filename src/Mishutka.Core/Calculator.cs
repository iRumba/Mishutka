using Mishutka.Core.Models;
using Mishutka.Core.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mishutka.Core
{
    public static class Calculator
    {
        public static decimal GetCost(CostCalculationgParameters costCalculationgParameters)
        {
            return costCalculationgParameters.WorkItems.Sum(x =>
                (decimal)GetCostForWorkItem(x, costCalculationgParameters.ComplexityMultiplier, costCalculationgParameters.WorkMultiplier));
        }

        private static double GetCostForWorkItem(WorkItem workItem, double complexityMultiplier, double workMultiplier)
        {
            return workItem.Complexity * workItem.IntellectualVolume * complexityMultiplier + workItem.WorkVolume * workMultiplier;
        }
    }
}
