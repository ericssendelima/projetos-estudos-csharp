using ContractSlicer.Core.Entities;

namespace ContractSlicer.Core.Tests.Entities
{
  public class InstalmentTests
  {
    [Fact]
    public void Instalment_ShouldBeCreated_WithCorrectValues()
    {
      // Arrange
      DateTime dueDate = new(2023, 10, 15);
      double amount = 150.75;

      // Act
      var instalment = new Installment(dueDate, amount);

      // Assert
      Assert.Equal(dueDate, instalment.Duedate);
      Assert.Equal(amount, instalment.Amount);
    }

    [Fact]
    public void Instalment_ShouldHandleEdgeCase_WithOtherAmount()
    {
      // Arrange
      DateTime dueDate = new(2024, 1, 1);
      double amount = 298.0;

      // Act
      var instalment = new Installment(dueDate, amount);

      // Assert
      Assert.Equal(dueDate, instalment.Duedate);
      Assert.Equal(amount, instalment.Amount);
    }
  }
}