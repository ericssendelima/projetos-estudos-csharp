namespace WorkerContracts.Entities
{
  public class Departament(string name)
  {
    private readonly string _name = name;
    public string Name => _name;
  }
}