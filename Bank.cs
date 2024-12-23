﻿using Projet_Banque;

 class Bank
{
    private readonly Dictionary<string, Account> Accounts = [];
    private string Name { get; set; }

    public Bank(string bankName)
    {
        Name = bankName;
        Console.WriteLine(Name);
    }

    public void AddAccount(Account account)
    {
        if (Accounts.ContainsKey(account.Number))
        {
            Console.WriteLine("Ce compte existe déjà");
        }
        else
        {
            Accounts.Add(account.Number, account);
        }
    }


    public void DeleteAccount(Account account)
    {
        if (Accounts.ContainsKey(account.Number))
        {
            Accounts.Remove(account.Number);
        }
        else
            Console.Write("Ce compte n'existe pas !");

    }
    public void TotalSolde(Person client)
    {
        double solde = 0;
        
        foreach (var element in Accounts)
        {
            if (element.Value.Owner == client)
            {
                solde += element.Value.Balance;
            } ;
        }
        Console.WriteLine($"Le total des comptes de {client.FirstName} {client.LastName} : {solde} euros");
    }
}