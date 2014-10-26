using JiraUtils.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using JiraUtils;

namespace JiraClient
{
    class Program
    {
        static void PrintIssue(Issue issue)
        {
            Console.WriteLine("ID: {0}  KEY: {1}", issue.Id, issue.Key);
            Console.WriteLine("Description: {0}", issue.Fields.Description);
            Console.WriteLine("Created: {0}", issue.Fields.Created);
            Console.WriteLine("Updated: {0}", issue.Fields.Updated);
            Console.WriteLine("DueDate: {0}", issue.Fields.DueDate);
            Console.WriteLine("LastViewed: {0}", issue.Fields.LastViewed);
            Console.WriteLine("Type: {0}", issue.Fields.IssueType.Name);
            Console.WriteLine("Project: {0}", issue.Fields.Project.Name);
            Console.WriteLine("*********************************");

                
        }
        static void Main(string[] args)
        {
            List<string> sources = new List<string>() { "DEMO-1", "DEMO-2", "DEMO-3" };
            string user = ConfigurationManager.AppSettings[Constants.USER_KEY];
            string passwd = ConfigurationManager.AppSettings[Constants.PASS_KEY];
            string baseUrl = ConfigurationManager.AppSettings[Constants.BASEURL_KEY];
            JiraService jiraService = new JiraService(baseUrl);
            
            foreach (string current in sources)
            {
                Issue issue = jiraService.GetJiraIssueByIdOrKey(current);
                PrintIssue(issue);
            }

            var issues = jiraService.GetIssuesBySprint("35mm Capture - 2.7.1");
            foreach (var issue in issues)
            {
                PrintIssue(issue);
            }

            Console.Read();
        }

      
    }
}
