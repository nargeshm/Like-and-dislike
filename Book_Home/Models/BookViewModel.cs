using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Home.Models
{
    public class BookViewModel
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int LikeCount { get; set; }
        public string Abstract { get; set; }

    }
}
