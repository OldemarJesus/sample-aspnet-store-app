using System.Text.Json;
using System.Text.Json.Serialization;

namespace sample_website_aspnet;

public class Product
{
    [JsonPropertyName("Id")]
    public string? Id { get; set; }
    [JsonPropertyName("Maker")]
    public string? Maker { get; set; }
    [JsonPropertyName("img")]
    public string? Image { get; set; }
    [JsonPropertyName("Url")]
    public string? Url { get; set; }
    [JsonPropertyName("Title")]
    public string? Title { get; set; }
    [JsonPropertyName("Description")]
    public string? Description { get; set; }
    public string? Rantings { get; set; }


    public override string ToString() => JsonSerializer.Serialize(this);

}
