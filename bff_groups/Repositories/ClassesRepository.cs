using bff_groups.dataBase;
using System.Net.Http.Json;

namespace bff_groups.Repositories;

public class ClassesRepository : IClassesRepository
{
    private readonly HttpClient _http;

    public ClassesRepository(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Classes>> GetClasses()
    {
        return await _http.GetFromJsonAsync<List<Classes>>("classes") ?? new List<Classes>();
    }

    public async Task<bool> AddClass(Classes classes)
    {
        var response = await _http.PostAsJsonAsync("classes", classes);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> UpdateClass(Classes updatedClass)
    {
        var response = await _http.PutAsJsonAsync($"classes/{updatedClass.Id}", updatedClass);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteClass(string id)
    {
        var response = await _http.DeleteAsync($"classes/{id}");
        return response.IsSuccessStatusCode;
    }
}