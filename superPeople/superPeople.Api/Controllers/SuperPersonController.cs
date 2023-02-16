using Microsoft.AspNetCore.Mvc;
using superPeople.Api.Services;

namespace superPeople.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SuperPersonController : Controller
{
    private readonly ISuperPeopleService _superPeopleService;

    public SuperPersonController(ISuperPeopleService superPeopleService)
    {
        _superPeopleService = superPeopleService;
    }

    [HttpGet]
    public async Task<List<SuperPeopleModel>> GetAll()
    {
        return await _superPeopleService.GetAll();
    }

    [HttpPost]
    public async Task<ActionResult<List<SuperPeopleModel>>> AddPerson(SuperPeopleModel superPeopleModel)
    {
        var result = await _superPeopleService.AddPerson(superPeopleModel);
        return Ok(result);
    }
}