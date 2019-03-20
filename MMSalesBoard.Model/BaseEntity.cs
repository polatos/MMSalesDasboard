using System;
using System.Collections.Generic;
using System.Text;

namespace MMSalesBoard.Models
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
    }
}
