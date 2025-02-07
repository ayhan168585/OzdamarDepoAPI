using OzdamarDepoAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzdamarDepoAPI.Domain.Entities
{
    public class User:BaseEntity
    {
        public string Username { get; set; } // Kullanıcı Adı
        public string Email { get; set; } // Email Adresi
        public string PasswordHash { get; set; } // Şifre Hash
        public string Role { get; set; } // Kullanıcı Rolü (Admin veya Normal Kullanıcı)
        public ICollection<Order> Orders { get; set; } // Kullanıcının Siparişleri
    }
}
