using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Author
    {
        Guid Id { get; set; }
        string FIO { get; set; }
        string Email { get; set; }
        string Number { get; set; }
        bool Confirmation { get; set; }


    }
}
