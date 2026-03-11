using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApiClass.Filters
{
    public class ResultFilter : Attribute, IAsyncResultFilter
    {
        public async Task OnResultExecutionAsync(ResultExecutingContext context, 
            ResultExecutionDelegate next)
        {
            Console.WriteLine("ResultFilter....before");
             await next();

            Console.WriteLine("ResultFilter....after");
        }
    }
}
