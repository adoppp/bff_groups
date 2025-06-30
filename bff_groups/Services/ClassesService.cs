using bff_groups.dataBase;
using bff_groups.Repositories;

namespace bff_groups.Services;

public class ClassesService
{
    private readonly IClassesRepository _repository;

    public ClassesService(IClassesRepository repository) => _repository = repository;

    public Task<List<Classes>> Get() => _repository.GetClasses();

    public Task<bool> Add(string name)
    {
        var newClass = new Classes
        {
            ClassName = name,
            Students = new List<Student>()
        };
        return _repository.AddClass(newClass);
    }

    public Task<bool> Put(Classes classes) => _repository.UpdateClass(classes);

    public Task<bool> Delete(string id) => _repository.DeleteClass(id);
}