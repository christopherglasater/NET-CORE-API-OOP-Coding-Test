﻿using Microsoft.AspNetCore.Mvc;
using OOPCoreApi.Models;
using OOPCoreApi.Services;

namespace OOPCoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    public class HelloWorldController : Controller
    {
        IHelloWorldService _helloWorldService;
        public HelloWorldController(IHelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService; 
        }
        [HttpGet]
        [Route("DoSomething/{input}")]
        public SomethingModel DoSomething(string input)
        {
            return _helloWorldService.DoSomething(input);
        }

        [HttpPost]
        [Route("DoSomethingElse")]
        public SomethingModel DoSomethingElse([FromBody] SomethingModel input)
        {
            return _helloWorldService.DoSomethingElse(input);
        }
    }
}
