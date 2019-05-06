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
    public class IssService
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;
       
        #region 增加借阅
        //增加借阅
        public int AddIss(Iss iss)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("insert into Iss");
            sb.AppendLine("values(@issBookId,@issBookName,@issUserId,@issBeginTime,@issEndTime,@issStatus)");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                //new SqlParameter("@issId",iss.IssId),
                new SqlParameter("@issBookId",iss.IssBookId),
                new SqlParameter("@issBookName",iss.IssBookName),
                new SqlParameter("@issUserId",iss.IssUserId),
                new SqlParameter("@issBeginTime",iss.IssBeginTime),
                new SqlParameter("@issEndTime",iss.IssEndTime),
                new SqlParameter("@issStatus",iss.IssStatus)
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


        #region 根据读者id查询
        //根据读者id查询
        public List<Iss> GetIssByUserId(string issUserId)
        {
            List<Iss> isses = new List<Iss>();
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from Iss");
            sb.AppendLine("where issUserId = @issUserId");
            sb.AppendLine("order by issStatus");
            //参数
            SqlParameter[] paras =
            {
                new SqlParameter("@issUserId",issUserId)
            };
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //创建执行工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                cmd.Parameters.AddRange(paras);
                //执行
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                //判断
                while (reader.Read())
                {
                    Iss iss = new Iss();
                    iss.IssId = Convert.ToInt32(reader["IssId"]);
                    iss.IssStatus = Convert.ToString(reader["IssStatus"]);
                    iss.IssBookId = Convert.ToInt32(reader["IssBookId"]);
                    iss.IssBookName = Convert.ToString(reader["IssBookName"]);
                    iss.IssUserId = Convert.ToInt32(reader["IssUserId"]);
                    iss.IssBeginTime = Convert.ToDateTime(reader["IssBeginTime"]);
                    iss.IssEndTime = Convert.ToDateTime(reader["IssEndTime"]);
                    isses.Add(iss);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isses;
        }
        #endregion

        #region 更改借阅（归还）
        //更改借阅
        public int UpdateIss(Iss iss)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("update Iss");
            sb.AppendLine("set issBookId=@issBookId,issBookName=@issBookName,issUserId=@issUserId,issBeginTime=@issBeginTime,issEndTime=@issEndTime,issStatus=@issStatus");
            sb.AppendLine("where issId=@issId");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@issBookId",iss.IssBookId),
                new SqlParameter("@issBookName",iss.IssBookName),
                new SqlParameter("@issUserId",iss.IssUserId),
                new SqlParameter("@issBeginTime",iss.IssBeginTime),
                new SqlParameter("@issEndTime",iss.IssEndTime),
                new SqlParameter("@issStatus",iss.IssStatus),
                new SqlParameter("@issId",iss.IssId)
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

        #region 根据时间段查询书的数量
        public int QueryNumByTime(DateTime issBeginTime, DateTime issEndTime)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select COUNT(issId)");
            sb.AppendLine("from Iss");
            sb.AppendLine("where issBeginTime > @issBeginTime and issEndTime < @issEndTime");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@issBeginTime",issBeginTime),
                new SqlParameter("@issEndTime",issEndTime)
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
                int result = (int)cmd.ExecuteScalar();
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

        #region 根据读者id查询书的数量
        public int QueryNumByUserId(int issUserId)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select COUNT(issId)");
            sb.AppendLine("from Iss");
            sb.AppendLine("where issUserId=@issUserId");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@issUserId",issUserId)
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
                int result = (int)cmd.ExecuteScalar();
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
