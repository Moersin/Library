using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    public class bType
    {
        private int bTypeId = 0;
        private string bookType = string.Empty;
        private int bookNum = 0;

        public int BTypeId { get => bTypeId; set => bTypeId = value; }
        public string BookType { get => bookType; set => bookType = value; }
        public int BookNum { get => bookNum; set => bookNum = value; }
    }
}
