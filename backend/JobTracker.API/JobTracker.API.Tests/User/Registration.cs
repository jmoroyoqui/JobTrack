using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using Xunit;
using JobTracker.API.Controllers;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Http;
using JobTracker.API.Models;
using System.Text.Json;

namespace JobTracker.API.Tests.User
{
    public class Registration : TestBase
    {
        public Registration(WebApplicationFactory<Program> factory) : base(factory)
        {

        }

        [Fact]
        public async Task CreateUserEmtpyMethod_ReturnOK()
        {
            // Act
            var response = await _httpClient.PostAsJsonAsync("/user", string.Empty);
            response.EnsureSuccessStatusCode();

            Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
        }

        [Theory]
        [InlineData("", "test@test.com", "test", "test")]
        [InlineData("test", null, "test", "test")]
        [InlineData("test", "test@test.com", null, "test")]
        [InlineData("test","test@test.com","test", null)]
        public  async Task CreateUser_ReturnBadRequest(string name, string email, string username, string password)
        {
            var newUser = new Users
            {
                Id = 1,
                Name = name,
                Email = email,
                UserName = username,
                Password = password
            };

            var userJson = JsonSerializer.Serialize(newUser);

            var content = new StringContent(userJson, Encoding.UTF8, "application/json");

            var response = await  _httpClient.PostAsJsonAsync("/user/Create", content);

            Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
        }
    }
}
