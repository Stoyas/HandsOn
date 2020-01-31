using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace PMM.Common.Exceptions
{
    public class CustomExceptionFilter: IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            HttpStatusCode status = HttpStatusCode.InternalServerError;
            string message = string.Empty;

            var exceptionType = context.Exception.GetType();
            if (exceptionType == typeof(UnauthorizedAccessException))
            {
                status = HttpStatusCode.Unauthorized;
                message = "UnAuthorized Access.";
            }
            else if (exceptionType == typeof(NotImplementedException))
            {
                status = HttpStatusCode.NotImplemented;
                message = "Not Implemented error";
            }
            else if (exceptionType == typeof(AppException))
            {
                status = HttpStatusCode.InternalServerError;
                message = context.Exception.ToString();
            }
            else if (exceptionType == typeof(CustomerException))
            {
                status = HttpStatusCode.InternalServerError;
                message = "An error has occured when processing request, please contact your Administrator";
            }
            else
            {
                status = HttpStatusCode.InternalServerError;
                message = "Hahaha there's an unhandled error, hahaha";
            }

            context.ExceptionHandled = true;

            HttpResponse response = context.HttpContext.Response;
            response.StatusCode = (int) status;
            response.ContentType = "application/json";
            var err = message + " " + context.Exception.StackTrace;
            response.WriteAsync(err);
        }
    }
}
