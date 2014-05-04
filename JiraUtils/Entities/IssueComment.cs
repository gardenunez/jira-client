using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JiraUtils.Entities
{
    public class IssueComment
    {
        public int StartAt { get; set; }
        public int MaxResults { get; set; }
        public int Total { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    } 
}
