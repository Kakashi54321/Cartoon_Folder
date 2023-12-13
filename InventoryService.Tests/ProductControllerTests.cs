using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace InventoryService.Tests;

public class ProductControllerTests
{
    [Fact]
    public async Task GetProducts_ReturnsCorrectType()
    {
        // Arrange
        var dbContextOptions = new DbContextOptionsBuilder<InventoryContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        using (var context = new InventoryContext(dbContextOptions))
        {
            var controller = new ProductController(context);

            // Act
            var result = await controller.GetProducts();

            // Assert
            Assert.IsType<ActionResult<IEnumerable<Product>>>(result);
        }
    }

}