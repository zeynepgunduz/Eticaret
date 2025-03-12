using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Eticaret.Core.Entities
{
    public class Contact:IEntity
    {
        public int Id { get; set; }
        [DisplayName("Adı")]

        public string Name { get; set; }
        [DisplayName("Soyadı")]

        public string Surname { get; set; }
        public string? Email { get; set; }
        [DisplayName("Telefon")]

        public string? Phone { get; set; }
        [DisplayName("Mesaj")]

        public string? Message { get; set; }
        [DisplayName("Oluşturulma Tarihi"), ScaffoldColumn(false)]

        public DateTime CreateDate { get; set; } =  DateTime.Now;
    }
}
