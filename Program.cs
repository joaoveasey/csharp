using System.Diagnostics;

class Program
{
    static void Main()
    {
        BankAccount account1 = new BankAccount("Joao", 100);
        BankAccount account2 = new BankAccount("Tiago", 100);

        account1.Deposit(100);
        account2.Deposit(100);

        account1.Remove(50);
        
        Console.WriteLine(account1.GetBalance);
        Console.WriteLine(account2.GetBalance);

        //Console.WriteLine(account2.GetBalance());
    }
    
}
class BankAccount
        {
            private string Name;
            private decimal Balance;

            public decimal GetBalance
            {
                get {return Balance;}
            }



            //criação do método construtor
            public BankAccount(string name, decimal balance) 
            {
                //verifica se o valor NAME é nulo ou um espaço em branco
                if(string.IsNullOrWhiteSpace(name)) //verifica
                {
                    throw new ArgumentException ($"Nome inválido", name);
                }
                //verifica se o valor BALANCE é menor que zero
                if(decimal.IsNegative(balance))
                {
                    throw new Exception ("O valor NEGATIVO não pode ser inserido");
                }
                this.Name = name;
                this.Balance = balance;
            }

            public void Deposit(decimal amount)
            {
                if(decimal.IsNegative(amount))
                {
                    return;     
                }
                Balance += amount;
            }

            public void Remove(decimal withdraw)
            {
                if(decimal.IsNegative(withdraw))
                {
                    Console.WriteLine("Não há como retirar um valor negativo");
                    return;     
                }
                if(decimal.IsNegative(Balance))
                {
                    Console.WriteLine("Seu saldo é negativo");
                }
                Balance -= withdraw;
            }

            //funciona como um get para retornar o valor da conta bancaria
            // public decimal GetBalance()
            // {
            //     return Balance;
            // }
        }
