using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    public class Students
    {
        private int loginId = 0;
        private string loginPwd = string.Empty;
        private string name = string.Empty;
        private string sex = string.Empty;
        private string userType = string.Empty;
        private string tell = string.Empty;
        private string email = string.Empty;
        private string address = string.Empty;

        public static string value;

        public string LoginPwd { get => loginPwd; set => loginPwd = value; }
        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public string UserType { get => userType; set => userType = value; }
        public string Tell { get => tell; set => tell = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public int LoginId { get => loginId; set => loginId = value; }
    }
}
