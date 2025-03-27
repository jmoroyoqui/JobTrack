using JobTracker.API.Controllers;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTracker.API.Tests.User
{
    public class TestBase : IClassFixture<WebApplicationFactory<Program>>
    {
        protected readonly HttpClient _httpClient;

        public TestBase(WebApplicationFactory<Program> factory)
        {
            _httpClient = factory.CreateClient();
        }
    }
}
