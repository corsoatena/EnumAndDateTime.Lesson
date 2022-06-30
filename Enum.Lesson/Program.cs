using System;

namespace Enum.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Exchange.BTC);
            Console.WriteLine(Transaction.CRYPTO);
            Cliente bruno = new Cliente("Bruno",40,"FRRMFK884NNFN");
            Console.WriteLine(bruno._saldo.Client._name); 



        }
       
    } 
    
    public enum Transaction // label 
    {
        SEPA,
        CRYPTO
    }

    public struct Exchange
    {
        public static decimal BTC = 19000.89M; 
        public static decimal ETH = 1100.00M;
    }
    public class Cliente
    {
        public Saldo _saldo ;
        public string _name; 
        public int _age;
        public string _cd;

        public Cliente(string Name,  int Age, string Cd)
        {   
            _name = Name;
            _age = Age;
            _cd = Cd;
            _saldo = new Saldo(this); 
        }
    }
    public struct Saldo
    {
          public Cliente Client;
          public static decimal EURO = 1000.00M;
          public static decimal BTC = 1000.00M;

        public Saldo(Cliente _cliente)
        {
            Client = _cliente;
        }

        public string GetClientName()
        {
            return Client._name;
        }
    } 
    public class BankAccount
    {
        public static void Withdraw( decimal Amount)
        {           
            ///Preleva solo se hai abbastanza soldi! 
            ///altrimenti avvisa il cliente 
        }
    }


}
