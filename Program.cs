var MyClient = new Person("Laetitia", "VOUE", new DateTime(1990,05,02));

public class Person (string fname, string lname, DateTime date)
{
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public DateTime BirthDate {get;set;}
}

public class CurrentAccount //CompteCourant
{
    public string Number{get;set;}
    public double Balance {get; private set; } 
    public double CreditLine{get;set;} 
    public Person Owner{get;set;}

    public void Withdraw(double amount)
    {
        Balance -= amount
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

}

public class Bank
{
    private readonly Dictionary<string, CurrentAccount> Account;
    private string Name;

    public void AddAccount(CurrentAccount account)
    {
        
    }

    public void DeleteAccount(string number)
    {
        
    }
}
