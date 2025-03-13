using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Eticaret.Core.Entities
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        [DisplayName("Adı")]

        public string Name { get; set; }
        [DisplayName("Açıklama")]

        public string? Description { get; set; }
        [DisplayName("Resim")]

        public string? Image { get; set; }
        public bool IsActive { get; set; }
        [DisplayName("Üst Menüde Göster")]

        public bool IsTopMenu { get; set; }
        [DisplayName("Üst Menü")]

        public int ParentId { get; set; }
        [DisplayName("Sıra No")]

        public int OrderNo { get; set; }
        [DisplayName("Oluşturulma Tarihi"), ScaffoldColumn(false)]

        public DateTime CreateDate { get; set; } = DateTime.Now;// = new DateTime(2015, 12, 10);//DateTime.Now;

        public  IList<Product>? Products{ get; set; } 


    }
}
