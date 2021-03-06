﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraUtils.Entities
{
    /// <summary>
    /// Representation of the fields of an issue
    /// </summary>
    public class IssueFields
    {
        public string Summary { get; set; }
        public string Description { get; set; }

        public int? TimeSpent { get; set; }
        public int? TimeEstimate { get; set; }
        public int? TimeOriginalEstimate { get; set; }
        public int? AggregateTimeSpent { get; set; }

        public IssueType IssueType { get; set; }
        public Project Project { get; set; }
        public IssueWorkLog Worklog { get; set; }
        public IssueComment Comment { get; set; }
        public IssueWatches Watches {get;set;}
        public Priority Priority { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? LastViewed { get; set; }
    }
}
