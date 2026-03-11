using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApiClass.Filters
{
    public class ResourceFilter : Attribute, IAsyncResourceFilter
    {
        public async Task OnResourceExecutionAsync(ResourceExecutingContext context,
            ResourceExecutionDelegate next)
        {
            Console.WriteLine("IAsyncResourceFilter ...before");

            //context.Result = new ContentResult
            //{
            //    Content="break by ResourceFilter",
            //    StatusCode=403

            //};
            //return;
            
            await next();

            Console.WriteLine("IAsyncResourceFilter ...after");


        }
    }


    //public class ResourceFilter2 : Attribute, IResourceFilter
    //{
    //    public void OnResourceExecuted(ResourceExecutedContext context)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void OnResourceExecuting(ResourceExecutingContext context)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
