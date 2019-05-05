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

    //提供读者信息
    public class StudentsService
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;
        #region 检查读者是否存在
        //检查读者是否存在
        public bool CheckStudentsIsExists(int loginId)
        {
            bool flag = false;
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select count(*)");
            sb.AppendLine("select * from Students");
            sb.AppendLine("where loginId=@loginId");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@loginId",loginId)
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
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                //判断
                if (result > 0)
                {
                    flag = true;
                }
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
            return flag;
        }
        #endregion

        #region 检查读者登陆
        //检查读者登陆
        public bool CheckStudentsLogin(string loginId, string loginPwd)
        {
            //true登陆成果，false登陆失败
            bool flag = false;
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from Students");
            sb.AppendLine("where loginId=@loginId and loginPwd=@loginPwd");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@loginId",loginId),
                new SqlParameter("@loginPwd",loginPwd)
            };
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //创建执行工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                //设置执行工具的参数
                cmd.Parameters.AddRange(paras);
                //打开连接
                conn.Open();
                //执行
                SqlDataReader reader = cmd.ExecuteReader();
                //判断
                if (reader.Read())
                {
                    flag = true;
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
            return flag;
        }
        #endregion

        #region 根据读者id获取读者信息
        //根据读者id获取读者信息
        public Students GetStudentsById(int loginId)
        {
            Students stu = null;
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select *");
            sb.AppendLine("from Students");
            sb.AppendLine("where loginId=@loginId");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@loginId",loginId)
            };
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //创建执行工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                //设置执行工具的参数
                cmd.Parameters.AddRange(paras);
                //执行
                SqlDataReader reader = cmd.ExecuteReader();
                //判断
                if (reader.Read())
                {
                    stu = new Students();
                    stu.LoginId = loginId;
                    stu.LoginPwd = Convert.ToString(reader["LoginPwd"]);
                    stu.Name = Convert.ToString(reader["Name"]);
                    stu.Sex = Convert.ToString(reader["Sex"]);
                    stu.Tell = Convert.ToString(reader["Tell"]);
                    stu.Address = Convert.ToString(reader["Address"]);
                    stu.Email = Convert.ToString(reader["Email"]);
                    stu.UserType = Convert.ToString(reader["UserType"]);
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
            return stu;
        }
        #endregion

        #region 增加读者
        //增加读者
        public int AddStudent(Students students)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("insert into Students");
            sb.AppendLine("values(@loginId,@loginPwd,@name,@sex,@userType,@tell,@address,@email)");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@loginId",students.LoginId),
                new SqlParameter("@loginPwd",students.LoginPwd),
                new SqlParameter("@name",students.Name),
                new SqlParameter("@sex",students.Sex),
                new SqlParameter("@userType",students.UserType),
                new SqlParameter("@tell",students.Tell),
                new SqlParameter("@address",students.Address),
                new SqlParameter("@email",students.Email)
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

        #region 更改读者
        //更改读者
        public int UpdateStudent(Students students)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("update Students");
            sb.AppendLine("set loginPwd=@loginPwd,name=@name,sex=@sex,userType=@userType,tell=@tell,address=@address,email=@email ");
            sb.AppendLine("where loginId=@loginId");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@loginPwd",students.LoginPwd),
                new SqlParameter("@name",students.Name),
                new SqlParameter("@sex",students.Sex),
                new SqlParameter("@userType",students.UserType),
                new SqlParameter("@tell",students.Tell),
                new SqlParameter("@address",students.Address),
                new SqlParameter("@email",students.Email),
                new SqlParameter("@loginId",students.LoginId)
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

        #region 根据学号删除读者信息
        //根据学号删除读者信息
        public int DeleteStudent(string loginId)
        {
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("delete from Students");
            sb.AppendLine("where @loginId=loginId");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@loginId",loginId)
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

        #region 获取读者全部信息
        //获取读者全部信息
        public List<Students> GetStudentsData()
        {
            List<Students> students = new List<Students>();
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from Students");
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
                    Students stu = new Students();
                    stu.LoginId = Convert.ToInt32(reader["LoginId"]);
                    stu.LoginPwd = Convert.ToString(reader["LoginPwd"]);
                    stu.Name = Convert.ToString(reader["Name"]);
                    stu.Sex = Convert.ToString(reader["Sex"]);
                    stu.Tell = Convert.ToString(reader["Tell"]);
                    stu.Address = Convert.ToString(reader["Address"]);
                    stu.Email = Convert.ToString(reader["Email"]);
                    stu.UserType = Convert.ToString(reader["UserType"]);
                    students.Add(stu);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return students;
        }
        #endregion

        #region 根据姓名或类别查询
        //根据姓名或类别查询
        public List<Students> GetStudentsDataByNameAndType(string name,string userType)
        {
            List<Students> students = new List<Students>();
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from Students");
            sb.AppendLine("where name like  @name and userType = @userType");
            //参数
            SqlParameter[] paras =
            {
                new SqlParameter("@name","%"+name+"%"),
                new SqlParameter("@userType",userType)
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
                    Students stu = new Students();
                    stu.LoginId = Convert.ToInt32(reader["LoginId"]);
                    stu.LoginPwd = Convert.ToString(reader["LoginPwd"]);
                    stu.Name = Convert.ToString(reader["Name"]);
                    stu.Sex = Convert.ToString(reader["Sex"]);
                    stu.Tell = Convert.ToString(reader["Tell"]);
                    stu.Address = Convert.ToString(reader["Address"]);
                    stu.Email = Convert.ToString(reader["Email"]);
                    stu.UserType = Convert.ToString(reader["UserType"]);
                    students.Add(stu);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return students;
        }
        #endregion

        #region 根据读者id获取读者name
        //根据读者id获取读者name
        public List<Students> GetNameById(string loginId)
        {
            List<Students> students = new List<Students>();
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select name");
            sb.AppendLine("from Students");
            sb.AppendLine("where loginId=@loginId");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@loginId",loginId)
            };
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //创建执行工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                //设置执行工具的参数
                cmd.Parameters.AddRange(paras);
                //执行
                SqlDataReader reader = cmd.ExecuteReader();
                //判断
                if (reader.Read())
                {
                    Students stu = new Students();
                    stu.LoginId = Convert.ToInt32(loginId);
                    stu.LoginPwd = Convert.ToString(reader["LoginPwd"]);
                    stu.Name = Convert.ToString(reader["Name"]);
                    stu.Sex = Convert.ToString(reader["Sex"]);
                    stu.Tell = Convert.ToString(reader["Tell"]);
                    stu.Address = Convert.ToString(reader["Address"]);
                    stu.Email = Convert.ToString(reader["Email"]);
                    stu.UserType = Convert.ToString(reader["UserType"]);
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
            return students;
        }
        #endregion
    }
}

