using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebAPIProject.Filters
{
    public class CustomAuthFilter : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext context)
        {

            var headers = context.HttpContext.Request.Headers;


            if (!headers.ContainsKey("Authorization"))
            {
                context.Result =
                    new BadRequestObjectResult(
                    "Invalid request - No Auth token");

                return;
            }


            string token = headers["Authorization"];


            if (!token.Contains("Bearer"))
            {
                context.Result =
                    new BadRequestObjectResult(
                    "Invalid request - Token present but Bearer unavailable");
            }

        }

    }
}