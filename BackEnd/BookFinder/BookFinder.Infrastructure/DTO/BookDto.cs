using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFinder.Infrastructure.DTO
{
    public record BookDto(string title, string description, string author);
}
