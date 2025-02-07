using OzdamarDepoAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzdamarDepoAPI.Domain.Entities
{
    public class MediaType:BaseEntity
    {
        public string Name { get; set; } // Türün adı ("CD", "DVD", vb.)
        public string Description { get; set; } // İsteğe bağlı açıklama

        // İlişkisel kullanım: Bu türdeki ürünleri çekebilmek için
        public ICollection<CDOrDVD> CDOrDVDs { get; set; }
    }
}
