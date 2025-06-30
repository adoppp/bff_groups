namespace bff_groups.dataBase;

public class Classes
{
    public string Id { get; set; } = string.Empty; 
    public string ClassName { get; set; } = string.Empty;
    public List<Student> Students { get; set; } = new();
}