using Projet_Banque;

 class Savings : Account
{
    public DateTime DateLastWithDaw {get; private set;}
    
    public Savings(string nb, double solde, DateTime date, Person owner)
        : base(nb, solde, owner)s
    {
        DateLastWithDaw = date;
    }

    protected override double CalculInterets()
    {
        double tauxInterets = 0.045;
        return Balance + tauxInterets;
    }
}