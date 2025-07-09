

using Banking.Domain;

namespace Banking.Tests.Account;

public class MakingDeposits
{
    [Theory]
    [InlineData(100)]
    [InlineData(223.89)]
    [InlineData(0)] // should not pass
    [InlineData(-1002.29)] // should not pass
    public void MakingADepositIncreasesTheBalance(decimal AmountToDeposit)
    {
        // given
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        // when
        account.Deposit(AmountToDeposit);

        // then
        Assert.Equal(AmountToDeposit + openingBalance, account.GetBalance());
    }
}
