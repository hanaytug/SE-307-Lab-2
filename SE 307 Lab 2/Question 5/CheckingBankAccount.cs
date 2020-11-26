using System;

namespace SE_307_Lab_2
{
    public class CheckingBankAccount
    {
        public string AccountNumber { get => _accountNumber; set => _accountNumber = value; }
        private String _accountNumber;
        
        public string AccountHolder { get => _accountHolder; set => _accountHolder = value; }
        private String _accountHolder;
        
        private double _currentBalance;
        public double CurrentBalance { get => _currentBalance; set => _currentBalance = value; }

        public CheckingBankAccount(String accountNumber, String accountHolder, double currentBalance)
        {
            _accountNumber = accountNumber;
            _accountHolder = accountHolder;
            _currentBalance = currentBalance;
        }

        public void Deposit(double balance)
        {
            _currentBalance += balance;
        }

        public void ProcessCheck(double balance)
        {
            if (_currentBalance < 100)
            {
                _currentBalance -= 4.8;
            }

            _currentBalance -= balance;
        }

        public void Display()
        {
            Console.WriteLine("Account Number : " + _accountNumber);
            Console.WriteLine("Account Holder : " + _accountHolder);
            Console.WriteLine("Balance : " + _currentBalance);
        }
    }
}