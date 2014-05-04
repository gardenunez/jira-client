using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JiraUtils.Entities
{
    public class IssueWatches
    {
        public string Self { get; set; }
        public int WatchCount { get; set; }
        public bool IsWatching { get; set; }
    }
}
