using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class InventoryService
{
    private readonly HttpClient httpClient;

    public InventoryService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<InventoryItem[]> GetInventoryItems()
    {
        return await httpClient.GetFromJsonAsync<InventoryItem[]>("api/gateway/products");
    }

    // Implement other CRUD operations as needed
}