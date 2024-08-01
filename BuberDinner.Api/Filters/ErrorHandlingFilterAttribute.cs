﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace BuberDinner.Api.Filters
{
    public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception;

            var problemDetails = new ProblemDetails
            {
                Type = "Error",
                Title = "An error occured while processing your request.",
                Status = (int)HttpStatusCode.InternalServerError,
            };

            context.Result = new ObjectResult(problemDetails)
            {
                StatusCode = 500
            };

            context.ExceptionHandled = true;
        }
    }
}
