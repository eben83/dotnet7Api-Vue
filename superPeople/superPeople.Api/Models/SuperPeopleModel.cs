namespace superPeople.Api.Models;

public class SuperPeopleModel
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public bool IsHero { get; set; }

}