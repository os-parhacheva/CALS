using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Achievement
    {
        Guid Id { get; set; }
        int Number { get; set; }
        string Name { get;set; }
        string Comment { get; set; }

        List<Author> Authors { get; set; }
    }
}
