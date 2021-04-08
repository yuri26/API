using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Efectura.Data.Model
{
    public class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        private DateTime date = DateTime.Now;
        public DateTime CreateDate { get { return date; } set { date = value; } }
        public DateTime ChangeDate { get { return date; } set { date = value; } }

    
}
}
