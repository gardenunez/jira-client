using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraUtils.Entities
{
    public class WorkLog
    {
        public int Id { get; set; }
        public string Self { get; set; }
        public Author Author { get; set; }
        public Author updateAuthor { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Started { get; set; }
        public string TimeSpent { get; set; }
        public int TimeSpentSeconds { get; set; }

    }
}
