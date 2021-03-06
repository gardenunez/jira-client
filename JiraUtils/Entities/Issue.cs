﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraUtils.Entities
{
    /// <summary>
    /// Representation of Jira Issue
    /// </summary>
    public class Issue
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Self { get; set; }
        public IssueFields Fields { get; set; }
      
    }
}
