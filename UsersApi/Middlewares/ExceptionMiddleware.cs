using System;
using System.Net;
using System.Reflection;
using System.Transactions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using UsersApi.Dtos;

namespace UsersApi.Middlewares
{
    public static class ExceptionMiddleware
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int) HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";
                    
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    var pathFeature = context.Features.Get<IExceptionHandlerPathFeature>();

                    string source = contextFeature.Error.Source;
                    string message = contextFeature.Error.Message;
                    string path = context.Request.Path;
                    string method = contextFeature.Error.TargetSite.Name;
                    string error = contextFeature.Error.GetType().Name;

                    if (contextFeature != null)
                    {
                        await context.Response.WriteAsync( new ErrorDetails
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = message,
                            Source = source,
                            Path = path,
                            Error = error,
                            Method = method
                        }.ToString());
                    }
                });
            });
        }
    }
}