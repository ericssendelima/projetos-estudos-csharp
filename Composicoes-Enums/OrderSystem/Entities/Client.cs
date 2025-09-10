namespace OrderSystem.Entities
{
  public class Client(string name, string email, DateTime birthDate)
  {
    private readonly string _name = name;
    private readonly string _email = email;
    private readonly DateTime _birthDate = birthDate;

    private string Name => _name;
    private string Email => _email;
    private DateTime BirthDate => _birthDate;

    public override string ToString()
    {
      return $"{Name} ({BirthDate.ToString("dd/MM/yyyy")}) - {Email}";
    }
  }
}