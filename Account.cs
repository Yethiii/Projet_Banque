using Projet_Banque;

abstract public class Account : IBankAccount
{
    public Person Owner { get; private set; }
    public double Balance { get; private set; } //Solde 
    public string Number { get; private set; } //N°Compte

    public double GetBalance()
    {
        return Balance;
    }

    public Account(string nb, double solde, Person owner)
    {
        Number = nb;
        Balance = solde;
        Owner = owner;
    }
    
    public Account(string nb, Person owner)
    {
        Number = nb;
        Owner = owner;
    }


    public void Withdraw(double amount) //Retrait
    {
        if (amount > Balance)
        {
            throw new InsufficientBalanceException("Solde insuffisant !");
        }
        
        Balance -= amount;
        Console.WriteLine($"Voilà le solde après le retrait : {Balance}€");

        if (Balance < 0)
        {
            NegativeBalanceEvent?.Invoke(this);
        }
    }

    
    public void Deposit(double amount) //Dépot 
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Le montant ne peut pas être négatif !");
            }

            Balance += amount;
                Console.WriteLine($"Voilà le solde après le dépot : {Balance}€");
        }

    abstract protected double CalculInterets();

    public void ApplyInterest()
    {
        double interets = CalculInterets();
        Balance += interets;
        Console.WriteLine($"'Les intérêts de {interets} ont été apppliqués. Voilà le solde : {Balance} euros ");
    }
    
    public event NegativeBalanceDelegate NegativeBalanceEvent;
    

public interface IAccount

{
   public double Balance { get;}
    public void Withdraw(double amount);
    public void Deposit(double amount);
}

public interface IBankAccount : IAccount
{
    public Person Owner { get;}
    public string Number { get;}
    public void ApplyInterest();
    
    
}

public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
        Console.WriteLine(message);
    }
}

public delegate void NegativeBalanceDelegate(object Account);


