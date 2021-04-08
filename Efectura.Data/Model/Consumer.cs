using System;
using System.Collections.Generic;
using System.Text;

namespace Efectura.Data.Model
{
    public class Consumer : BaseEntity
    {
        public int TCKN { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Adress { get; set; }


    }
}
