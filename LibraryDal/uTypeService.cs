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
    public class uTypeService
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;

        #region 增加读者类别
        //增加读者类别
        public int AddUserType(uType utype)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("insert into UserType");
            sb.AppendLine("values(@userType)");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@userType",utype.UserType)
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

        #region 更改读者类别
        //更改读者类别
        public int UpdateUserType(uType utype)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("update UserType");
            sb.AppendLine("set userType=@userType");
            sb.AppendLine("where uTypeId=@uTypeId");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@userType",utype.UserType),
                new SqlParameter("@uTypeId",utype.UTypeId)
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

        #region 根据类别删除读者类别
        //根据类别删除读者类别
        public int DeleteUserType(string userType)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("delete from UserType");
            sb.AppendLine("where @userType=userType");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@userType",userType)
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

        #region 根据用户类别获取读者类别
        //根据用户类别获取读者类别
        public List<uType> GetuType(string userType)
        {
            List<uType> utype = new List<uType>();
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select *");
            sb.AppendLine("from UserType");
            sb.AppendLine("where userType like @userType");
            sb.AppendLine("order by uTypeId desc");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@userType","%"+userType+"%")
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
                    uType ut = new uType();
                    ut.UTypeId= Convert.ToInt32(reader["UTypeId"]);
                    ut.UserType = Convert.ToString(reader["UserType"]);
                    utype.Add(ut);
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
            return utype;
        }
        #endregion

        #region 获取读者类别
        public List<uType> GetUserData()
        {
            List<uType> u = new List<uType>();
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select userType from UserType");
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //创建执行工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                //执行
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                //判断
                while (reader.Read())
                {
                    uType ut = new uType();
                    ut.UserType = Convert.ToString(reader["UserType"]);
                    u.Add(ut);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return u;
        }
        #endregion
    }
}
