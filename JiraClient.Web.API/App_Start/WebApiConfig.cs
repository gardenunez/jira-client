using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Routing;

namespace JiraClient.Web.API
{
    public static class WebApiConfig
    {
        private const string API_PATH = "api/";

        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "issue_by_id",
                routeTemplate: API_PATH + "issues/{id}",
                defaults: new 
                {
                    controller = "Issues",
                    action = "GetIssueByKey"
                }
            );

            config.Routes.MapHttpRoute(
                name: "issues_by_sprint",
                routeTemplate: API_PATH + "issues/",
                defaults: new
                {
                    controller = "Issues",
                    action = "GetIssuesBySprint"
                }
            );

            config.Routes.MapHttpRoute(
                name: "project_by_id",
                routeTemplate: API_PATH + "projects/{id}",
                defaults: new
                {
                    controller = "Projects",
                    action = "GetProjectById"
                }
            );
        }
    }
}
