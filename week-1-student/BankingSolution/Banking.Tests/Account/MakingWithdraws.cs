

using Banking.Domain;

namespace Banking.Tests.Account;

public class MakingWithdraws
{
    [Fact]
    public void MakingAWithdrawalDecreasesBalance()
    {
        // given
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = 20.23M;

        // when 
        account.Withdraw(amountToWithdraw);

        // then
        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }
}
