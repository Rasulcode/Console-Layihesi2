using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapsiriq
{
    public enum Category { Shirniyyat = 1, Meyve_Terevez, Ichki, Et, Meishet };

    class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public Category Category { get; set; }
        private int _codecount = 1000;
        public Product(string name, double price, Category category,int count)
        {
            _codecount++;
            Name = name;
            Price = price;
            Category = category;
            Count = count;
            Code = Name.Trim().ToUpper().Substring(0, 2) + _codecount;
        }

        public override string ToString()
        {
            return $"Kod: {Code} | Ad: {Name} | Qiymet: {Price} | Say: {Count} | Kateqoriya: {Category}";  
        }
    }
}
