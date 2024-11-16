namespace Projet_Banque;

 class CurrentAccount : Account //CompteCourant 
 { 
    private double _creditLine = 1000;
    public double CreditLine
    {
        get => _creditLine;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(CreditLine);
            _creditLine = value;
        }
    }  

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