using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using MvcMovie.Controllers;
using Xunit;

namespace MovieMvcTest
{
    public class HelloWorldControllerTest
    {
        [Fact]
        public void Index_ActionExecutes_ReturnsAViewResult()
        {
            // Arrange
            var helloWorldController = new HelloWorldController();

            // Act
            var result = helloWorldController.Index();

            // Assert
            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public void Welcome_ReturnsAViewResult_WithMessageAndNumTime()
        {
            // Arrange
            var helloWorldController = new HelloWorldController();
            var message = "Hello Jack";
            var messageInput = "Jack";
            var numTimes = 4;

            // Act
            var result = helloWorldController.Welcome(messageInput, numTimes) as ViewResult;
            ViewDataDictionary viewData = result.ViewData;

            // Assert
            Assert.IsType<ViewResult>(result);
            Assert.Equal(message, viewData["message"]);
            Assert.Equal(numTimes, viewData["NumTimes"]);
        }
    }
}
