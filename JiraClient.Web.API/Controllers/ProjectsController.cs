using JiraUtils;
using JiraUtils.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JiraClient.Web.API.Controllers
{
    public class ProjectsController : ApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage GetProjectById(int id)
        {
            string serverUrl = "http://jira.atlassian.com/rest/api/2";
            JiraService service = new JiraService(serverUrl);
            Project project = service.GetProjectById(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, project, "application/json");
            return response;
        }
    }
}
