namespace HomePage;

public class ProjectData
{
    public string Name { get; set; }

    public string Description { get; set; }

    public ProjectData(string name, string description)
    {
        Name = name;
        Description = description;
    }
}