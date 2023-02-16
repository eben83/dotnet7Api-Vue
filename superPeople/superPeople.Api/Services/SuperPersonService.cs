using Microsoft.EntityFrameworkCore;

namespace superPeople.Api.Services;

public class SuperPersonService : ISuperPeopleService
{
    private readonly DataContext _dataContext;

    public SuperPersonService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }


    public async Task<List<SuperPeopleModel>> GetAll()
    {
        var data = await _dataContext.SuperPeopleModels.ToListAsync();
        return data;
    }

    public async Task<List<SuperPeopleModel>> AddPerson(SuperPeopleModel superPeopleModel)
    {
        _dataContext.SuperPeopleModels.Add(superPeopleModel);
        await _dataContext.SaveChangesAsync();
        return await _dataContext.SuperPeopleModels.ToListAsync();
    }
}