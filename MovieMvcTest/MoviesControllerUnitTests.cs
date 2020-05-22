using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using MovieMvc.Controllers;
using MvcMovie.Data;
using MvcMovie.Models;
using Xunit;

namespace MovieMvcTest
{
    public class MoviesControllerUnitTests
    {

        //[Fact]
        //public void Index_ActionExecutes_ReturnsAViewResult()
        //{
        //    // Arrange

        //    var mock = new Mock<MvcMovieContext>();
        //    mock.Setup(m => m.Movie = list).Returns(list);

        //    MoviesController controller = new MoviesController(mock.Object);

        //    // Act
        //    var result = controller.Index() as Task<ViewResult>;

        //    // Assert
        //    Assert.IsType<ViewResult>(result);
        //}
    }
}
