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
        public DateTime CreateDate { get; set; }
        public DateTime ChangeDate { get; set; }

    
}
}
