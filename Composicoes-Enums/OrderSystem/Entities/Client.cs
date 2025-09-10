namespace OrderSystem.Entities
{
  public class Client(string name, string email, DateTime birthDate)
  {
    private readonly string _name = name;
    private readonly string _email = email;
    private readonly DateTime _birthDate = birthDate;

    public string Name => _name;
    public string Email => _email;
    public DateTime BirthDate => _birthDate;

  }
}