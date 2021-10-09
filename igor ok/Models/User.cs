using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace igor_ok.Models
{
    public class User
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string SureName { get; set; }
        public string patronymic { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
