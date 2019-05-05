using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    public class Books
    {
        private int bookId = 0;
        private string bookName = string.Empty;
        private string bookAuthor = string.Empty;
        private string bookType = string.Empty;
        private string bookPublish = string.Empty;

        public int BookId { get => bookId; set => bookId = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string BookAuthor { get => bookAuthor; set => bookAuthor = value; }
        public string BookType { get => bookType; set => bookType = value; }
        public string BookPublish { get => bookPublish; set => bookPublish = value; }
    }
}
