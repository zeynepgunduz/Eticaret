﻿namespace Eticaret.Core.Entities
{
    public class Contact:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Surname { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Message { get; set; }
        public DateTime CreateDate { get; set; }// = new DateTime(2018, 12, 10);// DateTime.Now;
    }
}
