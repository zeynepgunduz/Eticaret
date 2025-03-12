using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Eticaret.Core.Entities
{
    public class News :IEntity

    {
        public int Id { get; set; }
        [DisplayName("Adı")]

        public string Name { get; set; }
        [DisplayName("Açıklama")]

        public string? Description { get; set; }
        [DisplayName("Resim")]

        public string? Image { get; set; }
        public bool IsActive { get; set; }
        [DisplayName("Oluşturulma Tarihi"), ScaffoldColumn(false)]

        public DateTime CretateDate { get; set; }= DateTime.Now;
    }
}
