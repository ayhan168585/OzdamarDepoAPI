using OzdamarDepoAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzdamarDepoAPI.Domain.Entities
{
    public class SubCategory:BaseEntity
    {
        public string Name { get; set; } // Alt Kategori Adı (Örneğin: Rock, Klasik, Aksiyon, Komedi)
        public Guid CategoryId { get; set; } // Ana Kategorinin ID'si
        public Category Category { get; set; } // Ana Kategori ile ilişki
        public ICollection<CDOrDVD> CDOrDVDs { get; set; } // Alt Kategorideki CD/DVD'ler
    }
}
