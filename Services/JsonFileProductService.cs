using System.Text.Json;

namespace sample_website_aspnet;

public class JsonFileProductService
{
    public IWebHostEnvironment WebHostEnvironment { get; }
    public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
    {
        WebHostEnvironment = webHostEnvironment;
    }


    private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json");

    public IEnumerable<Product>? GetProducts()
    {
        using var jsonFileReader = File.OpenText(JsonFileName);
        return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
        new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
    }
}
