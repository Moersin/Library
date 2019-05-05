using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    public class uType
    {
        private int uTypeId = 0;
        private string userType = string.Empty;

        public int UTypeId { get => uTypeId; set => uTypeId = value; }
        public string UserType { get => userType; set => userType = value; }
    }
}
