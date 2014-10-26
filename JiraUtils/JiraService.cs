using JiraUtils.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JiraUtils
{
    public class JiraService
    {

        public String ServerUrl { get; set; }

        /// <summary>
        /// Get Jira Issue by key
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="key"></param>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Issue GetJiraIssueByKey(string key, string user, string password)
        {
            WebClient client = new WebClient();
            string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", user, password)));
            client.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", credentials);
            string url = string.Format("{0}/issue/{1}", this.ServerUrl, key);
            var jsonResponse = client.DownloadString(url);
            Issue issue = JsonConvert.DeserializeObject<Issue>(jsonResponse);
            return issue;

        }

        /// <summary>
        /// Get Jira Issue by Id or Key
        /// </summary>
        /// <param name="serverUrl"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Issue GetJiraIssueByIdOrKey(string key)
        {
            WebClient client = new WebClient();
            string url = string.Format("{0}/issue/{1}", this.ServerUrl, key);
            var jsonResponse = client.DownloadString(url);
            Issue issue = JsonConvert.DeserializeObject<Issue>(jsonResponse);
            return issue;

        }

        /// <summary>
        /// Get issues of sprint when use Jira Agile
        /// </summary>
        /// <param name="sprintName">Name of the sprint</param>
        /// <returns></returns>
        public IEnumerable<Issue> GetIssuesBySprint(string sprintName)
        {
            WebClient client = new WebClient();
            string url = string.Format("{0}/search?jql=Sprint=\"{1}\"", this.ServerUrl, sprintName);
            var jsonResponse = client.DownloadString(url);
            dynamic response = JsonConvert.DeserializeObject(jsonResponse);
            var issues = response["issues"].ToObject<IEnumerable<Issue>>();
            return issues;
        }

        /// <summary>
        /// Get Jira Project by id
        /// </summary>
        /// <param name="id">project id</param>
        /// <returns></returns>
        public Project GetProjectById(int id)
        {
            WebClient client = new WebClient();
            string url = string.Format("{0}/project/{1}", this.ServerUrl, id);
            var jsonResponse = client.DownloadString(url);
            Project project = JsonConvert.DeserializeObject<Project>(jsonResponse);
            return project;
        }

        public JiraService(string serverUrl)
        {
            this.ServerUrl = serverUrl;
        }
    }
}
