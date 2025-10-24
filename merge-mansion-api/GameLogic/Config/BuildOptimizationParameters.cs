using System.Collections.Generic;
using System;

namespace GameLogic.Config
{
    public class BuildOptimizationParameters
    {
        private HashSet<string> _partialBuildEntries;
        public bool IsPartialBuild { get; set; }
        public HashSet<string> PartialBuildEntries { get; set; }
        public bool IsVerbose { get; set; }
    }
}