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
    public class bTypeService
    {
        private readonly string connString= ConfigurationManager.ConnectionStrings["Library"].ConnectionString;
       
        #region 增加书籍类别
        //增加书籍类别
        public int AddBookType(bType btype)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("insert into BookType");
            sb.AppendLine("values (@bookType,@bookNum)");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@bookType",btype.BookType),
                new SqlParameter("@bookNum",btype.BookNum)
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

        #region 更改书籍类别
        //更改书籍类别
        public int UpdateBookType(bType btype)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("update BookType");
            sb.AppendLine("set bookType=@bookType");
            sb.AppendLine("where bTypeId=@bTypeId");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@bookType",btype.BookType),
                new SqlParameter("@bTypeId",btype.BTypeId)
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

        #region 根据类别删除书籍类别
        //根据类别删除书籍类别
        public int DeleteBookType(string bookType)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("delete from BookType");
            sb.AppendLine("where @bookType=bookType");
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

        #region 根据书籍类别获取书籍类别
        //根据书籍类别获取书籍类别
        public List<bType> GetbType(string bookType)
        {
            List<bType> btype = new List<bType>();
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select *");
            sb.AppendLine("from BookType");
            sb.AppendLine("where bookType like @bookType");
            sb.AppendLine("order by bTypeId desc");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@bookType","%"+bookType+"%")
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
                SqlDataReader reader = cmd.ExecuteReader();
                //判断
                while (reader.Read())
                {
                    bType bt = new bType();
                    bt.BTypeId= Convert.ToInt32(reader["BTypeId"]);
                    bt.BookType=Convert.ToString(reader["BookType"]);
                    btype.Add(bt);
                }
                reader.Close();
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
            return btype;
        }
        #endregion

        #region 更改书籍数量
        //更改书籍数量
        public int UpdateBookNum(bType btype)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("update BookType");
            sb.AppendLine("set bookNum=@bookNum");
            sb.AppendLine("where bookType=@bookType");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@bookNum",btype.BookNum),
                new SqlParameter("@bookType",btype.BookType)
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
    }
}
