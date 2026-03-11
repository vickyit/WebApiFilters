using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApiClass.Filters
{
    public class Actionfilter : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context2, 
            ActionExecutionDelegate next2)
        {

            Console.WriteLine("Action Filter Before");

            await next2();

            Console.WriteLine("Action Filter after");

        }
    }
}
