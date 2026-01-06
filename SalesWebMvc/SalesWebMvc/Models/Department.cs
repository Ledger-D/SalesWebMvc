using SalesWebMvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {   // Atributos
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Seller> Sellers { get; set; }
            = new List<Seller>();

        // construtores
        public Department() { }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // Adiciona vendedor a lista => Seller (vendedores)
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }
        // Soma toda as vendas do departamento, de acordo com a data inicial e final de todos os  vendedores(Sellers)
        public double TotalSales(DateTime initial, DateTime final)
        { 
        
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }

    }
}
