using OzdamarDepoAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzdamarDepoAPI.Domain.Entities
{
    public class Track:BaseEntity
    {
        public string Name { get; set; } // Şarkı Adı
        public TimeSpan Duration { get; set; } // Şarkı Süresi
        public Guid CDOrDVDId { get; set; } // CD ID'si
        public CDOrDVD CDOrDVD { get; set; } // CD ile ilişki
    }
}
