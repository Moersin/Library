using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryModels;
using LibraryDal;

namespace LibraryBll
{
    public class uTypeManager
    {
        uTypeService us = new uTypeService();
        public int AddUserType(uType utype)
        {
            try
            {
                return us.AddUserType(utype);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateUserType(uType utype)
        {
            try
            {
                return us.UpdateUserType(utype);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteUserType(string userType)
        {
            try
            {
                return us.DeleteUserType(userType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<uType> GetuType(string userType)
        {
            try
            {
                return us.GetuType(userType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<uType> GetUserData()
        {
            try
            {
                return us.GetUserData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
