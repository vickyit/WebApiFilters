using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApiClass.Filters
{
    public class ExecptionFilter : IAsyncExceptionFilter
    {
        public Task OnExceptionAsync(ExceptionContext context)
        {
            Console.WriteLine(context.Exception.Message);

            context.Result = new ObjectResult(
                new
                {
                    Message = "Error",
                    Error = context.Exception.Message
                }
                )
            {
                StatusCode=400
            };

            context.ExceptionHandled = true;
            return Task.CompletedTask;
        }
    }
}
