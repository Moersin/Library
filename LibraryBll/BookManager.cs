using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryModels;
using LibraryDal;

namespace LibraryBll
{
    public class BookManager
    {
        BookService bs = new BookService();

        #region 查
        //根据条件获取书籍信息
        public List<Books> GetBooksByNameAndType(string bookName,string bookType)
        {
            try
            {
                return bs.GetBooksByNameAndType(bookName,bookType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 根据书名获取书籍信息
        //根据书名获取书籍信息
        public List<Books> GetBooksByName(string bookName)
        {
            try
            {
                return bs.GetBooksByName(bookName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 增
        public int AddBook(Books books)
        {
            try
            {
                return bs.AddBook(books);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 改
        public int UpdateBook(Books books)
        {
            try
            {
                return bs.UpdateBooks(books);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 删
        public int DeleteBook(string bookId)
        {
            try
            {
                return bs.DeleteBooks(bookId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 根据类别查询书的数量
        public int QueryNumByType(string bookType)
        {
            try
            {
                return bs.QueryNumByType(bookType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
