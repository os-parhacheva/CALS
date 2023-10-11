using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALS.Domain
{
    public class Achievement
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Name { get;set; }
        public string Comment { get; set; }

        public List<Author> Authors { get; set; } = new List<Author>();
    }
}
