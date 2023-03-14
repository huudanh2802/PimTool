using Microsoft.AspNetCore.Http;
using Pim_Tool.Controllers;
using Pim_Tool.Exceptions;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pim_Tool.Middlewares {
    public class ErrorHandlerMiddleware {
        private readonly RequestDelegate _next;
        public ErrorHandlerMiddleware (RequestDelegate next) {
            _next = next;
        }
        public async Task Invoke (HttpContext context) {
            try {
                await _next(context);
            }
            catch (BusinessException error) {
                var response = context.Response;
                response.ContentType = "application/json";
                var responseModel = ApiResponse<string>.Fail(error.Message, error.Key);
                switch (error) {
                    case BadRequestException e:
                        // custom application error
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        break;
                    case ConflictException e:
                        //Concurrency error
                        response.StatusCode= (int)HttpStatusCode.Conflict;
                        break;
                    case NotFoundException e:
                        // Resource not found error
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        break;
                    default:
                        // unhandled error
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        responseModel.Message = $"Unexpected error occurred {error.Message}. Please contact your administrator";
                        break;
                }
                var result = JsonSerializer.Serialize(responseModel);
                await response.WriteAsync(result);
            }
        }
    }
}
