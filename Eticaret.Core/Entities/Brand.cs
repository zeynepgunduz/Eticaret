﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Core.Entities
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string?  Logo { get; set; }
        public  bool  IsActive { get; set; }
        public int OrderNo { get; set; }
        public DateTime CreateDate { get; set; }// = new DateTime(2012, 12, 10);
        public IList<Product> Products { get; set; }


    }
}
