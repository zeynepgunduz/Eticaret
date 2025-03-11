namespace Eticaret.Core.Entities
{
    public class News :IEntity

    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public bool IsActive { get; set; }
        public DateTime CretateDate { get; set; } //= new DateTime(2020, 10, 10);// DateTime.Now;
    }
}
