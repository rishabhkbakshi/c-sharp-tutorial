using System;

class Program
{
    static void Main()
    {
        BankAccountPublic bankAcctPub = new BankAccountPublic();

        // call a public method
        decimal amount = bankAcctPub.GetAmount();

        Console.WriteLine("Bank Account Amount: " + amount);

        BankAccountProtected[] bankAccts = new BankAccountProtected[2];
        bankAccts[0] = new SavingsAccount();
        bankAccts[1] = new CheckingAccount();

        foreach (BankAccountProtected acct in bankAccts)
        {
            // call public method, which invokes protected virtual methods
            acct.CloseAccount();
        }

        BankAccountExternal BankAcctExt = new BankAccountExternal();

        // call a public method
        amount = BankAcctExt.GetAmount();

        Console.WriteLine("External Bank Account Amount: " + amount);

    }
}
