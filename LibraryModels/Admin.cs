using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    [Serializable]
    public class Admin
    {
        private int loginId = 0;
        private string loginPwd = string.Empty;

        public string LoginPwd { get => loginPwd; set => loginPwd = value; }
        public int LoginId { get => loginId; set => loginId = value; }
    }
}
