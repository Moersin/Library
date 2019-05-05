using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using LibraryModels;
using System.Data;
using System.Data.SqlClient;

namespace LibraryDal
{
    public class BookService
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;

        #region 根据id和name查
        //其中编号直接查询，书名模糊查询
        public List<Books> GetBooksByNameAndType(string bookName,string bookType)
        {
            List<Books> books = new List<Books>();
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from Books");
            sb.AppendLine("where bookName like @bookName and bookType = @bookType");
            //参数
            SqlParameter[] paras =
            {
                new SqlParameter("@bookName","%"+bookName+"%"),
                new SqlParameter("@bookType",bookType)
            };
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //创建执行工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                //参数
                cmd.Parameters.AddRange(paras);
                conn.Open();
                //执行
                SqlDataReader reader = cmd.ExecuteReader();
                //判断
                while (reader.Read())
                {
                    Books bk = new Books();
                    bk.BookId = Convert.ToInt32(reader["BookId"]);
                    bk.BookName = Convert.ToString(reader["BookName"]);
                    bk.BookType = Convert.ToString(reader["BookType"]);
                    bk.BookAuthor = Convert.ToString(reader["BookAuthor"]);
                    bk.BookPublish = Convert.ToString(reader["BookPublish"]);
                    books.Add(bk);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return books;
        }
        #endregion

        #region name查
        //书名模糊查询
        public List<Books> GetBooksByName(string bookName)
        {
            List<Books> books = new List<Books>();
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from Books");
            sb.AppendLine("where bookName like @bookName");
            //参数
            SqlParameter[] paras =
            {
                new SqlParameter("@bookName","%"+bookName+"%")
            };
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //创建执行工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                //参数
                cmd.Parameters.AddRange(paras);
                conn.Open();
                //执行
                SqlDataReader reader = cmd.ExecuteReader();
                //判断
                while (reader.Read())
                {
                    Books bk = new Books();
                    bk.BookId = Convert.ToInt32(reader["BookId"]);
                    bk.BookName = Convert.ToString(reader["BookName"]);
                    bk.BookType = Convert.ToString(reader["BookType"]);
                    bk.BookAuthor = Convert.ToString(reader["BookAuthor"]);
                    bk.BookPublish = Convert.ToString(reader["BookPublish"]);
                    books.Add(bk);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return books;
        }
        #endregion

        #region 增
        //增
        public int AddBook(Books books)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("insert into Books");
            sb.AppendLine("values(@bookId,@bookName,@bookType,@bookAuthor,@bookPublish)");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@bookId",books.BookId),
                new SqlParameter("@bookName",books.BookName),
                new SqlParameter("@bookType",books.BookType),
                new SqlParameter("@bookAuthor",books.BookAuthor),
                new SqlParameter("@bookPublish",books.BookPublish)
            };
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //创建执行工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                //设置执行工具的参数
                cmd.Parameters.AddRange(paras);
                conn.Open();
                //执行
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //关闭数据库
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 根据Id删
        //根据编号删除书籍
        public int DeleteBooks(string bookId)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("delete from Books");
            sb.AppendLine("where @bookId=bookId");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@bookId",bookId)
            };
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //创建执行工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                //设置执行工具的参数
                cmd.Parameters.AddRange(paras);
                conn.Open();
                //执行
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //关闭数据库
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 改
        //改
        public int UpdateBooks(Books books)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("update Books");
            sb.AppendLine("set bookName=@bookName,bookType=@bookType,bookAuthor=@bookAuthor,bookPublish=@bookPublish");
            sb.AppendLine("where bookId=@bookId");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@bookName",books.BookName),
                new SqlParameter("@bookType",books.BookType),
                new SqlParameter("@bookAuthor",books.BookAuthor),
                new SqlParameter("@bookPublish",books.BookPublish),
                new SqlParameter("@bookId",books.BookId)
            };
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //创建执行工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                //设置执行工具的参数
                cmd.Parameters.AddRange(paras);
                conn.Open();
                //执行
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //关闭数据库
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 根据类别查询书的数量
        public int QueryNumByType(string bookType)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select COUNT(bookName)");
            sb.AppendLine("from Books");
            sb.AppendLine("where bookType=@bookType");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@bookType",bookType)
            };
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //创建执行工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                    //设置执行工具的参数
                    cmd.Parameters.AddRange(paras);
                    conn.Open();
                    //执行
                    //SqlDataReader reader = cmd.ExecuteReader();
                    int count = (int)cmd.ExecuteScalar();
                    //reader.Close();
                    return count;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            //关闭数据库
            finally
            {
                conn.Close();
            }
        }
        #endregion
    }
}
