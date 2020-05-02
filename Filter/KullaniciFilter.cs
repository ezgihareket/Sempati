using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace Sempati.Filter{
     public class KullaniciFilterAttribute: ActionFilterAttribute {
        public override void OnActionExecuting (ActionExecutingContext filterContext) {
            int? id = filterContext.HttpContext.Session.GetInt32("id");
            if (!id.HasValue) {

                filterContext.Result =  new RedirectToRouteResult(
                                   new RouteValueDictionary 
                                   {
                                       { "action", "Index" },
                                       { "controller", "Home" }
                                   });
            }
        }
        public override void OnActionExecuted (ActionExecutedContext filterContext) {
        }
    }
}