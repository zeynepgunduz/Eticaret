using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Eticaret.Core.Entities
{
    public class AppUser:IEntity
    {
        public int Id { get; set; }
        [DisplayName("Adı")]
        public string Name { get; set; }
        [DisplayName("Soyadı")]
        public string Surname { get; set; }
        public string Email { get; set; }
        [DisplayName("Telefon")]
        public string? Phone { get; set; }
        [DisplayName("Şifre")]
        public string Password { get; set; }
        [DisplayName("Kullanıcı Adı")]
        public string? Username { get; set; }=string.Empty;
        public bool IsActive { get; set; }
        public bool  IsAdmin { get; set; }
        [DisplayName("Oluşturulma Tarihi"),ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; }=DateTime.Now;
        [ScaffoldColumn(false)]// bu alanın scaffold edilmesini istemiyorum
        public Guid? UserGuid { get; set; } = Guid.NewGuid();
    }
}
