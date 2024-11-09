using Projet_Banque;

abstract public class Account
{
    public Person Owner { get; set; }
    public double Balance {get; private set; } //Solde 
    public string Number{get;set;} //N°Compte
    
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

    
    public void Withdraw(double amount) //Retrait
    {
        Balance -= amount;
        Console.WriteLine($"Voilà le solde après le retrait : {Balance}€");
    }

    public void Deposit(double amount) //Dépot 
    {
        Balance += amount;
        Console.WriteLine($"Voilà le solde après le dépot : {Balance}€");

    }
}



