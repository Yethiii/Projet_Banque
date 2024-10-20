namespace Projet_Banque;

public class CurrentAccount : Account //CompteCourant 
{
    public double CreditLine{get;set;}  

    public CurrentAccount(string nb, double solde, double credit, Person owner)
        : base(nb, solde, owner)
    {
        CreditLine = credit;
    }
    
}