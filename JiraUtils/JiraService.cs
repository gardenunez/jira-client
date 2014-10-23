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
        /// <summary>
        /// Get Jira Issue by key
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="key"></param>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Issue GetJiraIssueByKey(string baseUrl, string key, string user, string password)
        {
            WebClient client = new WebClient();
            string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", user, password)));
            client.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", credentials);
            string url = string.Format("{0}/issue/{1}", baseUrl, key);
            var jsonResponse = client.DownloadString(url);
            Issue issue = JsonConvert.DeserializeObject<Issue>(jsonResponse);
            return issue;

        }

        /// <summary>
        /// Get Jira Issue by key
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Issue GetJiraIssueByKey(string baseUrl, string key)
        {
            WebClient client = new WebClient();
            string url = string.Format("{0}/issue/{1}", baseUrl, key);
            var jsonResponse = client.DownloadString(url);
            Issue issue = JsonConvert.DeserializeObject<Issue>(jsonResponse);
            return issue;

        }
    }
}
