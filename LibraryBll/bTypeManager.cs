using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryModels;
using LibraryDal;

namespace LibraryBll
{
    public class bTypeManager
    {
        bTypeService bs = new bTypeService();
        public int AddBookType(bType btype)
        {
            try
            {
                return bs.AddBookType(btype);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateBookType(bType btype)
        {
            try
            {
                return bs.UpdateBookType(btype);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteBookType(string bookType)
        {
            try
            {
                return bs.DeleteBookType(bookType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<bType> GetbType(string bookType)
        {
            try
            {
                return bs.GetbType(bookType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
