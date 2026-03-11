using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApiClass.Filters
{
    public class AuthFilter2 : Attribute, IAsyncAuthorizationFilter
    {
        public Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            
            Console.WriteLine(context.HttpContext.Request.Path);
            Console.WriteLine("IAuthorizationFilter");

//            context.Result = new UnauthorizedResult();
            return Task.CompletedTask;

        }
    }
     

    //public class AuthFilter : Attribute, IAuthorizationFilter
    //{
    //    public void OnAuthorization(AuthorizationFilterContext context)
    //    {
    //        Console.WriteLine(context.HttpContext.Request.Path);
    //        Console.WriteLine("IAuthorizationFilter");
    //    }
    //}

}
