using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryModels;
using LibraryDal;

namespace LibraryBll
{
    public class AdminManager
    {
        AdminService admin =new AdminService();
        public bool CheckUserLogin(string loginId, string loginPwd)
        {
            try
            {
                return admin.CheckUserLogin(loginId, loginPwd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
