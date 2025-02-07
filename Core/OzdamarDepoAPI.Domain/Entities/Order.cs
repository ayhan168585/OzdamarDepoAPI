using OzdamarDepoAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzdamarDepoAPI.Domain.Entities
{
    public class Order:BaseEntity
    {
        public DateTime OrderDate { get; set; } // Sipariş Tarihi
        public decimal TotalAmount { get; set; } // Toplam Tutar
        public Guid UserId { get; set; } // Kullanıcı ID'si
        public User User { get; set; } // Kullanıcı ile ilişki
        public ICollection<OrderItem> OrderItems { get; set; } // Sipariş Kalemleri
    }
}
