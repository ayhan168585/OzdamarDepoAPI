using OzdamarDepoAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzdamarDepoAPI.Domain.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; set; } // Kategori Adı (Örneğin: Müzik, Film)
        public ICollection<SubCategory> SubCategories { get; set; } // Alt Kategoriler
    }
}
