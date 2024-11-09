using Projet_Banque;

public class Savings : Account
{
    public DateTime DateLastWithDaw {get; set;}
    
    public Savings(string nb, double solde, DateTime date, Person owner)
        : base(nb, solde, owner)
    {
        DateLastWithDaw = date;
    }

    protected override double CalculInterets()
    {
        double tauxInterets = 0.045;
        return Balance + tauxInterets;
    }
}