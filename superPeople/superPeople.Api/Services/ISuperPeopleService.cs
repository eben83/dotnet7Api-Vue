namespace superPeople.Api.Services;

public interface ISuperPeopleService
{
    Task<List<SuperPeopleModel>> GetAll();

    Task<List<SuperPeopleModel>> AddPerson(SuperPeopleModel superPeopleModel);
}