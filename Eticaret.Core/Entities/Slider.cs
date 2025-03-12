using System.ComponentModel;

namespace Eticaret.Core.Entities
{
    public class Slider : IEntity
    {
        public int Id { get; set; }
        [DisplayName("Başlık")]

        public string ? Title { get; set; }
        [DisplayName("Açıklama")]

        public string? Description { get; set; }
        [DisplayName("Resim")]

        public string? Image { get; set; }
        public string? Link { get; set; }
    }
}
