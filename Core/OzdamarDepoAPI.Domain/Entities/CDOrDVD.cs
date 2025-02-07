using OzdamarDepoAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzdamarDepoAPI.Domain.Entities
{
    public class CDOrDVD:BaseEntity
    {
        public string Title { get; set; } // Başlık
        public string Description { get; set; } // Açıklama
        public decimal Price { get; set; } // Fiyat
        public int Stock { get; set; } // Mevcut stok miktarı
        public string ImageUrl { get; set; } // Ürün görsel URL'si

        // Yeni eklenen alanlar:
        public Guid MediaTypeId { get; set; } // İlgili MediaType ID'si
        public MediaType MediaType { get; set; } // Navigation property ile MediaType bilgisi

        public TimeSpan? Duration { get; set; } // Film süresi (varsa, DVD için)
        public Guid SubCategoryId { get; set; } // Alt kategori ID'si
        public SubCategory SubCategory { get; set; } // Alt kategori ile ilişki

        public ICollection<ArtistOrActor> ArtistOrActors { get; set; } // Sanatçı/Oyuncu ilişkisi
        public ICollection<Track> Tracks { get; set; } // Şarkı listesi (CD'ler için)
    }
}
