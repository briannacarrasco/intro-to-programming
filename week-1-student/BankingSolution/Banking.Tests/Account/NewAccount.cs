﻿
using Banking.Domain;

namespace Banking.Tests.Account;

public class NewAccount
{
    // newly opened bank account have a starting balance $5000.00
    [Fact]
    public void NewAccountsHaveCorrectOpeningBalance()
    {
        var account = new BankAccount();
        var expectedOpeningBalance = 5000.00M;
        decimal actualBalance = account.GetBalance();

        Assert.Equal(expectedOpeningBalance, actualBalance);
    }
}
