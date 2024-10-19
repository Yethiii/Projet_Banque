namespace Projet_Banque;

public class Person
{
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public DateTime BirthDate {get;set;}

    public Person(string fname, string lname, DateTime date)
    {
        FirstName = fname;
        LastName = lname;
        BirthDate = date;
    }
}