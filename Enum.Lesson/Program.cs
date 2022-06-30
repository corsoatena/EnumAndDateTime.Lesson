using System;
using System.Collections.Generic;
using System.IO;

namespace Enum.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const String path = @"C:\banks"; 

            Console.WriteLine(Exchange.BTC);
            Console.WriteLine(Transaction.CRYPTO);
            Bank Unicredit = new Bank("Unicredit", path);
            Bank IngDirect = new Bank("IngDirect", path);


            Cliente bruno = new Cliente("Bruno",40,"FRRMFK884NNFN");
            Unicredit.AddNewClient(bruno);
            IngDirect.AddNewClient(bruno);

        }
    } 
    
    public enum Transaction // label 
    {
        FIAT,
        CRYPTO
    }

    public struct Exchange
    {
        public static decimal BTC = 19250.00M;
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
    public class Saldo 
    {
          public Cliente Client;
          public decimal EURO = 0.00M;
          public decimal BTC = 0.00M;          

        public Saldo(Cliente _cliente)
        {
            Client = _cliente;
        }

        public string GetClientName()
        {
            return Client._name;
        }
    } 
    public class Bank
    {
        List<Cliente>  _clienti = new List<Cliente>();
        string _path;
        public string _name;

        public Bank(string Name, string path)
        {
            _name = Name;
            _path = path;
            CreateFolder(Path.Combine(_path,_name));
        }
        public string Withdraw(Cliente cliente,decimal Amount, Transaction transactionType)
        {
            switch (transactionType)
            {
                case Transaction.FIAT: 
                     /// Fa a fare il solito check su saldo FIAT
                     /// se è ok, preleva!
                     /// altriementi ->> errore!
                     /// Va a scrivere la transazione FIAT nel suo FILE 
                    break;
                case Transaction.CRYPTO:
                    /// Fa a fare il solito check su saldo CRYPTO
                    /// se è ok, preleva!
                    /// altriementi ->> errore!
                    ///  /// Va a scrivere la transazione CRYPTO nel suo FILE 
                    break;
                default:
                    break;
            }

            return "Prelievo Success!: " + 0.0M;
        }
        public void Deposit(Cliente cliente, decimal Amount, Transaction transactionType)
        {
        }
        public void ScriveLog(Cliente cliente, string OperationType, decimal Amount, Transaction transactionType)
        {
            /// cliente._cd --> Nome della Folder
            /// Vai nella subfolder con nome uguale a transactionType --> [FIAT, CRYPTO]
            /// Vai la riga della transazione. ---> [Data,CF,OperationType,Amount] 
            DateTime.Now.ToString(); 
        } 
        public void AddNewClient(Cliente cliente)
        {
            _clienti.Add(cliente);
            CreateFolder(cliente._cd);
        }
        static void CreateFolder(string FolderName)
        {   
            /// Crezion delle folder Cliente  -> Path + NomeBanca  + CF 
        }
    }
}
