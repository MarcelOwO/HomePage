namespace HomePage.Models;

public class ProjectData
{
    public required string Name { get; set; }
    public string? ImageUrl { get; set; }
    public string? Description { get; set; }
    public string? Link { get; set; }
    public Type? Type { get; set; }
    public string? Language { get; set; }
}
