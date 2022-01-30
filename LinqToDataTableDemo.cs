using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApp1
{
    class LinqToDataTableDemo
    {   
        public void AddtotableDataDemo()
        {
            DataTable tables = new DataTable();
            tables.Columns.Add("ID");
            tables.Columns.Add("ProductName");
            tables.Rows.Add("1", "Chai");
            tables.Rows.Add("2", "Omlet");
            tables.Rows.Add("3", "Tofu");

            DisplayProductsFromTable(tables);
        }
        public void DisplayProductsFromTable(DataTable tables)
        {
            var productNames = from products in tables.AsEnumerable() select products.Field<String>("ProductName");
            Console.WriteLine("product Name :");
            foreach (string productName in productNames)
            {
                Console.WriteLine(productName);
            }
        }
    }
}
