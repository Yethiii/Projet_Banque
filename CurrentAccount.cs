namespace Projet_Banque;

public class CurrentAccount : Account //CompteCourant 
{
    public double CreditLine{get;set;}  

    public CurrentAccount(string nb, double solde, double credit, Person owner)
        : base(nb, solde, owner)
    {
        CreditLine = credit;
    }
    
    protected override double CalculInterets()
    {
        double tauxInterets = 0.030;
        double tauxInteretsNeg = 0.0975;

        if (Balance > 0)
        {
            return Balance * tauxInterets;
        }
        else
        {
            return Balance * tauxInteretsNeg;
        }
    }
}