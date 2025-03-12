using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.Entities
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        [DisplayName("Adı")]

        public string Name { get; set; }
        [DisplayName("Açıklama")]

        public string? Description { get; set; }
        public string?  Logo { get; set; }
        public  bool  IsActive { get; set; }
        [DisplayName("Sıra No")]

        public int OrderNo { get; set; }
        [DisplayName("Oluşturulma Tarihi"), ScaffoldColumn(false)]

        public DateTime CreateDate { get; set; } = DateTime.Now;// = new DateTime(2012, 12, 10);
        public IList<Product> Products { get; set; }


    }
}
