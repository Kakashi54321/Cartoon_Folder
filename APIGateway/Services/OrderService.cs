using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class OrderService
{
    private readonly HttpClient httpClient;

    public OrderService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<Order[]> GetOrders()
    {
        return await httpClient.GetFromJsonAsync<Order[]>("api/gateway/orders");
    }

    // Implement other CRUD operations as needed
}