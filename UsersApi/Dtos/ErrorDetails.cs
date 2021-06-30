using System;
using System.Reflection;
using Microsoft.AspNetCore.Diagnostics;
using Newtonsoft.Json;

namespace UsersApi.Dtos
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Source { get; set; }
        public string Error { get; set; }
        
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}