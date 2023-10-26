using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    
    }
    class SqlServerDal:ICustomerDal
    {
        public void Add() { Console.WriteLine("SQL Added!"); }
        public void Update() { Console.WriteLine("SQL Updated!"); }
        public void Delete() { Console.WriteLine("SQL Deleted!"); }
    }
    class OracleCustomerrDal : ICustomerDal
    {
        public void Add() { Console.WriteLine("Oracle Added!"); }
        public void Update() { Console.WriteLine("Oracle Added!"); }
        public void Delete() { Console.WriteLine("Oracle Added!"); }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerdal)
        {
            customerdal.Add();
        }
    }
}
