using OzdamarDepoAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzdamarDepoAPI.Domain.Entities
{
    public class OrderItem:BaseEntity
    {
        public Guid OrderId { get; set; } // Sipariş ID'si
        public Order Order { get; set; } // Sipariş ile ilişki
        public Guid CDOrDVDId { get; set; } // CD/DVD ID'si
        public CDOrDVD CDOrDVD { get; set; } // CD/DVD ile ilişki
        public int Quantity { get; set; } // Sipariş Edilen Miktar
        public decimal Price { get; set; } // Birim Fiyat
    }
}
