using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class GatewayController : ControllerBase
{
    private readonly IHttpClientFactory _httpClientFactory;

    public GatewayController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [HttpGet("products")]
    public async Task<IActionResult> GetProducts()
    {
        var productBaseUrl = "http://product-service/api/product"; // Replace with the actual URL of your Product service

        var httpClient = _httpClientFactory.CreateClient();
        var response = await httpClient.GetAsync($"{productBaseUrl}");
        var content = await response.Content.ReadAsStringAsync();

        return Content(content, response.Content.Headers.ContentType?.ToString());
    }

    [HttpGet("orders")]
    public async Task<IActionResult> GetOrders()
    {
        var orderBaseUrl = "http://order-service/api/order"; // Replace with the actual URL of your Order service

        var httpClient = _httpClientFactory.CreateClient();
        var response = await httpClient.GetAsync($"{orderBaseUrl}");
        var content = await response.Content.ReadAsStringAsync();

        return Content(content, response.Content.Headers.ContentType?.ToString());
    }


}