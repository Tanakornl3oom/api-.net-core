using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Moq;
using test_project_api.Controllers;
using test_project_api.Entity.models;
using test_project_api.Service;
using Xunit;

namespace test_project_api.Test
{
    public class ControllerTests
    {
        private UserController userController;

        private Mock<IQueryUser> _mockUserService;
        public ControllerTests()
        {
            _mockUserService = new Mock<IQueryUser>();
            userController = new UserController(_mockUserService.Object);
        }


        [Fact]
        public void Get()
        {
            //Arrange
            var users = new List<User>() { new User { Id = 0 } };

            //mock service
            _mockUserService.Setup(_ => _.getUsers()).Returns(users);

            //Act
            var response = userController.Get() as ObjectResult;

            //Assert
            Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)response.StatusCode);
            Assert.Equal(users,response.Value);
        }

    }
}
