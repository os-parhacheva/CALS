using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Author
    {
       public Guid Id { get; set; }
        public string FIO { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public bool Confirmation { get; set; }

        public Guid IdAchievement { get; set; }
        public Achievement Achievement { get; set; } = new Achievement();


    }
}
