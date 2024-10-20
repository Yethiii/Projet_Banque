using Projet_Banque;

public class Savings : Account
{
    public DateTime DateLastWithDaw {get; set;}
    
    public Savings(string nb, double solde, DateTime date, Person owner)
        : base(nb, solde, owner)
    {
        DateLastWithDaw = date;
    }
   
}