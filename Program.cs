using System.Buffers;
using System.Xml;
using Projet_Banque;

Person myClient = new Person("Laetitia", "VOUE", new DateTime(1990,05,02));
Bank myBank = new Bank("Argenta");
Account myAccount = new CurrentAccount("1", 1500, 5000, myClient);
Account myAccount2 = new CurrentAccount("2", 3500, 5000, myClient);
Account myAccount3 = new CurrentAccount("2", 4500, 5000, myClient);
myBank.AddAccount(myAccount);
myBank.AddAccount(myAccount2);
myBank.AddAccount(myAccount3);
myAccount.Deposit(20);
Console.WriteLine(myAccount.Balance);
Console.WriteLine(myAccount2.Balance);
myBank.TotalSolde(myClient);
