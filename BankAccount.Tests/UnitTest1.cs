namespace BankAccountTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Deposit_ValidAmount_IncreasesBalance()
    {
        // Arrange
        BankAccount account = new BankAccount("Test", 1000);

        // Act
        account.Deposit(500);

        // Assert
        Assert.That(account.GetBalance(), Is.EqualTo(1500));
    }
}
