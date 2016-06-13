﻿using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public interface IGreeter
    {
        string GetGreeting();
        Task<string> GetGreetingAsync();
    }

    public class Greeter : IGreeter
    {
        private string _greeting;

        public Greeter(IConfiguration configuration)
        {
            _greeting = configuration["Greeting"];
        }

        public string GetGreeting()
        {
            return _greeting;
        }

        public Task<string> GetGreetingAsync()
        {
            return Task.FromResult(GetGreeting());
        }
    }
}