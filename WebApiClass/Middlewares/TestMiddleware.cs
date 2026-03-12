namespace WebApiClass.Middlewares
{
    public class TestMiddleware
    {
        private readonly RequestDelegate _next;

        public TestMiddleware(RequestDelegate next)
        { 
            _next = next; 
        }
        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("Custom Middleware start");
        
            await  _next(context);

            Console.WriteLine("Custom Middleware end");
        }


    }
}
