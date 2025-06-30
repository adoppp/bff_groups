using bff_groups.dataBase;
namespace bff_groups.Repositories;

public interface IClassesRepository
{
    Task<List<Classes>> GetClasses();
    Task<bool> AddClass(Classes classes);
    Task<bool> UpdateClass(Classes classes);
    Task<bool> DeleteClass(string id);
}