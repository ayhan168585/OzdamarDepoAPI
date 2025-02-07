using OzdamarDepoAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzdamarDepoAPI.Domain.Entities
{
    public class ArtistOrActor:BaseEntity
    {
        public string Name { get; set; } // Sanatçı veya Oyuncu Adı
        public string Role { get; set; } // Rol (Örneğin: Şarkıcı, Oyuncu, Yönetmen)
        public ICollection<CDOrDVD> CDOrDVDs { get; set; } // İlgili CD/DVD'ler
    }
}
