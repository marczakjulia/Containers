namespace Containers.Models;

public class Container
{
    public int ID { get; set; }
    public int ContainerTypeId { get; set; }
    public bool IsHazardous { get; set; }
    public string Name { get; set; }
}