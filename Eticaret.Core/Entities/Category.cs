﻿namespace Eticaret.Core.Entities
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public bool IsActive { get; set; }
        public bool IsTopMenu { get; set; }
        public int ParentId { get; set; }
        public int OrderNo { get; set; }
        public DateTime CreateDate { get; set; }// = new DateTime(2015, 12, 10);//DateTime.Now;

        public  IList<Product> Products{ get; set; } 


    }
}
