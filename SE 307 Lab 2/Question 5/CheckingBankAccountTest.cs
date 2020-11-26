
namespace SE_307_Lab_2
{
    public class CheckingBankAccountTest
    {
        public void CheckingBankAccountScenario()
        {
            CheckingBankAccount checkingBankAccount = new CheckingBankAccount("12345", "Aytuğ HAN", 90);
            checkingBankAccount.Display();
            checkingBankAccount.ProcessCheck(200);
            checkingBankAccount.Display();
            checkingBankAccount.Deposit(5000);
            checkingBankAccount.Display();

            checkingBankAccount.AccountNumber = "123456";
            checkingBankAccount.Display();
        }
    }
}