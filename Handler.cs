using Amazon.Lambda.Core;
using System;
using SimpleMathLibrary;

[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AwsDotnetCsharp
{
    public class Handler
    {
       public Response Add(Request request)
       {
          var math = new SimpleMath();
          var result = math.Add(request.Number1, request.Number2);
          return new Response(String.Format("{0} + {1} = {2}",request.Number1, request.Number2, result), request);
       }

       public Response Subtract(Request request)
       {
          var math = new SimpleMath();
          var result = math.Subtract(request.Number1, request.Number2);
          return new Response(String.Format("{0} - {1} = {2}",request.Number1, request.Number2, result), request);
       }

       public Response Multiply(Request request)
       {
          var math = new SimpleMath();
          var result = math.Multiply(request.Number1, request.Number2);
          return new Response(String.Format("{0} * {1} = {2}",request.Number1, request.Number2, result), request);
       }

       public Response Divide(Request request)
       {
          var math = new SimpleMath();
          var result = math.Divide(request.Number1, request.Number2);
          return new Response(String.Format("{0} / {1} = {2}",request.Number1, request.Number2, result), request);
       }



    }

    public class Response
    {
      public string Message {get; set;}
      public Request Request {get; set;}

      public Response(string message, Request request){
        Message = message;
        Request = request;
      }
    }

    public class Request
    {
      public double Number1 {get; set;}
      public double Number2 {get; set;}

      public Request(double number1, double number2){
        Number1 = number1;
        Number2 = number2;
      }
    }
}
