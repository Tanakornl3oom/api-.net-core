using System;
using test_project_api.Repositores;
using Xunit;

namespace test_project_api.Test
{
    public class RepositoriesTest
    {
        private IUserRepository _repository;

        public RepositoriesTest()
        {
            _repository = new UserRepository();
        }


        [Fact]
        public void Test1()
        {
            Assert.Equal("Test", "Test");
        }

        [Fact]
        public void GetUserNull()
        {
            // Act
            var result = _repository.Get(1);
            // Assert
            Assert.Null(result);

        }

        [Fact]
        public void GetUserNotNull()
        {
            // Act
            var result = _repository.Get(2);
            // Assert
            Assert.NotNull(result);

            Assert.True(result.GetType().GetProperty("Id") != null && result.Id > 0);
            Assert.True(result.GetType().GetProperty("Name") != null );
            Assert.True(result.GetType().GetProperty("created") != null && result.created == DateTime.MinValue);

        }
    }
}
