namespace Projet_Banque;

public class CurrentAccount //CompteCourant
{
    public string Number{get;set;} //N°Compte
    public double Balance {get; private set; } //Solde 
    public double CreditLine{get;set;}  
    public Person Owner{get;set;} //Proprietaire

    public CurrentAccount(string nb, double solde, double credit, Person owner)
    {
        Number = nb;
        Balance = solde;
        CreditLine = credit;
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