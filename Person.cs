namespace Projet_Banque;

public class Person
{
    public string FirstName {get; private set;}
    public string LastName {get;private set;}
    public DateTime BirthDate {get;private set;}

    public Person(string fname, string lname, DateTime date)
    {
        FirstName = fname;
        LastName = lname;
        BirthDate = date;
    }
}