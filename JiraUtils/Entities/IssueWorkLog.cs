using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraUtils.Entities
{
    public class IssueWorkLog
    {
        public int StartAt { get; set; }
        public int MaxResults { get; set; }
        public int Total { get; set; }
        public IEnumerable<WorkLog> worklogs { get; set; }
    }
}
