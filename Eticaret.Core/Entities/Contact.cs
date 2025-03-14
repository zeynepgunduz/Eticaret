using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Eticaret.Core.Entities
{
    public class Contact:IEntity
    {
        public int Id { get; set; }
        [DisplayName("Adı"),Required(ErrorMessage ="{0} Alanı Boş Geçilemez!")]

        public string Name { get; set; }
       [DisplayName("Soyadı"), Required(ErrorMessage = "{0} Alanı Boş Geçilemez!")]

        public string Surname { get; set; }
        public string? Email { get; set; }
        [DisplayName("Telefon")]

        public string? Phone { get; set; }
        [DisplayName("Mesaj"), Required(ErrorMessage = "{0} Alanı Boş Geçilemez!")]

        public string? Message { get; set; }
        [DisplayName("Oluşturulma Tarihi"), ScaffoldColumn(false)]

        public DateTime CreateDate { get; set; } =  DateTime.Now;
    }
}
