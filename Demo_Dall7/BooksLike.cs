using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Dall7
{
   public class BooksLike
    {
        public int BooksLikeId { get; set; }
        public DateTime LikeTime { get; set; }
        public bool IsLike { get; set; }
        public int? BookId { get; set; }
        public Book Books { get; set; }
    }
}
